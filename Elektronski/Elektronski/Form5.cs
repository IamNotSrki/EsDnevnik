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

namespace Elektronski
{
    public partial class Form5 : Form
    {
        int broj;
        SqlConnection veza;
        DataTable dtOcena, dtOcenaJoin;
 
        public Form5()
        {
            InitializeComponent();
        }

        private void ucenikPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime AS naziv FROM osoba WHERE uloga = 1", veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            cbImePrezime.DataSource = dtUcenik;
            cbImePrezime.ValueMember = "id";
            cbImePrezime.DisplayMember = "naziv";
        }

        private void raspodelaPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            DataTable dtRaspodela = new DataTable();
            adapter.Fill(dtRaspodela);
        }

        private void gridPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ocena ORDER BY id", veza);
            dtOcena = new DataTable();
            adapter.Fill(dtOcena);

            string tmp = "SELECT ocena.id, ime+' '+prezime AS ucenik, datum, raspodela.id AS 'Broj raspodele', ocena FROM osoba JOIN ocena on osoba.id = ucenik_id JOIN raspodela ON raspodela.id = raspodela_id ORDER BY ocena.id";
            adapter = new SqlDataAdapter(tmp, veza);
            dtOcenaJoin = new DataTable();
            adapter.Fill(dtOcenaJoin);

            dataGridView1.DataSource = dtOcenaJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                cbImePrezime.SelectedValue = dtOcena.Rows[broj]["ucenik_id"].ToString();
                tbDatum.Text = dtOcena.Rows[broj]["datum"].ToString();
                tbRaspodela.Text = dtOcena.Rows[broj]["raspodela_id"].ToString();
                tbOcena.Text = dtOcena.Rows[broj]["ocena"].ToString();
            }
        }


        private void btBrisi_Click(object sender, EventArgs e)
        {

            try
            {
                string naredba = "DELETE FROM ocena WHERE id = " + dtOcena.Rows[broj]["id"].ToString();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);

            }


        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "INSERT INTO ocena (datum, raspodela_id, ocena, ucenik_id) VALUES ('";
                naredba = naredba + tbDatum.Text.ToString() + "',";
                naredba = naredba + tbRaspodela.Text.ToString() + "',";
                naredba = naredba + tbOcena.Text + ",'";
                naredba = naredba + cbImePrezime.SelectedValue.ToString() + "')";

                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);

            }
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                string naredba = "UPDATE ocena SET ucenik_id='" + cbImePrezime.SelectedValue.ToString();
                naredba = naredba + "', datum='" + tbDatum.Text.ToString();
                naredba = naredba + "', raspodela_id='" + tbRaspodela.Text.ToString();
                naredba = naredba + "', ocena='" + tbOcena.Text + "'WHERE id='";
                naredba = naredba + dtOcena.Rows[broj]["id"].ToString() + "'";
                SqlCommand komanda = new SqlCommand(naredba, veza);
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                gridPopulate();
            }
            catch (Exception Greska)
            {
                veza.Close();
                MessageBox.Show(Greska.Message);

            }
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            string CS = "Data Source = INF008\\SQLEXPRESS; Initial Catalog = esdnevnik; Integrated Security = True";
            veza = new SqlConnection(CS);
            ucenikPopulate();
            raspodelaPopulate();
            gridPopulate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
