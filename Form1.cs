using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace upk
{
    public partial class Form1 : Form
    {

        public SqlConnection connection = new SqlConnection(Koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            string username = tUsername.Text;
            string password = tPassword.Text;

            string sql = "SELECT * FROM [user] WHERE username = '" + username + "' AND PASSWORD = '" + password + "'";

            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);
            tabel = new DataTable();
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                foreach (DataRow row in tabel.Rows)
                {
                    if (row["role"].ToString() == "siswa")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        siswa2 window = new siswa2();
                        window.Show();
                    }
                    else if (row["role"].ToString() == "admin")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();
                        Model.name = reader.GetString(1);

                        this.Hide();
                        Guru2 windows = new Guru2();
                        windows.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            connection.Close();


            //App window = new App();
            //this.Hide();
            //window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
