using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Chat
{
    public partial class Room : UserControl
    {

        public Room()
        {
            InitializeComponent();
        }
        string roomID = "";

        public delegate void ProfileImageClick(object sender, EventArgs e);
        public delegate void RoomTitleClick(object sender, EventArgs e);
        public delegate void MessageClick(object sender, EventArgs e);
        public delegate void panel1_Click(object sender, EventArgs e);
        public delegate void panel2_Click(object sender, EventArgs e);
        public delegate void iconPicture_Click(object sender, EventArgs e);
        public delegate void Clicked(object sender, EventArgs e);

        public event ProfileImageClick OnProfileImageClick;
        public event RoomTitleClick OnRoomTitleClick;
        public event MessageClick OnMessageClick;   
        public event panel1_Click Onpanel1_Click;
        public event panel2_Click Onpanel2_Click;
        public event iconPicture_Click OniconPicture_Click;
        public event Clicked OnClick;

        public string nameRoom
        {
            get { return labelNameRoom.Text; }
            set { labelNameRoom.Text = value; }
        }
        public string lastestMessage
        {
            get { return labelLastMessage.Text; }
            set { labelLastMessage.Text = value; }
        }

        public string IDROOM
        {
            get { return this.roomID; }
            set { this.roomID = value; }
        }

        public Color ColorAvatar
        {
            get
            {
                return avatarBox.FillColor;
            }
            set
            {
                avatarBox.FillColor = value;
            }
        }


        private void Users_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PeachPuff;
            panel2.BackColor = Color.PeachPuff;
        }

        private void Users_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
        }

        private void avatarBoxClick(object sender, EventArgs e)
        {
            if (OnProfileImageClick != null)
            {
                OnProfileImageClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void labelNameRoomClick(object sender, EventArgs e)
        {
            if (OnRoomTitleClick != null)
            {
                OnRoomTitleClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }

        private void panel1Click(object sender, EventArgs e)
        {
            if (Onpanel1_Click != null)
            {
                Onpanel1_Click.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }
        
        
        private void panel2Click(object sender, EventArgs e)
        {
            if (Onpanel2_Click != null)
            {
                Onpanel2_Click.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }
        
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (OniconPicture_Click != null)
            {
                OniconPicture_Click.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }
        
        private void labelLastMessage_Click(object sender, EventArgs e)
        {
            if (OnMessageClick != null)
            {
                OnMessageClick.Invoke(sender, e);
            }
            else
            {
                OnClick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
