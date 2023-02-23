using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Elektronski
{
    public partial class Form4 : Form
    {
        DataTable podaci;
        SqlDataAdapter adapter;
        string imeTabele;

        public Form4(string putanja)
        {
            imeTabele = putanja;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", Konekcija.Connect());
            adapter = new SqlDataAdapter("SELECT * FROM " + imeTabele, Konekcija.Connect()); // imeTabele
            // kada hocemo da iskoristimo isti gridView za rukovanje sa vise tabela, inace konstantna SELECT naredba
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
            dataGridView1.Columns["id"].ReadOnly = true; // zabranjuje promenu kolone primarnog kljuca id
            // dataGridView1.Columns["id"].Visible = false; // kolonu id cini nevidljivom, ali ovo se moglo
            // resiti i u SELECT naredbi(samo se iskljuci id)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podaci = podaci.GetChanges(DataRowState.Modified); //npr samo jedna od 3 vrste promena
            dataGridView1.DataSource = podaci;
            // ============= Ovo je nastavak posto se obrise dataGridView2 nakon pokazanog primera
            DataTable menjano = podaci.GetChanges(); // ovde ce biti sve promene
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
