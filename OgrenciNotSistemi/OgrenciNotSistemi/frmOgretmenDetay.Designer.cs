namespace OgrenciNotSistemi
{
    partial class frmOgretmenDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskNumara = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalanSayisi = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblGecenSayisi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblOgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayıtDataSet = new OgrenciNotSistemi.DbNotKayıtDataSet();
            this.tblOgrTableAdapter = new OgrenciNotSistemi.DbNotKayıtDataSetTableAdapters.tblOgrTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskNumara);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(332, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // mskNumara
            // 
            this.mskNumara.Location = new System.Drawing.Point(129, 143);
            this.mskNumara.Name = "mskNumara";
            this.mskNumara.Size = new System.Drawing.Size(157, 30);
            this.mskNumara.TabIndex = 24;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(129, 92);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 30);
            this.txtSoyad.TabIndex = 23;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(129, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 30);
            this.txtAd.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Öğrenci Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Numara :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Soyad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSınav3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSınav2);
            this.groupBox2.Controls.Add(this.txtSınav1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(371, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(332, 259);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(129, 140);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(157, 30);
            this.txtSınav3.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Sınav 3 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sınav 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sınav 1 :";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(129, 92);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(157, 30);
            this.txtSınav2.TabIndex = 23;
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(129, 41);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(157, 30);
            this.txtSınav1.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.lblKalanSayisi);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblGecenSayisi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(724, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(332, 259);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // lblKalanSayisi
            // 
            this.lblKalanSayisi.AutoSize = true;
            this.lblKalanSayisi.Location = new System.Drawing.Point(167, 145);
            this.lblKalanSayisi.Name = "lblKalanSayisi";
            this.lblKalanSayisi.Size = new System.Drawing.Size(32, 25);
            this.lblKalanSayisi.TabIndex = 25;
            this.lblKalanSayisi.Text = "....";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Kalan Sayısı :";
            // 
            // lblGecenSayisi
            // 
            this.lblGecenSayisi.AutoSize = true;
            this.lblGecenSayisi.Location = new System.Drawing.Point(167, 95);
            this.lblGecenSayisi.Name = "lblGecenSayisi";
            this.lblGecenSayisi.Size = new System.Drawing.Size(32, 25);
            this.lblGecenSayisi.TabIndex = 23;
            this.lblGecenSayisi.Text = "....";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Geçen Sayısı :";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(167, 45);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(32, 25);
            this.lblOrtalama.TabIndex = 21;
            this.lblOrtalama.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ortalama :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrNumaraDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrS1DataGridViewTextBoxColumn,
            this.ogrS2DataGridViewTextBoxColumn,
            this.ogrS3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblOgrBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 226);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNumaraDataGridViewTextBoxColumn
            // 
            this.ogrNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.HeaderText = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrNumaraDataGridViewTextBoxColumn.Name = "ogrNumaraDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "ogrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "ogrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "ogrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrS1DataGridViewTextBoxColumn
            // 
            this.ogrS1DataGridViewTextBoxColumn.DataPropertyName = "ogrS1";
            this.ogrS1DataGridViewTextBoxColumn.HeaderText = "ogrS1";
            this.ogrS1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrS1DataGridViewTextBoxColumn.Name = "ogrS1DataGridViewTextBoxColumn";
            // 
            // ogrS2DataGridViewTextBoxColumn
            // 
            this.ogrS2DataGridViewTextBoxColumn.DataPropertyName = "ogrS2";
            this.ogrS2DataGridViewTextBoxColumn.HeaderText = "ogrS2";
            this.ogrS2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrS2DataGridViewTextBoxColumn.Name = "ogrS2DataGridViewTextBoxColumn";
            // 
            // ogrS3DataGridViewTextBoxColumn
            // 
            this.ogrS3DataGridViewTextBoxColumn.DataPropertyName = "ogrS3";
            this.ogrS3DataGridViewTextBoxColumn.HeaderText = "ogrS3";
            this.ogrS3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrS3DataGridViewTextBoxColumn.Name = "ogrS3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // tblOgrBindingSource
            // 
            this.tblOgrBindingSource.DataMember = "tblOgr";
            this.tblOgrBindingSource.DataSource = this.dbNotKayıtDataSet;
            // 
            // dbNotKayıtDataSet
            // 
            this.dbNotKayıtDataSet.DataSetName = "DbNotKayıtDataSet";
            this.dbNotKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOgrTableAdapter
            // 
            this.tblOgrTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "Yenile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1075, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOgretmenDetay";
            this.Text = "frmOgretmenDetay";
            this.Load += new System.EventHandler(this.frmOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOgrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayıtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNumara;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKalanSayisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblGecenSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayıtDataSet dbNotKayıtDataSet;
        private System.Windows.Forms.BindingSource tblOgrBindingSource;
        private DbNotKayıtDataSetTableAdapters.tblOgrTableAdapter tblOgrTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Button button3;
    }
}