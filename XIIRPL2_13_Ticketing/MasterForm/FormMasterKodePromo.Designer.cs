namespace XIIRPL2_13_Ticketing.MasterForm
{
    partial class FormMasterKodePromo
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
            this.txtSimpan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.txtKodePromo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBerlakuSampai = new System.Windows.Forms.DateTimePicker();
            this.txtPersentaseDiskon = new System.Windows.Forms.NumericUpDown();
            this.txtMaksimumDiskon = new System.Windows.Forms.NumericUpDown();
            this.BtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersentaseDiskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaksimumDiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSimpan
            // 
            this.txtSimpan.Location = new System.Drawing.Point(701, 391);
            this.txtSimpan.Name = "txtSimpan";
            this.txtSimpan.Size = new System.Drawing.Size(87, 31);
            this.txtSimpan.TabIndex = 38;
            this.txtSimpan.Text = "Simpan";
            this.txtSimpan.UseVisualStyleBackColor = true;
            this.txtSimpan.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Location = new System.Drawing.Point(492, 283);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(296, 72);
            this.txtDeskripsi.TabIndex = 36;
            // 
            // txtKodePromo
            // 
            this.txtKodePromo.Location = new System.Drawing.Point(115, 283);
            this.txtKodePromo.Name = "txtKodePromo";
            this.txtKodePromo.Size = new System.Drawing.Size(269, 20);
            this.txtKodePromo.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Deskripsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Berlaku Sampai ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kode Promo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BtnEdit,
            this.BtnDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 170);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Semua kode promo yang terdaftar akan muncul di sini ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Master Kode Promo";
            // 
            // txtBerlakuSampai
            // 
            this.txtBerlakuSampai.Location = new System.Drawing.Point(115, 321);
            this.txtBerlakuSampai.Name = "txtBerlakuSampai";
            this.txtBerlakuSampai.Size = new System.Drawing.Size(269, 20);
            this.txtBerlakuSampai.TabIndex = 62;
            // 
            // txtPersentaseDiskon
            // 
            this.txtPersentaseDiskon.Location = new System.Drawing.Point(115, 363);
            this.txtPersentaseDiskon.Name = "txtPersentaseDiskon";
            this.txtPersentaseDiskon.Size = new System.Drawing.Size(269, 20);
            this.txtPersentaseDiskon.TabIndex = 63;
            // 
            // txtMaksimumDiskon
            // 
            this.txtMaksimumDiskon.Location = new System.Drawing.Point(115, 407);
            this.txtMaksimumDiskon.Name = "txtMaksimumDiskon";
            this.txtMaksimumDiskon.Size = new System.Drawing.Size(269, 20);
            this.txtMaksimumDiskon.TabIndex = 64;
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
            // FormMasterKodePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.txtMaksimumDiskon);
            this.Controls.Add(this.txtPersentaseDiskon);
            this.Controls.Add(this.txtBerlakuSampai);
            this.Controls.Add(this.txtSimpan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.txtKodePromo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterKodePromo";
            this.Text = "FormMasterKodePromo";
            this.Load += new System.EventHandler(this.FormMasterKodePromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersentaseDiskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaksimumDiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSimpan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtKodePromo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtBerlakuSampai;
        private System.Windows.Forms.NumericUpDown txtPersentaseDiskon;
        private System.Windows.Forms.NumericUpDown txtMaksimumDiskon;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn BtnDelete;
    }
}