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
    
    public partial class siswa2 : Form
    {

        public siswa2()
        {
            InitializeComponent();

        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 windows = new Form1();
            windows.Show();
        }

        private void bKompetensiDanTujuan_Click(object sender, EventArgs e)
        {
            kdt1.BringToFront();
        }

        private void bMateri_Click(object sender, EventArgs e)
        {
            mater1.BringToFront();
        }

        private void bTugas_Click(object sender, EventArgs e)
        {
            tugas1.BringToFront();
        }

        private void bTentangAplikasi_Click(object sender, EventArgs e)
        {
            tentang1.BringToFront();
        }
    }
}
