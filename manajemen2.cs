using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace upk
{
    public partial class manajemen2 : UserControl
    {
        private SqlConnection connection = new SqlConnection(Koneksi.conn);
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable tabel;
        public int NIP;

        public manajemen2()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();

                string sql = "SELECT * FROM [manajemen]";
                command = new SqlCommand(sql, connection);
                adapter = new SqlDataAdapter(command);
                tabel = new DataTable();
                adapter.Fill(tabel);

                if (tabel.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan di tabel manajemen.");
                }

                dataGridView1.DataSource = tabel;
                dataGridView1.Refresh();

                // Validasi jumlah kolom sebelum mengakses
                if (dataGridView1.Columns.Count >= 6)
                {
                    dataGridView1.Columns[0].HeaderText = "NIP";
                    dataGridView1.Columns[1].HeaderText = "Nama";
                    dataGridView1.Columns[2].HeaderText = "Email";
                    dataGridView1.Columns[3].HeaderText = "Jabatan";
                    dataGridView1.Columns[4].HeaderText = "Status";
                    dataGridView1.Columns[5].HeaderText = "Password";
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menampilkan data: " + ex.Message);
            }
        }

        private void manajemen2_Load(object sender, EventArgs e)
        {
            ShowData(); // Pastikan dipanggil di event Load juga
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                NIP = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                tNamalengkap.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString();
                tEmail.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString();
                tJabatan.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString();
                tStatus.Text = dataGridView1.CurrentRow.Cells[4].Value?.ToString();
                tPassword.Text = dataGridView1.CurrentRow.Cells[5].Value?.ToString();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"nama: {tNamalengkap.Text}, nip: {tNip.Text}, status: {tStatus.Text}, email: {tEmail.Text}, jabatan: {tJabatan.Text}, password: {tPassword.Text}");
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data berhasil diperbarui!");

        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = tSearch.Text.ToLower();

            // Filter data berdasarkan input
            var hasil = dataGridView1.Where(item => item.ToLower().Contains(keyword)).ToList();

            TampilkanData(hasil);
        }
        private void TampilkanData(List<string> list)
        {
            dataGridView1.Items.Clear();

            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    dataGridView1.Items.Add(item);
                }
            }
            else
            {
                dataGridView1.Items.Add("Tidak ditemukan.");
            }
        }
    }
}
