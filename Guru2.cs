using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upk
{
    public partial class Guru2 : Form
    {
        public Guru2()
        {
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 windows = new Form1();
            windows.Show();
        }

        private void bManagemenPengguna_Click(object sender, EventArgs e)
        {
           manajemen2.BringToFront();
        }

        private void bMateriPembelajaran_Click(object sender, EventArgs e)
        {
            tambahMateri2.BringToFront();
        }

        private void bInformasiPengguna_Click(object sender, EventArgs e)
        {
            informasiPengguna2.BringToFront();
        }

        private void bPengaturanSistem_Click(object sender, EventArgs e)
        {
            pengaturanSistem2.BringToFront();
        }

        private void bTentangAplikasi_Click(object sender, EventArgs e)
        {
            tentangAplikasiGuru2.BringToFront();
        }

        private void tambahMateri2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
