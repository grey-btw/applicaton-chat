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
    public partial class MyBubble : UserControl
    {
        public MyBubble(int type)
        {
            InitializeComponent();

            if (type == 0)
            {
                label1.Enabled = false;
                label1.Visible = false;
                guna2PictureBox1.Enabled = true;
                guna2PictureBox1.Visible = true;
            }
        }

        public string Body
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public Image UserImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public Image ImageOfMessage
        {
            get
            {
                return guna2PictureBox1.Image;
            }
            set
            {
                guna2PictureBox1.Image = value;
            }
        }

        public Cursor ChatImageCursor
        {
            get
            {
                return pictureBox1.Cursor;
            }
            set
            {
                pictureBox1.Cursor = value;
            }
        }

        public Cursor ChatTextCursor
        {
            get
            {
                return label1.Cursor;
            }
            set
            {
                label1.Cursor = value;
            }
        }

        public Color MsgColor
        {
            get
            {
                return label1.BackColor;
            }
            set
            {
                label1.BackColor = value;
            }
        }

        public Color MsgTextColor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }

        public Color TimeColor
        {
            get
            {
                return time.ForeColor;
            }
            set
            {
                time.ForeColor = value;
            }
        }

        public string Time
        {
            get
            {
                return time.Text;

            }
            set
            {
                time.Text = value;
                SetTimeWidth();
            }
        }
        private void SetTimeWidth()
        {
            time.Width = TextRenderer.MeasureText(time.Text, time.Font).Width;
        }


        Panel messageBottom = new Panel();
        Label time = new Label();
        PictureBox msgStatus = new PictureBox();

        bool isAdded = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            label1.MaximumSize = new Size((this.Width - panel1.Width - 21) / 2, 0);
            label1.Width = this.Width - panel1.Width - 21;

            if (label1.Height < panel2.Height + 1)
            {
                this.MinimumSize = new Size(0, panel2.Height + 11 + 15);
                this.Height = panel2.Height + 11 + 15;
            }
            else
            {
                this.MinimumSize = new Size(0, label1.Height + 10 + 15);
                this.Height = label1.Height + 10 + 15;
            }

            if (!isAdded)
            {
                messageBottom.Size = new Size(0, 15);
                messageBottom.Dock = DockStyle.Bottom;
                messageBottom.Padding = new Padding(0, 0, 47, 0);
                messageBottom.BackColor = Color.Transparent;
                messageBottom.ForeColor = Color.White;
                time.Dock = DockStyle.Right;
                SetTimeWidth();

                messageBottom.Controls.Add(time);

                this.Controls.Add(messageBottom);
                isAdded = true;
            }

            base.OnPaint(e);
        }


    }
    
}

