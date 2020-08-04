using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Application_Chat
{
    public partial class registerCustom : UserControl
    {
        public registerCustom()
        {
            InitializeComponent();
        }

        Regex rg = new Regex(@"^(?!.*\.\.)(?!.*\.$)[^\W][\w.]{0,15}$");

        Color red = Color.Red;
        Color black = Color.Black;
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            bool flag = true;

            if (iUsername.Text.Length < 6 || !rg.IsMatch(iUsername.Text))
            {
                flag = false;
                if (String.IsNullOrEmpty(iUsername.Text) || String.IsNullOrWhiteSpace(iUsername.Text))
                    hint1.Text = "Username can't be null or space";
                else if (!rg.IsMatch(iUsername.Text))
                    hint1.Text = "Username just has text and digits";
                else
                    hint1.Text = "The length of username is from 6 until 15";
                line1.BackColor = red;
                username.ForeColor = red;
            }

            if (iPassword1.Text != iPassword2.Text || iPassword1.Text.Length < 6)
            {
                flag = false;
                if(iPassword1.Text != iPassword2.Text)
                {
                    hint2.Text = "The two passwords must be the same";
                    hint3.Text = hint2.Text;
                }
                else
                {
                    hint2.Text = "The length of password must longer than 6";
                    hint3.Text = hint2.Text;
                }

                label3.ForeColor = red;
                label4.ForeColor = red;
                line2.BackColor = red;
                line3.BackColor = red;
            }

            if (bunifuCheckbox1.Checked == false)
            {
                term.ForeColor = red;
                flag = false;
            }

            if (String.IsNullOrWhiteSpace(iEmail.Text))
            {
                iEmail.Text = "";
            }
            
            if (flag)
            {
                MessageBox.Show("Register...");

                register.socket = new Client();
                int ranNumber = Program.RandomNumber(2, 2 ^ 32);

                Client.ModelObject Send = new Client.ModelObject();

                Send.command.code = "2";
                Send.command.id = $"{ranNumber}";
                Send.user.name = iUsername.Text;
                Send.user.pass = register.SHA256HexHashString(iPassword1.Text);
                Send.user.email = iEmail.Text;
                register.socket.Send(Send);
                register.RecvData(2, Send.command.id);
            }

            if (!flag)
                MessageBox.Show("Failed to register");
            resetState(1);
        }

        public void resetState(int type)
        {
            if(type == 1)
            {
                iUsername.Text = "";
                iPassword1.Text = "";
                iPassword2.Text = "";
                iEmail.Text = "";
                bunifuCheckbox1.Checked = false;
            }
            else
            {
                username.ForeColor = black;
                label3.ForeColor = black;
                label4.ForeColor = black;
                term.ForeColor = black;
                line1.BackColor = black;
                line2.BackColor = black;
                line3.BackColor = black;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            register.backToLogin();
        }

        private void iPassword1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                iPassword2.Focus();
            }
        }

        private void iUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                iPassword1.Focus();
            }
        }

        private void iPassword2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Tab)
            {
                iEmail.Focus();
            }
        }

        private void iUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(iUsername.Text.Length >= 8)
                if(line1.BackColor ==  red)
                {
                    username.ForeColor = black;
                    line1.BackColor = black;
                }
        }

        private void iPassword1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(iPassword1.Text == iPassword2.Text && iPassword1.Text.Length > 0)
                if(line2.BackColor == red)
                {
                    label3.ForeColor = black;
                    label4.ForeColor = black;
                    line2.BackColor = black;
                    line3.BackColor = black;
                }
        }

        private void iUsername_MouseEnter(object sender, EventArgs e)
        {
            if(line1.BackColor == red)
            {
                hint1.Visible = true;
            }
        }

        private void iUsername_MouseLeave(object sender, EventArgs e)
        {
            if (hint1.Visible == true)
                hint1.Visible = false;
        }

        private void iPassword1_MouseEnter(object sender, EventArgs e)
        {
            if (line2.BackColor == red)
                hint2.Visible = true;
        }

        private void iPassword1_MouseLeave(object sender, EventArgs e)
        {
            if (hint2.Visible == true)
                hint2.Visible = false;
        }

        private void iPassword2_MouseEnter(object sender, EventArgs e)
        {
            if (line3.BackColor == red)
                hint3.Visible = true;
        }

        private void iPassword2_MouseLeave(object sender, EventArgs e)
        {
            if (hint3.Visible == true)
                hint3.Visible = false;
        }

        private void bunifuCheckbox1_Click(object sender, EventArgs e)
        {
            if (term.ForeColor == red)
                term.ForeColor = black;
        }
    }
}
