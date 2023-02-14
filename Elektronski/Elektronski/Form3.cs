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
    public partial class Form3 : Form
    {
        static string CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
        static int mesto;
        SqlConnection conn = null;
        SqlCommand komanda = new SqlCommand();
        DataTable odeljenja = new DataTable();
        SqlDataReader citac;
        SqlCommand komandaCount = new SqlCommand();

        DataTable smerovi = new DataTable();
        DataTable nastavnici1 = new DataTable();
        DataTable godine = new DataTable();
        SqlCommand a = new SqlCommand();
        SqlDataReader citac1;

        public Form3()
        {
            InitializeComponent();           
        }

        private DataTable popuniSmerove()
        {
        //    conn = new SqlConnection(CS);
            conn.Open();        
            a.CommandText = "Select * from smer";
            a.Connection = conn;
            citac1 = a.ExecuteReader();
            smerovi.Load(citac1);
            conn.Close();
            return smerovi;
        }
        private DataTable popuniStaresine()
        {
         //   conn = new SqlConnection(CS);
            conn.Open();
            a.CommandText = "Select * from osoba where uloga = 2";
            a.Connection = conn;
            citac1 = a.ExecuteReader();
            nastavnici1.Load(citac1);
            conn.Close();
            return nastavnici1;
        }
        private DataTable popuniGodine()
        {
       //     conn = new SqlConnection(CS);
            conn.Open();
            a.CommandText = "Select * from skolska_godina";
            a.Connection = conn;
            citac1 = a.ExecuteReader();
            godine.Load(citac1);
            conn.Close();
            return godine;
        }

        private DataTable poveziSe()
        {
            conn = new SqlConnection(CS);
            StringBuilder spajanje = new StringBuilder("SELECT * FROM odeljenje ");
            spajanje.Append("JOIN skolska_godina ON skolska_godina.id = odeljenje.godina_id ");
            spajanje.Append("JOIN smer ON smer.id = odeljenje.smer_id ");
            spajanje.Append("JOIN osoba ON osoba.id = odeljenje.razredni_id WHERE osoba.uloga = 2");
            conn.Open();
            komanda.CommandText = spajanje.ToString();
            komanda.Connection = conn;
            citac = komanda.ExecuteReader();
            odeljenja.Load(citac);
            conn.Close();
            return odeljenja;
        }

        private int brojRedova()
        {
            StringBuilder spajanje = new StringBuilder("SELECT COUNT(*) FROM odeljenje ");
            spajanje.Append("JOIN skolska_godina ON skolska_godina.id = odeljenje.godina_id ");
            spajanje.Append("JOIN smer ON smer.id = odeljenje.smer_id ");
            spajanje.Append("JOIN osoba ON osoba.id = odeljenje.razredni_id WHERE osoba.uloga = 2");
            conn.Open();
            komandaCount.CommandText = spajanje.ToString();
            komandaCount.Connection = conn;
            int broj = (int)(komandaCount.ExecuteScalar());
            conn.Close();
            return broj;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            odeljenja = poveziSe();
            smerovi = popuniSmerove();
            nastavnici1 = popuniStaresine();
            godine = popuniGodine();
            conn.Open();
            a.CommandText = "Select COUNT(*) FROM smer";
            a.Connection = conn;
            
            for (int i = 0; i < (int)(a.ExecuteScalar()); i++)
                comboBox1.Items.Add(smerovi.Rows[i][1].ToString());
            a.CommandText = "Select COUNT(*) FROM osoba where uloga = 2";
            a.Connection = conn;
            for (int i = 0; i < (int)(a.ExecuteScalar()); i++)
                comboBox2.Items.Add(nastavnici1.Rows[i][1].ToString() + ' ' + nastavnici1.Rows[i][2].ToString());
            a.CommandText = "Select COUNT(*) FROM skolska_godina";
            a.Connection = conn;
            for (int i = 0; i < (int)(a.ExecuteScalar()); i++)
                comboBox3.Items.Add(godine.Rows[i][1].ToString());
            conn.Close();
            mesto = 0;
            textBox1.Text = odeljenja.Rows[0][0].ToString();
            textBox2.Text = odeljenja.Rows[0][1].ToString();
            textBox3.Text = odeljenja.Rows[0][2].ToString();
            comboBox1.Text = odeljenja.Rows[0][9].ToString();
            comboBox2.Text = odeljenja.Rows[0][11].ToString() + ' ' + odeljenja.Rows[0][12].ToString();
            comboBox3.Text = odeljenja.Rows[0][7].ToString();
            buttonPrvi.Visible = false;
            buttonPrethodni.Visible = false;
            buttonSledeci.Visible = true;
            buttonPoslednji.Visible = true;
        }

        private void buttonPrvi_Click(object sender, EventArgs e)
        {
            odeljenja = poveziSe();
            conn.Open();
            mesto = 0;
            if (conn.State == ConnectionState.Open)
            {
                textBox1.Text = odeljenja.Rows[0][0].ToString();
                textBox2.Text = odeljenja.Rows[0][1].ToString();
                textBox3.Text = odeljenja.Rows[0][2].ToString();
                comboBox1.Text = odeljenja.Rows[0][9].ToString();
                comboBox2.Text = odeljenja.Rows[0][11].ToString() + ' ' + odeljenja.Rows[0][12].ToString();
                comboBox3.Text = odeljenja.Rows[0][7].ToString();
            }
            buttonPrvi.Visible = false;
            buttonPrethodni.Visible = false;
            buttonSledeci.Visible = true;
            buttonPoslednji.Visible = true;
            conn.Close();
        }

        private void buttonPrethodni_Click(object sender, EventArgs e)
        {
            odeljenja = poveziSe();
            mesto = int.Parse(textBox1.Text) - 2;
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                textBox1.Text = odeljenja.Rows[mesto][0].ToString();
                textBox2.Text = odeljenja.Rows[mesto][1].ToString();
                textBox3.Text = odeljenja.Rows[mesto][2].ToString();
                comboBox1.Text = odeljenja.Rows[mesto][9].ToString();
                comboBox2.Text = odeljenja.Rows[mesto][11].ToString() + ' ' + odeljenja.Rows[mesto][12].ToString();
                comboBox3.Text = odeljenja.Rows[mesto][7].ToString();
            }
            if (mesto == 0)
            {
                buttonPrvi.Visible = false;
                buttonPrethodni.Visible = false;
            }
            else
            {
                buttonPrvi.Visible = true;
                buttonPrethodni.Visible = true;
            }
            buttonSledeci.Visible = true;
            buttonPoslednji.Visible = true;
            conn.Close();
        }

        private void buttonSledeci_Click(object sender, EventArgs e)
        {
            odeljenja = poveziSe();
            mesto = int.Parse(textBox1.Text);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                textBox1.Text = odeljenja.Rows[mesto][0].ToString();
                textBox2.Text = odeljenja.Rows[mesto][1].ToString();
                textBox3.Text = odeljenja.Rows[mesto][2].ToString();
                comboBox1.Text = odeljenja.Rows[mesto][9].ToString();
                comboBox2.Text = odeljenja.Rows[mesto][11].ToString() + ' ' + odeljenja.Rows[mesto][12].ToString();
                comboBox3.Text = odeljenja.Rows[mesto][7].ToString();
            }
            buttonPrvi.Visible = true;
            buttonPrethodni.Visible = true;
            conn.Close();
            if (mesto == brojRedova() - 1)
            {
                buttonSledeci.Visible = false;
                buttonPoslednji.Visible = false;
            }
            else
            {
                buttonSledeci.Visible = true;
                buttonPoslednji.Visible = true;
            }
        }

        private void buttonPoslednji_Click(object sender, EventArgs e)
        {
            odeljenja = poveziSe();
            mesto = brojRedova() - 1;
            textBox1.Text = odeljenja.Rows[mesto][0].ToString();
            textBox2.Text = odeljenja.Rows[mesto][1].ToString();
            textBox3.Text = odeljenja.Rows[mesto][2].ToString();
            comboBox1.Text = odeljenja.Rows[mesto][9].ToString();
            comboBox2.Text = odeljenja.Rows[mesto][11].ToString() + ' ' + odeljenja.Rows[mesto][12].ToString();
            comboBox3.Text = odeljenja.Rows[mesto][7].ToString();
            buttonSledeci.Visible = false;
            buttonPoslednji.Visible = false;
            buttonPrvi.Visible = true;
            buttonPrethodni.Visible = true;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            int smerID, razredniID, godinaID;
            conn.Open();
            SqlCommand b = new SqlCommand();

            StringBuilder tekstB = new StringBuilder("SELECT id FROM smer WHERE naziv = '" + comboBox1.SelectedItem.ToString() + "'");
            b.CommandText = tekstB.ToString();
            b.Connection = conn;
            smerID = (int)(b.ExecuteScalar());
            StringBuilder tekstC = new StringBuilder("SELECT id FROM osoba WHERE ime = LEFT('" + comboBox2.SelectedItem.ToString());
            tekstC.Append("', CHARINDEX(' ', '" + comboBox2.SelectedItem.ToString() + "'))");
            b.CommandText = tekstC.ToString();
            b.Connection = conn;
            razredniID = (int)(b.ExecuteScalar());
            StringBuilder tekstD = new StringBuilder("SELECT id FROM skolska_godina WHERE naziv = '" + comboBox3.SelectedItem.ToString() + "'");
            b.CommandText = tekstD.ToString();
            b.Connection = conn;
            godinaID = (int)(b.ExecuteScalar());

            StringBuilder te = new StringBuilder("INSERT INTO odeljenje VALUES(");
            te.Append(int.Parse(textBox1.Text) + ",");
            te.Append(int.Parse(textBox2.Text) + ",");
            te.Append("'" + textBox3.Text + "',");
            te.Append(smerID + ",");
            te.Append(razredniID + ",");
            te.Append(godinaID + ")");
            SqlCommand dodaj = new SqlCommand(te.ToString(), conn);
            dodaj.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            int smerID, razredniID, godinaID;
            conn.Open();
            SqlCommand b = new SqlCommand();

            StringBuilder tekstB = new StringBuilder("SELECT id FROM smer WHERE naziv = '" + comboBox1.SelectedItem.ToString() + "'");
            b.CommandText = tekstB.ToString();
            b.Connection = conn;
            smerID = (int)(b.ExecuteScalar());
            StringBuilder tekstC = new StringBuilder("SELECT id FROM osoba WHERE ime = LEFT('" + comboBox2.SelectedItem.ToString());
            tekstC.Append("', CHARINDEX(' ', '" + comboBox2.SelectedItem.ToString() + "'))");
            b.CommandText = tekstC.ToString();
            b.Connection = conn;
            razredniID = (int)(b.ExecuteScalar());
            StringBuilder tekstD = new StringBuilder("SELECT id FROM skolska_godina WHERE naziv = '" + comboBox3.SelectedItem.ToString() + "'");
            b.CommandText = tekstD.ToString();
            b.Connection = conn;
            godinaID = (int)(b.ExecuteScalar());

            StringBuilder te = new StringBuilder("UPDATE odeljenje ");
            te.Append("SET razred = " + int.Parse(textBox2.Text));
            te.Append(", indeks = '" + textBox3.Text + "'");
            te.Append(", smer_id = " + smerID);
            te.Append(", razredni_id = " + razredniID);
            te.Append(", godina_id = " + godinaID);
            te.Append(" WHERE id = " + int.Parse(textBox1.Text));
            SqlCommand izmeni = new SqlCommand(te.ToString(), conn);
            izmeni.ExecuteNonQuery();
            conn.Close();
        }

        private void buttonBrisi_Click(object sender, EventArgs e)
        {
            StringBuilder te = new StringBuilder("DELETE FROM odeljenje WHERE id = " + int.Parse(textBox1.Text));
            SqlCommand brisi = new SqlCommand(te.ToString(), conn);
            conn.Open();
            brisi.ExecuteNonQuery();
            conn.Close();
        }
    }
}
