namespace XIIRPL2_13_Ticketing.MasterForm
{
    partial class FormMasterJadwalPenerbangan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDari = new System.Windows.Forms.ComboBox();
            this.txtKe = new System.Windows.Forms.ComboBox();
            this.txtMaskapai = new System.Windows.Forms.ComboBox();
            this.txtHargaPerTiket = new System.Windows.Forms.NumericUpDown();
            this.txtTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtWaktuKeberangkatan = new System.Windows.Forms.TextBox();
            this.txtDurasiPenerbangan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaPerTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 51;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 50;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(210, 315);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(246, 20);
            this.txtKode.TabIndex = 48;
            this.txtKode.TextChanged += new System.EventHandler(this.txtKodePenerbangan);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "ke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Dari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Kode Penerbangan ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEdit,
            this.BtnDelete});
            this.dataGridView1.Location = new System.Drawing.Point(70, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 197);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnEdit
            // 
            this.BtnEdit.HeaderText = "Edit";
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.HeaderText = "Delete";
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Semua jadwal penerbangan akan muncul di sini ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Master Jadwal Penerbangan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Maskapai";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Waktu keberangkatan ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Harga per Tiket";
            // 
            // txtDari
            // 
            this.txtDari.FormattingEnabled = true;
            this.txtDari.Location = new System.Drawing.Point(210, 359);
            this.txtDari.Name = "txtDari";
            this.txtDari.Size = new System.Drawing.Size(246, 21);
            this.txtDari.TabIndex = 57;
            // 
            // txtKe
            // 
            this.txtKe.FormattingEnabled = true;
            this.txtKe.Location = new System.Drawing.Point(210, 404);
            this.txtKe.Name = "txtKe";
            this.txtKe.Size = new System.Drawing.Size(246, 21);
            this.txtKe.TabIndex = 58;
            // 
            // txtMaskapai
            // 
            this.txtMaskapai.FormattingEnabled = true;
            this.txtMaskapai.Location = new System.Drawing.Point(210, 447);
            this.txtMaskapai.Name = "txtMaskapai";
            this.txtMaskapai.Size = new System.Drawing.Size(246, 21);
            this.txtMaskapai.TabIndex = 59;
            // 
            // txtHargaPerTiket
            // 
            this.txtHargaPerTiket.Location = new System.Drawing.Point(652, 432);
            this.txtHargaPerTiket.Name = "txtHargaPerTiket";
            this.txtHargaPerTiket.Size = new System.Drawing.Size(269, 20);
            this.txtHargaPerTiket.TabIndex = 60;
            this.txtHargaPerTiket.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txtTanggal
            // 
            this.txtTanggal.Location = new System.Drawing.Point(652, 322);
            this.txtTanggal.Name = "txtTanggal";
            this.txtTanggal.Size = new System.Drawing.Size(269, 20);
            this.txtTanggal.TabIndex = 61;
            // 
            // txtWaktuKeberangkatan
            // 
            this.txtWaktuKeberangkatan.Location = new System.Drawing.Point(652, 360);
            this.txtWaktuKeberangkatan.Name = "txtWaktuKeberangkatan";
            this.txtWaktuKeberangkatan.Size = new System.Drawing.Size(269, 20);
            this.txtWaktuKeberangkatan.TabIndex = 62;
            // 
            // txtDurasiPenerbangan
            // 
            this.txtDurasiPenerbangan.Location = new System.Drawing.Point(652, 397);
            this.txtDurasiPenerbangan.Name = "txtDurasiPenerbangan";
            this.txtDurasiPenerbangan.Size = new System.Drawing.Size(269, 20);
            this.txtDurasiPenerbangan.TabIndex = 63;
            // 
            // FormMasterJadwalPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 547);
            this.Controls.Add(this.txtDurasiPenerbangan);
            this.Controls.Add(this.txtWaktuKeberangkatan);
            this.Controls.Add(this.txtTanggal);
            this.Controls.Add(this.txtHargaPerTiket);
            this.Controls.Add(this.txtMaskapai);
            this.Controls.Add(this.txtKe);
            this.Controls.Add(this.txtDari);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterJadwalPenerbangan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHargaPerTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtDari;
        private System.Windows.Forms.ComboBox txtKe;
        private System.Windows.Forms.ComboBox txtMaskapai;
        private System.Windows.Forms.NumericUpDown txtHargaPerTiket;
        private System.Windows.Forms.DateTimePicker txtTanggal;
        private System.Windows.Forms.TextBox txtWaktuKeberangkatan;
        private System.Windows.Forms.TextBox txtDurasiPenerbangan;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}