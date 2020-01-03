namespace Soru_Bankasi
{
    partial class Ogretmen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cmbsecim = new System.Windows.Forms.ComboBox();
            this.boxsoruekleme = new System.Windows.Forms.GroupBox();
            this.Btnsorusil = new System.Windows.Forms.Button();
            this.Btnsoruguncel = new System.Windows.Forms.Button();
            this.Btnsoruekleme = new System.Windows.Forms.Button();
            this.cmbkonu = new System.Windows.Forms.ComboBox();
            this.cmbsiklar = new System.Windows.Forms.ComboBox();
            this.txtboxdsikki = new System.Windows.Forms.TextBox();
            this.txtboxcsikki = new System.Windows.Forms.TextBox();
            this.txtboxbsikki = new System.Windows.Forms.TextBox();
            this.txtboxasikki = new System.Windows.Forms.TextBox();
            this.txtboxsoru = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxsoruliste = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sorunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asikkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsikkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csikkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsikkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cevapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSorularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soruListelemeDataset = new Soru_Bankasi.SoruListelemeDataset();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.tbl_SorularTableAdapter = new Soru_Bankasi.SoruListelemeDatasetTableAdapters.Tbl_SorularTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boxsoruekleme.SuspendLayout();
            this.boxsoruliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSorularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruListelemeDataset)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cmbsecim
            // 
            this.Cmbsecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmbsecim.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmbsecim.FormattingEnabled = true;
            this.Cmbsecim.Items.AddRange(new object[] {
            "Soru Yaz",
            "Soru Düzenle",
            "Soru Sil"});
            this.Cmbsecim.Location = new System.Drawing.Point(679, 51);
            this.Cmbsecim.Name = "Cmbsecim";
            this.Cmbsecim.Size = new System.Drawing.Size(273, 33);
            this.Cmbsecim.TabIndex = 0;
            this.Cmbsecim.TextChanged += new System.EventHandler(this.Cmbsecim_TextChanged);
            // 
            // boxsoruekleme
            // 
            this.boxsoruekleme.Controls.Add(this.Btnsorusil);
            this.boxsoruekleme.Controls.Add(this.Btnsoruguncel);
            this.boxsoruekleme.Controls.Add(this.Btnsoruekleme);
            this.boxsoruekleme.Controls.Add(this.cmbkonu);
            this.boxsoruekleme.Controls.Add(this.cmbsiklar);
            this.boxsoruekleme.Controls.Add(this.txtboxdsikki);
            this.boxsoruekleme.Controls.Add(this.txtboxcsikki);
            this.boxsoruekleme.Controls.Add(this.txtboxbsikki);
            this.boxsoruekleme.Controls.Add(this.txtboxasikki);
            this.boxsoruekleme.Controls.Add(this.txtboxsoru);
            this.boxsoruekleme.Controls.Add(this.label7);
            this.boxsoruekleme.Controls.Add(this.label6);
            this.boxsoruekleme.Controls.Add(this.label5);
            this.boxsoruekleme.Controls.Add(this.label4);
            this.boxsoruekleme.Controls.Add(this.label3);
            this.boxsoruekleme.Controls.Add(this.label2);
            this.boxsoruekleme.Controls.Add(this.label1);
            this.boxsoruekleme.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxsoruekleme.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.boxsoruekleme.Location = new System.Drawing.Point(3, 9);
            this.boxsoruekleme.Name = "boxsoruekleme";
            this.boxsoruekleme.Size = new System.Drawing.Size(660, 593);
            this.boxsoruekleme.TabIndex = 1;
            this.boxsoruekleme.TabStop = false;
            this.boxsoruekleme.Text = "İşlemler";
            // 
            // Btnsorusil
            // 
            this.Btnsorusil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsorusil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsorusil.Location = new System.Drawing.Point(411, 471);
            this.Btnsorusil.Name = "Btnsorusil";
            this.Btnsorusil.Size = new System.Drawing.Size(167, 84);
            this.Btnsorusil.TabIndex = 16;
            this.Btnsorusil.Text = "Soruyu Sil";
            this.Btnsorusil.UseVisualStyleBackColor = true;
            this.Btnsorusil.Click += new System.EventHandler(this.Btnsorusil_Click);
            // 
            // Btnsoruguncel
            // 
            this.Btnsoruguncel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsoruguncel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsoruguncel.Location = new System.Drawing.Point(221, 471);
            this.Btnsoruguncel.Name = "Btnsoruguncel";
            this.Btnsoruguncel.Size = new System.Drawing.Size(167, 84);
            this.Btnsoruguncel.TabIndex = 15;
            this.Btnsoruguncel.Text = "Soruyu Güncelle";
            this.Btnsoruguncel.UseVisualStyleBackColor = true;
            this.Btnsoruguncel.Click += new System.EventHandler(this.Btnsoruguncel_Click);
            // 
            // Btnsoruekleme
            // 
            this.Btnsoruekleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsoruekleme.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btnsoruekleme.Location = new System.Drawing.Point(27, 471);
            this.Btnsoruekleme.Name = "Btnsoruekleme";
            this.Btnsoruekleme.Size = new System.Drawing.Size(168, 84);
            this.Btnsoruekleme.TabIndex = 14;
            this.Btnsoruekleme.Text = "Soru Ekle";
            this.Btnsoruekleme.UseVisualStyleBackColor = true;
            this.Btnsoruekleme.Click += new System.EventHandler(this.Btnsoruekleme_Click);
            // 
            // cmbkonu
            // 
            this.cmbkonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkonu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbkonu.FormattingEnabled = true;
            this.cmbkonu.Items.AddRange(new object[] {
            "Üslü Sayılar",
            "Mutlak Değer",
            "Cebirsel İfadeler",
            "Ondalık Gösterimler",
            "İşlem Önceliği",
            "Bölünebilme Kuralları"});
            this.cmbkonu.Location = new System.Drawing.Point(177, 404);
            this.cmbkonu.Name = "cmbkonu";
            this.cmbkonu.Size = new System.Drawing.Size(339, 33);
            this.cmbkonu.TabIndex = 13;
            // 
            // cmbsiklar
            // 
            this.cmbsiklar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsiklar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbsiklar.FormattingEnabled = true;
            this.cmbsiklar.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbsiklar.Location = new System.Drawing.Point(177, 354);
            this.cmbsiklar.Name = "cmbsiklar";
            this.cmbsiklar.Size = new System.Drawing.Size(339, 33);
            this.cmbsiklar.TabIndex = 12;
            // 
            // txtboxdsikki
            // 
            this.txtboxdsikki.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxdsikki.Location = new System.Drawing.Point(177, 302);
            this.txtboxdsikki.MaxLength = 20;
            this.txtboxdsikki.Name = "txtboxdsikki";
            this.txtboxdsikki.Size = new System.Drawing.Size(339, 32);
            this.txtboxdsikki.TabIndex = 11;
            // 
            // txtboxcsikki
            // 
            this.txtboxcsikki.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxcsikki.Location = new System.Drawing.Point(177, 255);
            this.txtboxcsikki.MaxLength = 20;
            this.txtboxcsikki.Name = "txtboxcsikki";
            this.txtboxcsikki.Size = new System.Drawing.Size(339, 32);
            this.txtboxcsikki.TabIndex = 10;
            // 
            // txtboxbsikki
            // 
            this.txtboxbsikki.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxbsikki.Location = new System.Drawing.Point(177, 200);
            this.txtboxbsikki.MaxLength = 20;
            this.txtboxbsikki.Name = "txtboxbsikki";
            this.txtboxbsikki.Size = new System.Drawing.Size(339, 32);
            this.txtboxbsikki.TabIndex = 9;
            // 
            // txtboxasikki
            // 
            this.txtboxasikki.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxasikki.Location = new System.Drawing.Point(177, 149);
            this.txtboxasikki.MaxLength = 20;
            this.txtboxasikki.Name = "txtboxasikki";
            this.txtboxasikki.Size = new System.Drawing.Size(339, 32);
            this.txtboxasikki.TabIndex = 8;
            // 
            // txtboxsoru
            // 
            this.txtboxsoru.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxsoru.Location = new System.Drawing.Point(177, 37);
            this.txtboxsoru.MaxLength = 349;
            this.txtboxsoru.Name = "txtboxsoru";
            this.txtboxsoru.Size = new System.Drawing.Size(339, 96);
            this.txtboxsoru.TabIndex = 7;
            this.txtboxsoru.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(101, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Konu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğru Cevap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "D Şıkkı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "C Şıkkı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "B Şıkkı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "A Şıkkı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru:";
            // 
            // boxsoruliste
            // 
            this.boxsoruliste.Controls.Add(this.dataGridView1);
            this.boxsoruliste.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxsoruliste.Location = new System.Drawing.Point(669, 9);
            this.boxsoruliste.Name = "boxsoruliste";
            this.boxsoruliste.Size = new System.Drawing.Size(864, 584);
            this.boxsoruliste.TabIndex = 2;
            this.boxsoruliste.TabStop = false;
            this.boxsoruliste.Text = "Soru Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorunoDataGridViewTextBoxColumn,
            this.soruDataGridViewTextBoxColumn,
            this.asikkiDataGridViewTextBoxColumn,
            this.bsikkiDataGridViewTextBoxColumn,
            this.csikkiDataGridViewTextBoxColumn,
            this.dsikkiDataGridViewTextBoxColumn,
            this.cevapDataGridViewTextBoxColumn,
            this.konuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSorularBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(858, 553);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // sorunoDataGridViewTextBoxColumn
            // 
            this.sorunoDataGridViewTextBoxColumn.DataPropertyName = "soruno";
            this.sorunoDataGridViewTextBoxColumn.HeaderText = "Soru No";
            this.sorunoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sorunoDataGridViewTextBoxColumn.Name = "sorunoDataGridViewTextBoxColumn";
            this.sorunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sorunoDataGridViewTextBoxColumn.Width = 125;
            // 
            // soruDataGridViewTextBoxColumn
            // 
            this.soruDataGridViewTextBoxColumn.DataPropertyName = "soru";
            this.soruDataGridViewTextBoxColumn.HeaderText = "Soru";
            this.soruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soruDataGridViewTextBoxColumn.Name = "soruDataGridViewTextBoxColumn";
            this.soruDataGridViewTextBoxColumn.ReadOnly = true;
            this.soruDataGridViewTextBoxColumn.Width = 125;
            // 
            // asikkiDataGridViewTextBoxColumn
            // 
            this.asikkiDataGridViewTextBoxColumn.DataPropertyName = "asikki";
            this.asikkiDataGridViewTextBoxColumn.HeaderText = "A Şıkkı";
            this.asikkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asikkiDataGridViewTextBoxColumn.Name = "asikkiDataGridViewTextBoxColumn";
            this.asikkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.asikkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsikkiDataGridViewTextBoxColumn
            // 
            this.bsikkiDataGridViewTextBoxColumn.DataPropertyName = "bsikki";
            this.bsikkiDataGridViewTextBoxColumn.HeaderText = "B Şıkkı";
            this.bsikkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bsikkiDataGridViewTextBoxColumn.Name = "bsikkiDataGridViewTextBoxColumn";
            this.bsikkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.bsikkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // csikkiDataGridViewTextBoxColumn
            // 
            this.csikkiDataGridViewTextBoxColumn.DataPropertyName = "csikki";
            this.csikkiDataGridViewTextBoxColumn.HeaderText = "C Şıkkı";
            this.csikkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.csikkiDataGridViewTextBoxColumn.Name = "csikkiDataGridViewTextBoxColumn";
            this.csikkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.csikkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dsikkiDataGridViewTextBoxColumn
            // 
            this.dsikkiDataGridViewTextBoxColumn.DataPropertyName = "dsikki";
            this.dsikkiDataGridViewTextBoxColumn.HeaderText = "D Şıkkı";
            this.dsikkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dsikkiDataGridViewTextBoxColumn.Name = "dsikkiDataGridViewTextBoxColumn";
            this.dsikkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.dsikkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cevapDataGridViewTextBoxColumn
            // 
            this.cevapDataGridViewTextBoxColumn.DataPropertyName = "cevap";
            this.cevapDataGridViewTextBoxColumn.HeaderText = "Cevap";
            this.cevapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cevapDataGridViewTextBoxColumn.Name = "cevapDataGridViewTextBoxColumn";
            this.cevapDataGridViewTextBoxColumn.ReadOnly = true;
            this.cevapDataGridViewTextBoxColumn.Width = 125;
            // 
            // konuDataGridViewTextBoxColumn
            // 
            this.konuDataGridViewTextBoxColumn.DataPropertyName = "konu";
            this.konuDataGridViewTextBoxColumn.HeaderText = "Konu";
            this.konuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.konuDataGridViewTextBoxColumn.Name = "konuDataGridViewTextBoxColumn";
            this.konuDataGridViewTextBoxColumn.ReadOnly = true;
            this.konuDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblSorularBindingSource
            // 
            this.tblSorularBindingSource.DataMember = "Tbl_Sorular";
            this.tblSorularBindingSource.DataSource = this.soruListelemeDataset;
            // 
            // soruListelemeDataset
            // 
            this.soruListelemeDataset.DataSetName = "SoruListelemeDataset";
            this.soruListelemeDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Location = new System.Drawing.Point(727, 824);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(66, 17);
            this.lblsoruno.TabIndex = 3;
            this.lblsoruno.Text = "lblsoruno";
            // 
            // tbl_SorularTableAdapter
            // 
            this.tbl_SorularTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(687, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Aşağıdan işlemi Seçiniz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1499, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Cmbsecim);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1598, 105);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boxsoruekleme);
            this.panel2.Controls.Add(this.boxsoruliste);
            this.panel2.Location = new System.Drawing.Point(-1, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1598, 633);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsoruno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogretmen";
            this.Load += new System.EventHandler(this.Ogretmen_Load);
            this.boxsoruekleme.ResumeLayout(false);
            this.boxsoruekleme.PerformLayout();
            this.boxsoruliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSorularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soruListelemeDataset)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmbsecim;
        private System.Windows.Forms.GroupBox boxsoruekleme;
        private System.Windows.Forms.Button Btnsorusil;
        private System.Windows.Forms.Button Btnsoruguncel;
        private System.Windows.Forms.Button Btnsoruekleme;
        private System.Windows.Forms.ComboBox cmbkonu;
        private System.Windows.Forms.ComboBox cmbsiklar;
        private System.Windows.Forms.TextBox txtboxdsikki;
        private System.Windows.Forms.TextBox txtboxcsikki;
        private System.Windows.Forms.TextBox txtboxbsikki;
        private System.Windows.Forms.TextBox txtboxasikki;
        private System.Windows.Forms.RichTextBox txtboxsoru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox boxsoruliste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblsoruno;
        private SoruListelemeDataset soruListelemeDataset;
        private System.Windows.Forms.BindingSource tblSorularBindingSource;
        private SoruListelemeDatasetTableAdapters.Tbl_SorularTableAdapter tbl_SorularTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asikkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bsikkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csikkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsikkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cevapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn konuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}