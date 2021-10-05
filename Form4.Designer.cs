namespace Aplikasi_Penjualan_Tanah_Kavling
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgTanah = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.txtLuas = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnTmbh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHps = new System.Windows.Forms.Button();
            this.btnSmpn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.idtanahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kavlingtanahDataSet2 = new Aplikasi_Penjualan_Tanah_Kavling.kavlingtanahDataSet2();
            this.tanahTableAdapter = new Aplikasi_Penjualan_Tanah_Kavling.kavlingtanahDataSet2TableAdapters.tanahTableAdapter();
            this.btnGambar = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTanah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kavlingtanahDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Tanah yang anda Jual";
            // 
            // imgTanah
            // 
            this.imgTanah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgTanah.BackgroundImage")));
            this.imgTanah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTanah.Location = new System.Drawing.Point(821, 79);
            this.imgTanah.Name = "imgTanah";
            this.imgTanah.Size = new System.Drawing.Size(349, 291);
            this.imgTanah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTanah.TabIndex = 3;
            this.imgTanah.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Judul ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Luas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alamat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Harga";
            // 
            // txtJudul
            // 
            this.txtJudul.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudul.Location = new System.Drawing.Point(87, 401);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(324, 30);
            this.txtJudul.TabIndex = 10;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.Black;
            this.txtStatus.Location = new System.Drawing.Point(87, 447);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(324, 30);
            this.txtStatus.TabIndex = 11;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(531, 398);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(285, 96);
            this.txtAlamat.TabIndex = 12;
            this.txtAlamat.Text = "";
            // 
            // txtLuas
            // 
            this.txtLuas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuas.Location = new System.Drawing.Point(87, 497);
            this.txtLuas.Name = "txtLuas";
            this.txtLuas.Size = new System.Drawing.Size(324, 30);
            this.txtLuas.TabIndex = 13;
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(530, 508);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(285, 30);
            this.txtHarga.TabIndex = 14;
            // 
            // btnTmbh
            // 
            this.btnTmbh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTmbh.FlatAppearance.BorderSize = 0;
            this.btnTmbh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTmbh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTmbh.Location = new System.Drawing.Point(32, 566);
            this.btnTmbh.Name = "btnTmbh";
            this.btnTmbh.Size = new System.Drawing.Size(95, 47);
            this.btnTmbh.TabIndex = 15;
            this.btnTmbh.Text = "Tambah";
            this.btnTmbh.UseVisualStyleBackColor = false;
            this.btnTmbh.Click += new System.EventHandler(this.btnTmbh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(171, 566);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 47);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHps
            // 
            this.btnHps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHps.FlatAppearance.BorderSize = 0;
            this.btnHps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHps.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHps.Location = new System.Drawing.Point(316, 566);
            this.btnHps.Name = "btnHps";
            this.btnHps.Size = new System.Drawing.Size(95, 47);
            this.btnHps.TabIndex = 17;
            this.btnHps.Text = "Hapus";
            this.btnHps.UseVisualStyleBackColor = false;
            this.btnHps.Click += new System.EventHandler(this.btnHps_Click);
            // 
            // btnSmpn
            // 
            this.btnSmpn.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSmpn.FlatAppearance.BorderSize = 0;
            this.btnSmpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmpn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmpn.ForeColor = System.Drawing.Color.White;
            this.btnSmpn.Location = new System.Drawing.Point(457, 566);
            this.btnSmpn.Name = "btnSmpn";
            this.btnSmpn.Size = new System.Drawing.Size(95, 47);
            this.btnSmpn.TabIndex = 18;
            this.btnSmpn.Text = "Simpan";
            this.btnSmpn.UseVisualStyleBackColor = false;
            this.btnSmpn.Click += new System.EventHandler(this.btnSmpn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(589, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 47);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgv2
            // 
            this.dgv2.AutoGenerateColumns = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtanahDataGridViewTextBoxColumn,
            this.judulDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.luasDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.iduserDataGridViewTextBoxColumn});
            this.dgv2.DataSource = this.tanahBindingSource;
            this.dgv2.Location = new System.Drawing.Point(11, 79);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 24;
            this.dgv2.Size = new System.Drawing.Size(804, 291);
            this.dgv2.TabIndex = 20;
            this.dgv2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_CellMouseClick);
            // 
            // idtanahDataGridViewTextBoxColumn
            // 
            this.idtanahDataGridViewTextBoxColumn.DataPropertyName = "id_tanah";
            this.idtanahDataGridViewTextBoxColumn.HeaderText = "id_tanah";
            this.idtanahDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtanahDataGridViewTextBoxColumn.Name = "idtanahDataGridViewTextBoxColumn";
            this.idtanahDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtanahDataGridViewTextBoxColumn.Width = 125;
            // 
            // judulDataGridViewTextBoxColumn
            // 
            this.judulDataGridViewTextBoxColumn.DataPropertyName = "judul";
            this.judulDataGridViewTextBoxColumn.HeaderText = "judul";
            this.judulDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.judulDataGridViewTextBoxColumn.Name = "judulDataGridViewTextBoxColumn";
            this.judulDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // luasDataGridViewTextBoxColumn
            // 
            this.luasDataGridViewTextBoxColumn.DataPropertyName = "luas";
            this.luasDataGridViewTextBoxColumn.HeaderText = "luas";
            this.luasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luasDataGridViewTextBoxColumn.Name = "luasDataGridViewTextBoxColumn";
            this.luasDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "foto";
            this.fotoDataGridViewImageColumn.HeaderText = "foto";
            this.fotoDataGridViewImageColumn.MinimumWidth = 6;
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.Width = 125;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanahBindingSource
            // 
            this.tanahBindingSource.DataMember = "tanah";
            this.tanahBindingSource.DataSource = this.kavlingtanahDataSet2;
            // 
            // kavlingtanahDataSet2
            // 
            this.kavlingtanahDataSet2.DataSetName = "kavlingtanahDataSet2";
            this.kavlingtanahDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tanahTableAdapter
            // 
            this.tanahTableAdapter.ClearBeforeFill = true;
            // 
            // btnGambar
            // 
            this.btnGambar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGambar.FlatAppearance.BorderSize = 0;
            this.btnGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGambar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGambar.ForeColor = System.Drawing.Color.Black;
            this.btnGambar.Location = new System.Drawing.Point(844, 385);
            this.btnGambar.Name = "btnGambar";
            this.btnGambar.Size = new System.Drawing.Size(95, 47);
            this.btnGambar.TabIndex = 21;
            this.btnGambar.Text = "Browse";
            this.btnGambar.UseVisualStyleBackColor = false;
            this.btnGambar.Click += new System.EventHandler(this.btnGambar_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(956, 385);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 19);
            this.lblFilePath.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 645);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Copyright © faysal fadel maulana 20190140097";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnGambar);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSmpn);
            this.Controls.Add(this.btnHps);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTmbh);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtLuas);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgTanah);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jual Tanah";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTanah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kavlingtanahDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgTanah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.TextBox txtLuas;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnTmbh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHps;
        private System.Windows.Forms.Button btnSmpn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgv2;
        private kavlingtanahDataSet2 kavlingtanahDataSet2;
        private System.Windows.Forms.BindingSource tanahBindingSource;
        private kavlingtanahDataSet2TableAdapters.tanahTableAdapter tanahTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtanahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGambar;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label7;
    }
}