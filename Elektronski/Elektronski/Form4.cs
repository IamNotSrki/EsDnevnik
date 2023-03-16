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
            adapter = new SqlDataAdapter("SELECT * FROM " + imeTabele, Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            podaci = podaci.GetChanges(DataRowState.Modified);
            dataGridView1.DataSource = podaci;
            DataTable menjano = podaci.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
