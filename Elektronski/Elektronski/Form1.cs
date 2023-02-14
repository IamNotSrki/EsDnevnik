using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektronski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 osoba = new Form2();
            osoba.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 odeljenja = new Form3();
            odeljenja.Show();
        }
    }
}
