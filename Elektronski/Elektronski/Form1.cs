﻿using System;
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
     
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 skolske_godine = new Form4("Skolska_godina");
            skolske_godine.Text = "Skolske godine";
            skolske_godine.Show();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 predmeti = new Form4("Predmet");
            predmeti.Text = "Predmeti";
            predmeti.Show();
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 smerovi = new Form4("Smer");
            smerovi.Text = "Smerovi";
            smerovi.Show();
        }

        private void oceneBtn_Click(object sender, EventArgs e)
        {
            Form5 ocene = new Form5();
            ocene.Show();
        }

        private void odeljenjaBtn_Click(object sender, EventArgs e)
        {
            Form3 odeljenja = new Form3();
            odeljenja.Show();
        }

        private void upisniceBtn_Click(object sender, EventArgs e)
        {
            Form6 upisnice = new Form6();
            upisnice.Show();
        }

        private void raspodeleBtn_Click(object sender, EventArgs e)
        {
            Form7 raspodele = new Form7();
            raspodele.Show();
        }
    }
}
