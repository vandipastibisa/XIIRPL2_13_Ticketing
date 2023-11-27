namespace XIIRPL2_13_Ticketing.MasterForm
{
    partial class FormMasterBandara
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.txtKodeIATA = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNegara = new System.Windows.Forms.ComboBox();
            this.txtJumlahTerminal = new System.Windows.Forms.NumericUpDown();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Bandara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Semua bendahara yang terdaftar akan muncul di sini ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kode Kota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Negara";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Alamat";
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(115, 364);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(269, 20);
            this.txtKota.TabIndex = 11;
            // 
            // txtKodeIATA
            // 
            this.txtKodeIATA.Location = new System.Drawing.Point(115, 319);
            this.txtKodeIATA.Name = "txtKodeIATA";
            this.txtKodeIATA.Size = new System.Drawing.Size(269, 20);
            this.txtKodeIATA.TabIndex = 12;
            this.txtKodeIATA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(115, 284);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(269, 20);
            this.txtNama.TabIndex = 13;
            // 
            // txtNegara
            // 
            this.txtNegara.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNegara.FormattingEnabled = true;
            this.txtNegara.Location = new System.Drawing.Point(115, 404);
            this.txtNegara.Name = "txtNegara";
            this.txtNegara.Size = new System.Drawing.Size(269, 21);
            this.txtNegara.TabIndex = 17;
            // 
            // txtJumlahTerminal
            // 
            this.txtJumlahTerminal.Location = new System.Drawing.Point(502, 285);
            this.txtJumlahTerminal.Name = "txtJumlahTerminal";
            this.txtJumlahTerminal.Size = new System.Drawing.Size(269, 20);
            this.txtJumlahTerminal.TabIndex = 18;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(502, 338);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(269, 120);
            this.txtAlamat.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 36);
            this.button3.TabIndex = 22;
            this.button3.Text = "edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEdit,
            this.BtnDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 178);
            this.dataGridView1.TabIndex = 2;
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
            // FormMasterBandara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 550);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtJumlahTerminal);
            this.Controls.Add(this.txtNegara);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKodeIATA);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterBandara";
            this.Text = "FormMasterBandara";
            this.Load += new System.EventHandler(this.FormMasterBandara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlahTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtKodeIATA;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox txtNegara;
        private System.Windows.Forms.NumericUpDown txtJumlahTerminal;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}