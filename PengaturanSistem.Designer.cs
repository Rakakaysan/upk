namespace upk
{
    partial class PengaturanSistem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tTenggatWaktu = new System.Windows.Forms.TextBox();
            this.tUploadFileTugas = new System.Windows.Forms.TextBox();
            this.tMasukanNamaTugas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNamaSiswa = new System.Windows.Forms.TextBox();
            this.tNilai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bTambahkan = new System.Windows.Forms.Button();
            this.bEditNilai = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bTambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 100);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pengaturan\r\nSistem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tambah Tugas:";
            // 
            // tTenggatWaktu
            // 
            this.tTenggatWaktu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tTenggatWaktu.Location = new System.Drawing.Point(22, 340);
            this.tTenggatWaktu.Name = "tTenggatWaktu";
            this.tTenggatWaktu.Size = new System.Drawing.Size(255, 26);
            this.tTenggatWaktu.TabIndex = 32;
            this.tTenggatWaktu.TextChanged += new System.EventHandler(this.tURLVideo_TextChanged);
            // 
            // tUploadFileTugas
            // 
            this.tUploadFileTugas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tUploadFileTugas.Location = new System.Drawing.Point(293, 253);
            this.tUploadFileTugas.Name = "tUploadFileTugas";
            this.tUploadFileTugas.Size = new System.Drawing.Size(255, 26);
            this.tUploadFileTugas.TabIndex = 31;
            this.tUploadFileTugas.TextChanged += new System.EventHandler(this.tIsiMateri_TextChanged);
            // 
            // tMasukanNamaTugas
            // 
            this.tMasukanNamaTugas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tMasukanNamaTugas.Location = new System.Drawing.Point(22, 254);
            this.tMasukanNamaTugas.Name = "tMasukanNamaTugas";
            this.tMasukanNamaTugas.Size = new System.Drawing.Size(255, 26);
            this.tMasukanNamaTugas.TabIndex = 30;
            this.tMasukanNamaTugas.TextChanged += new System.EventHandler(this.tJudulMateri_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tenggat Waktu (Deadline)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Upload File Tugas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Masukan Nama Tugas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nilai Siswa:";
            // 
            // tNamaSiswa
            // 
            this.tNamaSiswa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tNamaSiswa.Location = new System.Drawing.Point(22, 488);
            this.tNamaSiswa.Name = "tNamaSiswa";
            this.tNamaSiswa.Size = new System.Drawing.Size(255, 26);
            this.tNamaSiswa.TabIndex = 34;
            // 
            // tNilai
            // 
            this.tNilai.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tNilai.Location = new System.Drawing.Point(293, 485);
            this.tNilai.Name = "tNilai";
            this.tNilai.Size = new System.Drawing.Size(255, 26);
            this.tNilai.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nama Siswa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(303, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nilai";
            // 
            // bTambahkan
            // 
            this.bTambahkan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bTambahkan.ForeColor = System.Drawing.Color.White;
            this.bTambahkan.Location = new System.Drawing.Point(34, 372);
            this.bTambahkan.Name = "bTambahkan";
            this.bTambahkan.Size = new System.Drawing.Size(115, 45);
            this.bTambahkan.TabIndex = 38;
            this.bTambahkan.Text = "Tambahkan";
            this.bTambahkan.UseVisualStyleBackColor = false;
            this.bTambahkan.Click += new System.EventHandler(this.bTambahkan_Click);
            // 
            // bEditNilai
            // 
            this.bEditNilai.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bEditNilai.ForeColor = System.Drawing.Color.White;
            this.bEditNilai.Location = new System.Drawing.Point(205, 531);
            this.bEditNilai.Name = "bEditNilai";
            this.bEditNilai.Size = new System.Drawing.Size(169, 45);
            this.bEditNilai.TabIndex = 39;
            this.bEditNilai.Text = "Edit Nilai";
            this.bEditNilai.UseVisualStyleBackColor = false;
            this.bEditNilai.Click += new System.EventHandler(this.bEditNilai_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.White;
            this.bEdit.ForeColor = System.Drawing.Color.Black;
            this.bEdit.Location = new System.Drawing.Point(173, 372);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(115, 45);
            this.bEdit.TabIndex = 40;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bTambah
            // 
            this.bTambah.BackColor = System.Drawing.Color.White;
            this.bTambah.ForeColor = System.Drawing.Color.Black;
            this.bTambah.Location = new System.Drawing.Point(10, 531);
            this.bTambah.Name = "bTambah";
            this.bTambah.Size = new System.Drawing.Size(157, 45);
            this.bTambah.TabIndex = 41;
            this.bTambah.Text = "Tambahkan Nilai";
            this.bTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(575, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(386, 477);
            this.dataGridView1.TabIndex = 43;
            // 
            // tSearch
            // 
            this.tSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tSearch.Location = new System.Drawing.Point(575, 117);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(255, 26);
            this.tSearch.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Search";
            // 
            // PengaturanSistem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bTambah);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bEditNilai);
            this.Controls.Add(this.bTambahkan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tNilai);
            this.Controls.Add(this.tNamaSiswa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tTenggatWaktu);
            this.Controls.Add(this.tUploadFileTugas);
            this.Controls.Add(this.tMasukanNamaTugas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "PengaturanSistem";
            this.Size = new System.Drawing.Size(987, 758);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tTenggatWaktu;
        private System.Windows.Forms.TextBox tUploadFileTugas;
        private System.Windows.Forms.TextBox tMasukanNamaTugas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNamaSiswa;
        private System.Windows.Forms.TextBox tNilai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bTambahkan;
        private System.Windows.Forms.Button bEditNilai;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bTambah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label label8;
    }
}
