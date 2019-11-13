using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formSql1914113
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"server=(localdb)\MSSQLLocalDB");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            var adapter = new SqlDataAdapter();

            adapter.InsertCommand = new SqlCommand(
                "INSERT INTO jegyek (nev, datum, tema, tz, jegy)" +
                $"VALUES ('{tbNEv.Text}', '{dtpDatum.Value.ToString("yyyy-MM-dd hh:mm:ss")}', '{tbTema.Text}', {(cbTz.Checked ? 1 : 0)}, {nudJegy.Value});", conn);

            adapter.InsertCommand.ExecuteNonQuery(); 

            conn.Close();
            MessageBox.Show("Az adatok rögzítése megtörtént!");
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
