using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DaveBot
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void help_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.IO.File.ReadAllText("ReadMe.txt");
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 0;
            textBox1.ScrollToCaret();
        }
    }
}
