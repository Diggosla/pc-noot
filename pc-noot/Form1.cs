using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_noot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonpc_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1pc.Visible = true;
            this.pictureBoxmostrar2pc.Visible = true;
            this.pictureBoxmostrar3pc.Visible =true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2pc_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1pc.Visible = true;
            this.pictureBoxmostrar2pc.Visible = false;
            this.pictureBoxmostrar3pc.Visible = false;
        }

        private void button3pc_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1pc.Visible = false;
            this.pictureBoxmostrar2pc.Visible = true;
            this.pictureBoxmostrar3pc.Visible = false;
        }

        private void button4pc_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1pc.Visible = false;
            this.pictureBoxmostrar2pc.Visible = false;
            this.pictureBoxmostrar3pc.Visible = true;
        }

        private void buttonnot_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1not.Visible = true;
            this.pictureBoxmostrar2not.Visible = true;
            this.pictureBoxmostrar3not.Visible = true;
        }

        private void button2not_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1not.Visible = true;
            this.pictureBoxmostrar2not.Visible = false;
            this.pictureBoxmostrar3not.Visible = false;
        }

        private void button3not_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1not.Visible = false;
            this.pictureBoxmostrar2not.Visible = true;
            this.pictureBoxmostrar3not.Visible = false;
        }

        private void button4not_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBoxmostrar1not.Visible = false;
            this.pictureBoxmostrar2not.Visible = false;
            this.pictureBoxmostrar3not.Visible = true;
        }
    }
}
