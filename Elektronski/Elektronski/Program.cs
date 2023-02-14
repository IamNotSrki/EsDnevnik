using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Elektronski
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            // MessageBox.Show(CS);
            SqlConnection conn = new SqlConnection(CS);
            return conn;
        }
        static public DataTable Unos(string Komanda)
        {
            DataTable Tabela = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(Komanda, Konekcija.Connect());
            adapter.Fill(Tabela);
            return Tabela;
        }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
