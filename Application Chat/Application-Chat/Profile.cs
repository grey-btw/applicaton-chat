using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace Application_Chat
{
    public partial class Profile : Form
    {
        private Panel leftBorderBtn;
        private IconButton currentBtn = null;
        private Regex rg = new Regex(@"^[a-zA-z0-9 ]{6, 16}$");
        private Font fontRegular = new Font(new FontFamily("Segoe UI"), 13.0f, FontStyle.Regular);
        private Font fontBold = new Font(new FontFamily("Segoe UI"), 13.0f, FontStyle.Bold);
        private const int ChangeAlias = 12,  
                          ChangePassword = 11,
                          ChangePhoto = 13;

        public Profile()
        {
            InitializeComponent();
            setUp();
        }
        private void RecvData(int flag, string commandId)
        {
            Client.ModelObject data = new Client.ModelObject();
            int p = 0;
            while (p < 5000)
            {
                Thread.Sleep(50);
                data = register.socket.GetCommandResult(commandId);
                if ((data != null))
                {
                    switch (flag)
                    {
                        case ChangeAlias:
                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Something went wrong, cant change profile!");
                                break;
                            }
                            
                            ClientForm.currentUser.alias = textbox1.Text;
                            ClientForm.currentUser.email = textbox2.Text;
                            MessageBox.Show("Successful");
                            break;
                        case ChangePassword:
                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Faild to change password!");
                                break;
                            }
                            ClientForm.currentUser.pass = register.SHA256HexHashString(textbox3.Text);
                            MessageBox.Show("Successful");
                            break;

                    }
                    return;
                }
                p += 50;
            }
            MessageBox.Show("Timeout!");
        }
        private void setUp()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 96);
            leftBorderBtn.BackColor = Color.Black;
            panelLeft.Controls.Add(leftBorderBtn);

            username.Text = $"Username: {ClientForm.currentUser.name}";
            if (ClientForm.currentUser.ava != null)
                avatar.Image = Base64ToImage(ClientForm.currentUser.ava);

        }
        private void disableCurrentButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Font = fontRegular;
            }
        }

        private void VisiblePanelMain()
        {
            avatar.Visible = true;
            username.Visible = true;
            labelChangePhoto.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textbox1.Visible = true;
            textbox2.Visible = true;
            btnSubmit.Visible = true;
        }   
        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                disableCurrentButton(); 
                currentBtn = (IconButton)sender;
                currentBtn.Font = fontBold;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void btnEditProfile_MouseEnter(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void btnEditProfile_MouseLeave(object sender, EventArgs e)
        {
            btnEditProfile.BackColor = Color.White;
        }
        
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (currentBtn == null)
                VisiblePanelMain();
            ActiveButton(sender);
            if (currentBtn.Text == btnEditProfile.Text)
            {
                label1.Text = "Name";
                label2.Text = "Email";
                textbox1.Text = ClientForm.currentUser.alias;
                textbox2.Text = ClientForm.currentUser.email;
                label3.Visible = false;
                textbox3.Visible = false;
                labelChangePhoto.Visible = true;

                label1.Location = new Point(115, 217);
                label2.Location = new Point(115, 292);
                btnSubmit.Location = new Point(371, 402);
                btnSubmit.Enabled = false;
                textbox1.UseSystemPasswordChar = false;
                textbox2.UseSystemPasswordChar = false;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (currentBtn == null)
                VisiblePanelMain();

            ActiveButton(sender);
            
            if (currentBtn.Text == btnChangePass.Text)
            {
                label1.Text = "Old Password";
                label2.Text = "New Password";
                label3.Visible = true;

                textbox1.Text = "";
                textbox3.Text = "";
                textbox2.Text = "";
                textbox3.Visible = true;
                labelChangePhoto.Visible = false;

                label1.Location = new Point(80, 217);
                label2.Location = new Point(80, 293);
                btnSubmit.Location = new Point(371, 443);
                btnSubmit.Enabled = false;

                textbox1.UseSystemPasswordChar = true;
                textbox2.UseSystemPasswordChar = true;
            }

        }
   
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(currentBtn == btnEditProfile)
            {

                int id = Program.RandomNumber(0, 2 ^ 32);
                Client.ModelObject Send = new Client.ModelObject();
                Send.command.code = "12";
                Send.command.id = $"{id}";

                Send.user.ava = ClientForm.currentUser.ava;
                Send.user.alias = textbox1.Text;
                Send.user.name = ClientForm.currentUser.name;
                Send.user.email = textbox2.Text;

                register.socket.Send(Send);
                RecvData(12, Send.command.id);
                textbox1.Text = ClientForm.currentUser.alias;
                textbox2.Text = ClientForm.currentUser.email;
            }
            else
            {
                if (!rg.IsMatch(username.Text))
                {
                    MessageBox.Show("The length of password must be 6-16");
                    return;
                }
                string messageDigest = register.SHA256HexHashString(textbox1.Text);
                if(messageDigest != ClientForm.currentUser.pass)
                {
                    MessageBox.Show("Wrong password! Please try again.");
                }
                else if(textbox1.Text == textbox2.Text)
                {
                    MessageBox.Show("The new password must be different the old password!");
                }
                else
                {
                    int id = Program.RandomNumber(0, 2 ^ 32);
                    Client.ModelObject Send = new Client.ModelObject();
                    Send.command.code = "11";
                    Send.command.id = $"{id}";

                    Send.user.pass = register.SHA256HexHashString(textbox3.Text);
                    Send.user.alias = ClientForm.currentUser.alias;
                    Send.user.ava = ClientForm.currentUser.ava;
                    Send.user.email = ClientForm.currentUser.email;
                    Send.user.name = ClientForm.currentUser.name;


                    register.socket.Send(Send);
                    RecvData(11, Send.command.id);
                    textbox1.Text = "";
                    textbox2.Text = "";
                    textbox3.Text = "";

                }

            }
        }

        private void labelChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            
            if (op.ShowDialog() == DialogResult.OK)
            {
                if ((int)new System.IO.FileInfo(op.FileName).Length >  300 * 1024)
                {
                    MessageBox.Show("The size of image is too large");
                    return;
                }

                string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\data\";
                if (Directory.Exists(appPath) == false)
                {
                    Directory.CreateDirectory(appPath);
                }

                try
                {
                    var filePath = op.FileName;

                    string iName = op.SafeFileName;   
                    string filepath = op.FileName;
                    Bitmap x = new Bitmap(op.OpenFile());

                    avatar.Image = (Image)x;

                    byte[] imageBytes = ImageToByte2((Image)x);
                    ClientForm.currentUser.ava = System.Text.Encoding.UTF8.GetString(imageBytes);
                    string base64String = Convert.ToBase64String(imageBytes);
                    ClientForm.currentUser.ava = base64String;

                    textbox1.Text = ClientForm.currentUser.alias;
                    textbox2.Text = ClientForm.currentUser.email;

                    int id = Program.RandomNumber(0, 2 ^ 32);
                    Client.ModelObject commandToBeSent = new Client.ModelObject();
                    commandToBeSent.command.code = "12";
                    commandToBeSent.command.id = $"{id}";

                    commandToBeSent.user.alias = ClientForm.currentUser.alias;
                    commandToBeSent.user.email = ClientForm.currentUser.email;
                    commandToBeSent.user.name = ClientForm.currentUser.name;
                    commandToBeSent.user.ava = base64String;

                    register.socket.Send(commandToBeSent);
                    RecvData(12, commandToBeSent.command.id);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                op.Dispose();
            }
            
        }

        public static byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        private void textboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(currentBtn == btnEditProfile)
            {
                if (textbox1.Text.Length >= 6)
                    btnSubmit.Enabled = true;
                else
                    btnSubmit.Enabled = false;
            }
            else 
            {
                if (textbox2.Text == textbox3.Text && textbox3.Text.Length >= 6)
                    btnSubmit.Enabled = true;
                else
                    btnSubmit.Enabled = false;
            }
        }

        private void textbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                textbox2.Focus();
            }
        }

        private void textbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (textbox3.Visible == true)
                    textbox3.Focus();
            }
            if(e.KeyCode == Keys.Enter)
            {
                if(textbox3.Visible == false)
                    btnSubmit_Click(sender, e);
            }
        }

        private void textbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (currentBtn == btnEditProfile)
            {
                if (textbox1.Text.Length >= 6)
                    btnSubmit.Enabled = true;
                else
                    btnSubmit.Enabled = false;
            }
            else
            {
                if (textbox2.Text == textbox3.Text && textbox3.Text.Length >= 6)
                    btnSubmit.Enabled = true;
                else
                    btnSubmit.Enabled = false;
            }
        }

        private void textbox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(currentBtn == btnChangePass)
            {
                if (textbox2.Text == textbox3.Text && textbox3.Text.Length >= 6)
                    btnSubmit.Enabled = true;
                else
                    btnSubmit.Enabled = false;
            }
        }

        private void textbox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, e);
            }
        }
    }
}
