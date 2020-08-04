using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Chat
{
    public partial class ClientForm : Form
    {

        private Form currentForm = null;
        private Button currentBtn = null;
        private Font fontRegular = new Font(new FontFamily("Segoe UI"), 13.0f, FontStyle.Regular);
        private int currentIndexSlide = 0;
        public static Client.ModelObject.User currentUser;

        public ClientForm()
        {
            InitializeComponent();

        }

        public List<Client.ModelObject.Room> listRoom = new List<Client.ModelObject.Room>();

        private void btnChat_Click(object sender, EventArgs e)
        {
            if(currentBtn != btnChat)
            {
                if (currentForm != null)
                {
                    currentForm.SendToBack();
                    currentBtn.BackColor = System.Drawing.Color.Transparent;
                }

                currentBtn = (IconButton)sender;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(227, 67, 61);

                ChatForm chat = new ChatForm();
                currentForm = chat;
                chat.AddRoom(listRoom);
                chat.JoinRoom();
                chat.TopLevel = false;
                mainPanel.Controls.Add(chat);
                chat.FormBorderStyle = FormBorderStyle.None;
                chat.Dock = DockStyle.Fill;
                chat.BringToFront();
                landing.Visible = false;
                landing.Enabled = false;
                timer1.Enabled = false;
                chat.Show();
            }
            
        }

        public void CloseForm()
        {
            this.Dispose();
            this.Close();
            register.ShowForm();
        }
        public void setImageClientForm(Image x)
        {
            btnSubMenu.Image = x;
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            int id = Program.RandomNumber(0, 2 ^ 32);

            Client.ModelObject Send = new Client.ModelObject();
            Send.command.code = "9";
            Send.command.id = $"{id}";

            register.socket.Send(Send);
            CloseForm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if(currentBtn != btnProfile)
            {
                if (currentForm != null)
                {
                    currentForm.SendToBack();
                    currentBtn.BackColor = System.Drawing.Color.Transparent;
                }
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(227, 67, 61);

                Profile profile = new Profile();
                currentForm = profile;
                profile.TopLevel = false;
                mainPanel.Controls.Add(profile);
                profile.FormBorderStyle = FormBorderStyle.None;
                profile.Dock = DockStyle.Fill;
                profile.BringToFront();

                landing.Visible = false;
                landing.Enabled = false;
                timer1.Enabled = false;
                profile.Show();
            }
        }
        

        private void landing_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                landing.Visible = true;
                landing.Enabled = true;
                currentForm.Close();
                currentForm = null;

                currentBtn.Text = null;
                currentBtn.BackColor = System.Drawing.Color.Transparent;
                currentBtn = null;

                timer1.Enabled = true;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            btnChat.PerformClick();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            currentIndexSlide = 0;
            panel4.BackgroundImage = global::Application_Chat.Properties.Resources.slide_1;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            currentIndexSlide = 1;
            panel4.BackgroundImage = global::Application_Chat.Properties.Resources.slide_2;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            currentIndexSlide = 2;
            panel4.BackgroundImage = global::Application_Chat.Properties.Resources.slide_3;
        }

        private void performSlide(int i)
        {
            if (i == 0)
                radioButton1.PerformClick();
            else if (i == 1)
                radioButton2.PerformClick();
            else
                radioButton3.PerformClick();
                
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            currentIndexSlide = (currentIndexSlide + 1) % 3;
            performSlide(currentIndexSlide);
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            btnChat.PerformClick();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentIndexSlide = (currentIndexSlide - 1) % 3;
            performSlide(currentIndexSlide);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRight.PerformClick();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            register.socket.closeProgram();
        }
        

        private void forAllButtons_MouseEnter(object sender, EventArgs e)
        {
            IconButton b = (IconButton)sender;
            if(b != currentBtn)
                b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(222, 147, 144);
        }

        private void forAllButtons_MouseLeave(object sender, EventArgs e)
        {
            IconButton b = (IconButton)sender;
            if (b != currentBtn)
                b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        }
             
    }
}
