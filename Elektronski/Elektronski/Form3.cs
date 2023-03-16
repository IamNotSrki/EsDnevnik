﻿using System;
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
    public partial class Form3 : Form
    {
        int broj;
        SqlConnection veza;
        DataTable dtRaspodele, dtRaspodeleJoin;

        public Form3()
        {
            InitializeComponent();
        }

        private void nastavnikPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime+' '+prezime AS naziv FROM osoba WHERE uloga = 2", veza);
            DataTable dtNastavnik = new DataTable();
            adapter.Fill(dtNastavnik);
            cbImePrezime.DataSource = dtNastavnik;
            cbImePrezime.ValueMember = "id";
            cbImePrezime.DisplayMember = "naziv";
        }

        private void godinaPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dtGodina = new DataTable();
            adapter.Fill(dtGodina);
            cbSkolskaGodina.DataSource = dtGodina;
            cbSkolskaGodina.ValueMember = "id";
            cbSkolskaGodina.DisplayMember = "naziv";
        }

        private void smerPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, naziv FROM smer", veza);
            DataTable dtPredmet = new DataTable();
            adapter.Fill(dtPredmet);
            cbSmer.DataSource = dtPredmet;
            cbSmer.ValueMember = "id";
            cbSmer.DisplayMember = "naziv";
        }

        private void gridPopulate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM odeljenje ORDER BY id", veza);
            dtRaspodele = new DataTable();
            adapter.Fill(dtRaspodele);

            string tmp1 = "SELECT odeljenje.id, odeljenje.razred, odeljenje.indeks, smer.naziv AS 'Naziv smera', osoba.ime + ' ' + osoba.prezime AS 'Razredni staresina', Skolska_godina.naziv AS 'Skolska godina' ";
            string tmp2 = "FROM Odeljenje JOIN smer ON Odeljenje.smer_id = smer.id JOIN Osoba ON Odeljenje.razredni_id = osoba.id JOIN Skolska_godina ON Odeljenje.godina_id = Skolska_godina.id WHERE osoba.uloga = 2";
            string tmp = tmp1 + tmp2;
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
                cbSmer.SelectedValue = dtRaspodele.Rows[broj]["smer_id"].ToString();
                cbImePrezime.SelectedValue = dtRaspodele.Rows[broj]["nastavnik_id"].ToString();
                cbSkolskaGodina.SelectedValue = dtRaspodele.Rows[broj]["godina_id"].ToString();
            }
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {

            try
            {
                string naredba = "DELETE FROM odeljenje WHERE id = " + dtRaspodele.Rows[broj]["id"].ToString();
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
                string naredba = "INSERT INTO odeljenje (razred, indeks, smer_id, razredni_id, odeljenje_id) VALUES ('";
                naredba = naredba + tbRazred.Text.ToString() + "',";
                naredba = naredba + tbIndeks.Text.ToString() + "',";
                naredba = naredba + cbSmer.SelectedValue.ToString() + "')";
                naredba = naredba + cbImePrezime.SelectedValue.ToString() + "',";
                naredba = naredba + cbSkolskaGodina.SelectedValue.ToString() + "',";


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
                string naredba = "UPDATE odeljenje SET razred='" + tbRazred.Text;
                naredba = naredba + "', indeks='" + tbIndeks.Text;
                naredba = naredba + "', smer_id='" + cbSmer.SelectedValue.ToString();
                naredba = naredba + "', razredni_id='" + cbImePrezime.SelectedValue.ToString();
                naredba = naredba + "', godina_id='" + cbSkolskaGodina.SelectedValue.ToString() + "'WHERE id='";
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

        private void Form3_Load(object sender, EventArgs e)
        {
            string CS = "Data Source = INF008\\SQLEXPRESS; Initial Catalog = esdnevnik; Integrated Security = True";
            veza = new SqlConnection(CS);
            nastavnikPopulate();
            godinaPopulate();
            smerPopulate();
            gridPopulate();
        }
    }
}
