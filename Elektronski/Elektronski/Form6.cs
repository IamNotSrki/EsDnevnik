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
    public partial class Form6 : Form
    {
        int broj;
        SqlConnection veza;
        DataTable dtRaspodele, dtRaspodeleJoin;

        public Form6()
        {
            InitializeComponent();
        }

        private void ucenikPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime AS 'Naziv ucenika' FROM osoba WHERE uloga = 1", veza);
            DataTable dtUcenik = new DataTable();
            adapter.Fill(dtUcenik);
            cbImePrezime.DataSource = dtUcenik;
            cbImePrezime.ValueMember = "id";
            cbImePrezime.DisplayMember = "naziv";
        }

        private void odeljenjePopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, razred + indeks AS Odeljenje FROM odeljenje", veza);
            DataTable dtOdeljenje = new DataTable();
            adapter.Fill(dtOdeljenje);
            cbOdeljenje.DataSource = dtOdeljenje;
            cbOdeljenje.ValueMember = "id";
            cbOdeljenje.DisplayMember = "naziv";
        }

        private void gridPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM upisnica ORDER BY id", veza);
            dtRaspodele = new DataTable();
            adapter.Fill(dtRaspodele);

            string tmp = "SELECT upisnica.id, osoba.ime + ' ' + osoba.prezime AS 'Nastavnik', odeljenje.razred + odeljenje.indeks AS 'Odeljenje' FROM upisnica JOIN osoba ON Upisnica.osoba_id = osoba.id JOIN Odeljenje ON Upisnica.odeljenje_id = odeljenje_id WHERE osoba.uloga = 1";
            adapter = new SqlDataAdapter(tmp, veza);
            dtRaspodeleJoin = new DataTable();
            adapter.Fill(dtRaspodeleJoin);

            dataGridView1.DataSource = dtRaspodeleJoin;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                broj = dataGridView1.CurrentRow.Index;
                cbImePrezime.SelectedValue = dtRaspodele.Rows[broj]["nastavnik_id"].ToString();
                cbOdeljenje.SelectedValue = dtRaspodele.Rows[broj]["odeljenje_id"].ToString();
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {

            try
            {
                string naredba = "DELETE FROM upisnica WHERE id = " + dtRaspodele.Rows[broj]["id"].ToString();
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
                string naredba = "INSERT INTO upisnica (osoba_id, odeljenje_id) VALUES ('";
                naredba = naredba + cbImePrezime.SelectedValue.ToString() + "',";
                naredba = naredba + cbOdeljenje.SelectedValue.ToString() + "')";

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
                string naredba = "UPDATE upisnica SET osoba_id='" + cbImePrezime.SelectedValue.ToString();
                naredba = naredba + "', odeljenje_id='" + cbOdeljenje.SelectedValue.ToString() + "'WHERE id='";
                naredba = naredba + dtRaspodele.Rows[broj]["id"].ToString() + "'";
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

        private void Form6_Load(object sender, EventArgs e)
        {
            string CS = "Data Source = INF008\\SQLEXPRESS; Initial Catalog = esdnevnik; Integrated Security = True";
            veza = new SqlConnection(CS);
            ucenikPopulate();
            odeljenjePopulate();
            gridPopulate();
        }
        
    }
}
