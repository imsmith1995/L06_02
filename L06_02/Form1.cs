using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blackToolStripButton_Click(object sender, EventArgs e)
        {
            lblOut.ForeColor = Color.Black;
        }

        private void blueToolStripButton_Click(object sender, EventArgs e)
        {
            lblOut.ForeColor = Color.Blue;
        }

        private void redToolStripButton_Click(object sender, EventArgs e)
        {
            lblOut.ForeColor = Color.Crimson;
        }
    }
}
