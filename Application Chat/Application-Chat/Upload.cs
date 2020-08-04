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

namespace Application_Chat
{
    public partial class Upload : Form
    {
        public bool flag = false;
        
        public Upload(Image x)
        {
            InitializeComponent();
            guna2PictureBox1.Image = x;
        }
        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
        }
    }
}
