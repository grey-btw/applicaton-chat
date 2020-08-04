using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;
using System.Dynamic;

namespace Application_Chat
{
    public partial class register : Form
    {
        Color red = Color.Red;
        Color black = Color.Black;

        static Form thisForm;
        public register()
        {
            InitializeComponent();
            thisForm = this;
        }

        
        registerCustom currentRg = null;
        private bool hidePassword = true;
        private bool flag = true;
        private static string tmpPD = null;
        public static Client socket;

        private const int
               RecvLogin = 1,   
               RecvRegister = 2,   
               RecvCreate = 3, 
               RecvJoin = 4;   

        public static void RecvData(int flag, string commandId)
        {
            Client.ModelObject data = new Client.ModelObject();
            BigInteger p = 0;
            while (p < 5000000000)
            {
                data = socket.GetCommandResult(commandId);
                
                if ((data != null))
                {
                    switch (flag)
                    {
                        case RecvLogin:
                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Failed to login!");
                                break;
                            }
                            MessageBox.Show("Successful!");
                            ClientForm clientForm = new ClientForm();
                            ClientForm.currentUser = data.user;
                            ClientForm.currentUser.pass = tmpPD;
                            if(!String.IsNullOrEmpty(ClientForm.currentUser.ava))
                                clientForm.setImageClientForm(Profile.Base64ToImage(ClientForm.currentUser.ava));
                            tmpPD = null;
                            if(data.message.existroom != null)
                                clientForm.listRoom.AddRange(data.message.existroom); 
                            Console.WriteLine(data);
                            thisForm.Hide();
                            clientForm.BringToFront();
                            clientForm.Show();
                            break;

                        case RecvRegister:
                            if (data.command.status != "0")
                            {
                                MessageBox.Show("Failed to register!");
                                break;
                            }
                            MessageBox.Show("You've been registered successfully!");
                            break;
                            
                    }
                    return;
                }
                p += 50;

            }
            MessageBox.Show("Timeout!");
        }

        private void btnHideShow_Click(object sender, EventArgs e)
        {
            if (hidePassword)
            {
                btnHideShow.BackgroundImage = global::Application_Chat.Properties.Resources.eye;
                hidePassword = false;
                iPassword1.UseSystemPasswordChar = false;
            }
            else
            {

                btnHideShow.BackgroundImage = global::Application_Chat.Properties.Resources.closed_eye;
                hidePassword = true;
                iPassword1.UseSystemPasswordChar = true;
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            if (currentRg == null)
            {
                registerCustom rg = new registerCustom();
                currentRg = rg;
                panelRight.Controls.Add(rg);
                rg.Dock = DockStyle.Fill;
                rg.BringToFront();
                blockTopRight.BringToFront();
                thisForm.Text = "Register";
                rg.Show();
            }
            else
            {
                currentRg.Enabled = true;
                currentRg.Show();
                currentRg.resetState(0);
                thisForm.Text = "Register";
            }
        }


        private void resetState()
        {
            flag = true;
        }

        private void iUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                iPassword1.Focus();
            }
        }

        private void iPassword1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            resetState();
            if(String.IsNullOrEmpty(iUsername.Text))
            {
                panel8.BackColor = red;
                username.ForeColor = red;
                flag = false;
            }
            if (String.IsNullOrEmpty(iPassword1.Text))
            {
                panel4.BackColor = red;
                label3.ForeColor = red;
                flag = false;
            }

            if(flag)
            {
                socket = new Client();
                int id = Program.RandomNumber(0, 2 ^ 32);
                
                Client.ModelObject commandToBeSent = new Client.ModelObject();
                commandToBeSent.command.code = "1";
                commandToBeSent.command.id = $"{id}";
                commandToBeSent.user.name = iUsername.Text;
                commandToBeSent.user.pass = SHA256HexHashString(iPassword1.Text);
                tmpPD = commandToBeSent.user.pass;

                Console.WriteLine(commandToBeSent.user.pass);
                socket.Send(commandToBeSent);
                RecvData(1, commandToBeSent.command.id);
            }
        }

        public static void ShowForm()
        {
            thisForm.Text = "Login";
            thisForm.Show();
        }
        public static void backToLogin()
        {
            thisForm.Text = "Login";
        }
        private string takePassword()
        {
            return iPassword1.Text;
        }

        private static string ToHex(byte[] bytes, bool upperCase)
        {
            StringBuilder result = new StringBuilder(bytes.Length * 2);
            for (int i = 0; i < bytes.Length; i++)
                result.Append(bytes[i].ToString(upperCase ? "X2" : "x2"));
            return result.ToString();
        }

        public static string SHA256HexHashString(string StringIn)
        {
            string hashString;
            using (var sha256 = SHA256Managed.Create())
            {
                var hash = sha256.ComputeHash(Encoding.Default.GetBytes(StringIn));
                hashString = ToHex(hash, false);
            }

            return hashString;
        }
    }
}
