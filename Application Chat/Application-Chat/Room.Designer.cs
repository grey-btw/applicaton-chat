namespace Application_Chat
{
    partial class Room
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLastMessage = new System.Windows.Forms.Label();
            this.labelNameRoom = new System.Windows.Forms.Label();
            this.avatarBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 78);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2Click);
            this.panel2.MouseEnter += new System.EventHandler(this.Users_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.Users_MouseLeave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(7, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.iconPictureBox1.MouseEnter += new System.EventHandler(this.Users_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLastMessage);
            this.panel1.Controls.Add(this.labelNameRoom);
            this.panel1.Controls.Add(this.avatarBox);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 78);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1Click);
            this.panel1.MouseEnter += new System.EventHandler(this.Users_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.Users_MouseLeave);
            // 
            // labelLastMessage
            // 
            this.labelLastMessage.AllowDrop = true;
            this.labelLastMessage.AutoSize = true;
            this.labelLastMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLastMessage.Font = new System.Drawing.Font("Quicksand", 8F);
            this.labelLastMessage.Location = new System.Drawing.Point(62, 47);
            this.labelLastMessage.Name = "labelLastMessage";
            this.labelLastMessage.Size = new System.Drawing.Size(126, 21);
            this.labelLastMessage.TabIndex = 2;
            this.labelLastMessage.Text = "labelLastMessage";
            this.labelLastMessage.Click += new System.EventHandler(this.labelLastMessage_Click);
            this.labelLastMessage.MouseEnter += new System.EventHandler(this.Users_MouseEnter);
            // 
            // labelNameRoom
            // 
            this.labelNameRoom.AutoSize = true;
            this.labelNameRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNameRoom.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold);
            this.labelNameRoom.Location = new System.Drawing.Point(61, 18);
            this.labelNameRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameRoom.Name = "labelNameRoom";
            this.labelNameRoom.Size = new System.Drawing.Size(151, 25);
            this.labelNameRoom.TabIndex = 1;
            this.labelNameRoom.Text = "labelNameRoom";
            this.labelNameRoom.Click += new System.EventHandler(this.labelNameRoomClick);
            this.labelNameRoom.MouseEnter += new System.EventHandler(this.Users_MouseEnter);
            // 
            // avatarBox
            // 
            this.avatarBox.BackColor = System.Drawing.Color.Transparent;
            this.avatarBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatarBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.avatarBox.InitialImage = null;
            this.avatarBox.Location = new System.Drawing.Point(5, 18);
            this.avatarBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatarBox.ShadowDecoration.Parent = this.avatarBox;
            this.avatarBox.Size = new System.Drawing.Size(50, 50);
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            this.avatarBox.Click += new System.EventHandler(this.avatarBoxClick);
            this.avatarBox.MouseEnter += new System.EventHandler(this.Users_MouseEnter);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Quicksand", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(287, 78);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatarBox;
        private System.Windows.Forms.Label labelNameRoom;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelLastMessage;
    }
}
