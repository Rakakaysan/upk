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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace upk
{
    public partial class PengaturanSistem : UserControl
    {
        public SqlConnection Connection = new SqlConnection(Koneksi.conn);
        public SqlCommand Command;
        public SqlDataAdapter Adapter;
        public DataTable tabel;
        public SqlDataReader reader;
        public string unselectedErrorWarning = "Silahkan memilih data terlebih dahulu";
        public int NIP;
        public PengaturanSistem()
        {
            InitializeComponent();

        }
        public void showData()
        {
            try
            {
                Connection.Close();
                Connection.Open();

                string sql = "SELECT * from [pengaturan_sistem]";

                Command = new SqlCommand(sql, Connection);
                Adapter = new SqlDataAdapter(Command);
                tabel = new DataTable();
                Adapter.Fill(tabel);

                dataGridView1.DataSource = tabel;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "nama_tugas";
                dataGridView1.Columns[2].HeaderText = "deadlime";
                dataGridView1.Columns[3].HeaderText = "nama_siswa";
                dataGridView1.Columns[4].HeaderText = "nilai";
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insertData()
        {
            if (isInputFilled())
            {
                try
                {
                    Connection.Close();
                    Connection.Open();



                    string sql = "INSERT INTO [pengaturan_sistem] (nama_tugas , uploud, deadline, nama_siswa, nilai) " +
                        "VALUES (@nama_tugas, @uploud, @deadline, @nama_siswa, @nilai)";

                    Command = new SqlCommand(sql, Connection);
                    Command.Parameters.AddWithValue("@nama_tugas", tMasukanNamaTugas);
                    Command.Parameters.AddWithValue("@deadline", tTenggatWaktu);
                    Command.Parameters.AddWithValue("@nama_siswa", tNamaSiswa);
                    Command.Parameters.AddWithValue("@nilai", tNilai);

                    Command.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dimasukan!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connection.Close();
                    clearInput();
                    showData();
                }
            }
        }
        public void deleteData()
        {
            if (dataGridView1.CurrentRow.Selected)
            {
                if (isInputFilled())
                {
                    DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus data",
                        "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "DELETE FROM [pengaturan_sistem] WHERE nama_tugas = " + tMasukanNamaTugas;

                        Command = new SqlCommand(sql, Connection);

                        try
                        {
                            Connection.Open();
                            Command.ExecuteNonQuery();
                            MessageBox.Show("Hapus berhasil", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Gagal hapus",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            clearInput();
                            showData();
                            Connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(unselectedErrorWarning, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void searchData()
        {
            if (!string.IsNullOrEmpty(tSearch.Text))
            {
                try
                {


                    Connection.Close();
                    Connection.Open();
                    string sql = "SELECT * FROM [pengaturan_sistem] " +
                        "WHERE [nama_tugas] LIKE '%' + @search + '%' " +
                        "OR [deadline] LIKE '%' + @search + '%' " +
                        "OR [nama_siswa] LIKE '%' + @search + '%' " +
                        "OR [nilai] LIKE '%' + @search + '%' ";

                    Command = new SqlCommand(sql, Connection);
                    Command.Parameters.AddWithValue("@search", tSearch.Text);
                    Adapter = new SqlDataAdapter(Command);
                    tabel = new DataTable();
                    Adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "nama_tugas";
                    dataGridView1.Columns[2].HeaderText = "deadline";
                    dataGridView1.Columns[3].HeaderText = "nama_siswa";
                    dataGridView1.Columns[4].HeaderText = "nialai";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Gagal",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Connection.Close();
                }
            }
            else
            {
                showData(); // Tampilkan data jika input kosong
            }
        }
        public void clearInput()
        {


            tMasukanNamaTugas.Text = "";
            tUploadFileTugas.Text = "";
            tTenggatWaktu.Text = "";
            tNamaSiswa.Text = "";
            tNilai.Text = "";
        }

        public bool isInputFilled()
        {


            if (
                !string.IsNullOrEmpty(tMasukanNamaTugas.Text) // jika textbox nis tidak kosong atau null 
                && !string.IsNullOrEmpty(tUploadFileTugas.Text) // jika textbox nama tidak kosong atau null 
                && !string.IsNullOrEmpty(tTenggatWaktu.Text) // jika combobox kelas tidak kosong atau null 
                && !string.IsNullOrEmpty(tNamaSiswa.Text) // jika textbox alamat tidak kosong atau null 
                && !string.IsNullOrEmpty(tNilai.Text) // dst
                )
            {
                return true;
            }

            MessageBox.Show("Input tidak boleh ada yang kosong", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void tJudulMateri_TextChanged(object sender, EventArgs e)
        {

        }

        private void tIsiMateri_TextChanged(object sender, EventArgs e)
        {

        }

        private void tURLVideo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bEditNilai_Click(object sender, EventArgs e)
        {

        }

        private void bTambahkan_Click(object sender, EventArgs e)
        {
            string data = "nama:{nama.Text}, nip:{nip.Text}, status:{status.Text}, email addres:{emailaddres.Text}, jabatan:{jabatan.Text}, password:{password.Text}, username:{username.Text}";
            MessageBox.Show("data berhasil ditambahkan!" + data);
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data berhasil diperbarui!");

        }
    }

}


