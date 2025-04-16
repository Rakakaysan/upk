using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upk
{
    public partial class InformasiPengguna : UserControl
    {
        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlCommand command1;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public InformasiPengguna()
        {
            InitializeComponent();
        }
        public void showData()
        {
            try
            {
                connection.Close();
                connection.Open();

                string sql = "Select * from [InformasiPengguna]";

                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void InformasiPengguna_Load(object sender, EventArgs e)
                                                                                                                                                                   {
            tNamaPengguna.Text = "Haris yahya";
            tEmail.Text = "harisyahya@gmail.com";
            tPeran.Text = "admin";
            tStatus.Text = "aktif";
            tTerakhirLogin.Text = "10/03/2025 11.55";

        }
    }
}
