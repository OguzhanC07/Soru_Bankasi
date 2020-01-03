namespace Soru_Bankasi
{
    partial class Istatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnsonra = new System.Windows.Forms.Button();
            this.btnonce = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.datasonuc = new System.Windows.Forms.DataGridView();
            this.testnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutlakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cebirselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ondalikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncelikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolunebilmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCevaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cevaplarDataset = new Soru_Bankasi.CevaplarDataset();
            this.datakontrol = new System.Windows.Forms.DataGridView();
            this.testnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usluDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutlakDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cebirselDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ondalikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncelikDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolunebilmeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKontrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kontrolDataset = new Soru_Bankasi.KontrolDataset();
            this.tbl_CevaplarTableAdapter = new Soru_Bankasi.CevaplarDatasetTableAdapters.Tbl_CevaplarTableAdapter();
            this.tbl_KontrolTableAdapter = new Soru_Bankasi.KontrolDatasetTableAdapters.Tbl_KontrolTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbltest = new System.Windows.Forms.Label();
            this.tblDogruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetdoğru = new Soru_Bankasi.datasetdoğru();
            this.tbl_DogruTableAdapter = new Soru_Bankasi.datasetdoğruTableAdapters.Tbl_DogruTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dogruSayisiDataset = new Soru_Bankasi.DogruSayisiDataset();
            this.tblDogruBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DogruTableAdapter1 = new Soru_Bankasi.DogruSayisiDatasetTableAdapters.Tbl_DogruTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCevaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevaplarDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKontrolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetdoğru)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogruSayisiDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogruBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsonra
            // 
            this.btnsonra.Location = new System.Drawing.Point(954, 537);
            this.btnsonra.Name = "btnsonra";
            this.btnsonra.Size = new System.Drawing.Size(157, 53);
            this.btnsonra.TabIndex = 0;
            this.btnsonra.Text = "Sonraki Sonuçları Göster";
            this.btnsonra.UseVisualStyleBackColor = true;
            this.btnsonra.Visible = false;
            this.btnsonra.Click += new System.EventHandler(this.Btnsonra_Click);
            // 
            // btnonce
            // 
            this.btnonce.Location = new System.Drawing.Point(33, 537);
            this.btnonce.Name = "btnonce";
            this.btnonce.Size = new System.Drawing.Size(157, 53);
            this.btnonce.TabIndex = 1;
            this.btnonce.Text = "Önceki Sonuçları Göster";
            this.btnonce.UseVisualStyleBackColor = true;
            this.btnonce.Visible = false;
            this.btnonce.Click += new System.EventHandler(this.Btnonce_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(49, 129);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doğru Sayısı";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sorulan Soru Sayısı";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1041, 347);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // datasonuc
            // 
            this.datasonuc.AllowUserToAddRows = false;
            this.datasonuc.AllowUserToDeleteRows = false;
            this.datasonuc.AutoGenerateColumns = false;
            this.datasonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasonuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testnoDataGridViewTextBoxColumn,
            this.usluDataGridViewTextBoxColumn,
            this.mutlakDataGridViewTextBoxColumn,
            this.cebirselDataGridViewTextBoxColumn,
            this.ondalikDataGridViewTextBoxColumn,
            this.oncelikDataGridViewTextBoxColumn,
            this.bolunebilmeDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.datasonuc.DataSource = this.tblCevaplarBindingSource;
            this.datasonuc.Location = new System.Drawing.Point(1146, 70);
            this.datasonuc.Name = "datasonuc";
            this.datasonuc.ReadOnly = true;
            this.datasonuc.RowHeadersWidth = 51;
            this.datasonuc.RowTemplate.Height = 24;
            this.datasonuc.Size = new System.Drawing.Size(240, 150);
            this.datasonuc.TabIndex = 3;
            // 
            // testnoDataGridViewTextBoxColumn
            // 
            this.testnoDataGridViewTextBoxColumn.DataPropertyName = "testno";
            this.testnoDataGridViewTextBoxColumn.HeaderText = "Test No";
            this.testnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testnoDataGridViewTextBoxColumn.Name = "testnoDataGridViewTextBoxColumn";
            this.testnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.testnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usluDataGridViewTextBoxColumn
            // 
            this.usluDataGridViewTextBoxColumn.DataPropertyName = "uslu";
            this.usluDataGridViewTextBoxColumn.HeaderText = "Üslü Sayılar";
            this.usluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usluDataGridViewTextBoxColumn.Name = "usluDataGridViewTextBoxColumn";
            this.usluDataGridViewTextBoxColumn.ReadOnly = true;
            this.usluDataGridViewTextBoxColumn.Width = 125;
            // 
            // mutlakDataGridViewTextBoxColumn
            // 
            this.mutlakDataGridViewTextBoxColumn.DataPropertyName = "mutlak";
            this.mutlakDataGridViewTextBoxColumn.HeaderText = "Mutlak Değer";
            this.mutlakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mutlakDataGridViewTextBoxColumn.Name = "mutlakDataGridViewTextBoxColumn";
            this.mutlakDataGridViewTextBoxColumn.ReadOnly = true;
            this.mutlakDataGridViewTextBoxColumn.Width = 125;
            // 
            // cebirselDataGridViewTextBoxColumn
            // 
            this.cebirselDataGridViewTextBoxColumn.DataPropertyName = "cebirsel";
            this.cebirselDataGridViewTextBoxColumn.HeaderText = "Cebirsel İfadeler";
            this.cebirselDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cebirselDataGridViewTextBoxColumn.Name = "cebirselDataGridViewTextBoxColumn";
            this.cebirselDataGridViewTextBoxColumn.ReadOnly = true;
            this.cebirselDataGridViewTextBoxColumn.Width = 125;
            // 
            // ondalikDataGridViewTextBoxColumn
            // 
            this.ondalikDataGridViewTextBoxColumn.DataPropertyName = "ondalik";
            this.ondalikDataGridViewTextBoxColumn.HeaderText = "Ondalık Gösterim";
            this.ondalikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ondalikDataGridViewTextBoxColumn.Name = "ondalikDataGridViewTextBoxColumn";
            this.ondalikDataGridViewTextBoxColumn.ReadOnly = true;
            this.ondalikDataGridViewTextBoxColumn.Width = 125;
            // 
            // oncelikDataGridViewTextBoxColumn
            // 
            this.oncelikDataGridViewTextBoxColumn.DataPropertyName = "oncelik";
            this.oncelikDataGridViewTextBoxColumn.HeaderText = "İşlem Önceliği";
            this.oncelikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oncelikDataGridViewTextBoxColumn.Name = "oncelikDataGridViewTextBoxColumn";
            this.oncelikDataGridViewTextBoxColumn.ReadOnly = true;
            this.oncelikDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolunebilmeDataGridViewTextBoxColumn
            // 
            this.bolunebilmeDataGridViewTextBoxColumn.DataPropertyName = "bolunebilme";
            this.bolunebilmeDataGridViewTextBoxColumn.HeaderText = "Bölünebilme Kuralları";
            this.bolunebilmeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolunebilmeDataGridViewTextBoxColumn.Name = "bolunebilmeDataGridViewTextBoxColumn";
            this.bolunebilmeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolunebilmeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblCevaplarBindingSource
            // 
            this.tblCevaplarBindingSource.DataMember = "Tbl_Cevaplar";
            this.tblCevaplarBindingSource.DataSource = this.cevaplarDataset;
            // 
            // cevaplarDataset
            // 
            this.cevaplarDataset.DataSetName = "CevaplarDataset";
            this.cevaplarDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datakontrol
            // 
            this.datakontrol.AllowUserToAddRows = false;
            this.datakontrol.AllowUserToDeleteRows = false;
            this.datakontrol.AutoGenerateColumns = false;
            this.datakontrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testnoDataGridViewTextBoxColumn1,
            this.usluDataGridViewTextBoxColumn1,
            this.mutlakDataGridViewTextBoxColumn1,
            this.cebirselDataGridViewTextBoxColumn1,
            this.ondalikDataGridViewTextBoxColumn1,
            this.oncelikDataGridViewTextBoxColumn1,
            this.bolunebilmeDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1});
            this.datakontrol.DataSource = this.tblKontrolBindingSource;
            this.datakontrol.Location = new System.Drawing.Point(1145, 241);
            this.datakontrol.Name = "datakontrol";
            this.datakontrol.ReadOnly = true;
            this.datakontrol.RowHeadersWidth = 51;
            this.datakontrol.RowTemplate.Height = 24;
            this.datakontrol.Size = new System.Drawing.Size(240, 150);
            this.datakontrol.TabIndex = 6;
            // 
            // testnoDataGridViewTextBoxColumn1
            // 
            this.testnoDataGridViewTextBoxColumn1.DataPropertyName = "testno";
            this.testnoDataGridViewTextBoxColumn1.HeaderText = "Test No";
            this.testnoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.testnoDataGridViewTextBoxColumn1.Name = "testnoDataGridViewTextBoxColumn1";
            this.testnoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.testnoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // usluDataGridViewTextBoxColumn1
            // 
            this.usluDataGridViewTextBoxColumn1.DataPropertyName = "uslu";
            this.usluDataGridViewTextBoxColumn1.HeaderText = "Üslü Sayılar";
            this.usluDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usluDataGridViewTextBoxColumn1.Name = "usluDataGridViewTextBoxColumn1";
            this.usluDataGridViewTextBoxColumn1.ReadOnly = true;
            this.usluDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mutlakDataGridViewTextBoxColumn1
            // 
            this.mutlakDataGridViewTextBoxColumn1.DataPropertyName = "mutlak";
            this.mutlakDataGridViewTextBoxColumn1.HeaderText = "Mutlak Değer";
            this.mutlakDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mutlakDataGridViewTextBoxColumn1.Name = "mutlakDataGridViewTextBoxColumn1";
            this.mutlakDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mutlakDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cebirselDataGridViewTextBoxColumn1
            // 
            this.cebirselDataGridViewTextBoxColumn1.DataPropertyName = "cebirsel";
            this.cebirselDataGridViewTextBoxColumn1.HeaderText = "Cebirsel İfadeler";
            this.cebirselDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cebirselDataGridViewTextBoxColumn1.Name = "cebirselDataGridViewTextBoxColumn1";
            this.cebirselDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cebirselDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ondalikDataGridViewTextBoxColumn1
            // 
            this.ondalikDataGridViewTextBoxColumn1.DataPropertyName = "ondalik";
            this.ondalikDataGridViewTextBoxColumn1.HeaderText = "Ondalık Gösterimler";
            this.ondalikDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ondalikDataGridViewTextBoxColumn1.Name = "ondalikDataGridViewTextBoxColumn1";
            this.ondalikDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ondalikDataGridViewTextBoxColumn1.Width = 125;
            // 
            // oncelikDataGridViewTextBoxColumn1
            // 
            this.oncelikDataGridViewTextBoxColumn1.DataPropertyName = "oncelik";
            this.oncelikDataGridViewTextBoxColumn1.HeaderText = "İşlem Önceliği";
            this.oncelikDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.oncelikDataGridViewTextBoxColumn1.Name = "oncelikDataGridViewTextBoxColumn1";
            this.oncelikDataGridViewTextBoxColumn1.ReadOnly = true;
            this.oncelikDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bolunebilmeDataGridViewTextBoxColumn1
            // 
            this.bolunebilmeDataGridViewTextBoxColumn1.DataPropertyName = "bolunebilme";
            this.bolunebilmeDataGridViewTextBoxColumn1.HeaderText = "Bölünebilme Kuralları";
            this.bolunebilmeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bolunebilmeDataGridViewTextBoxColumn1.Name = "bolunebilmeDataGridViewTextBoxColumn1";
            this.bolunebilmeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bolunebilmeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            this.tarihDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tblKontrolBindingSource
            // 
            this.tblKontrolBindingSource.DataMember = "Tbl_Kontrol";
            this.tblKontrolBindingSource.DataSource = this.kontrolDataset;
            // 
            // kontrolDataset
            // 
            this.kontrolDataset.DataSetName = "KontrolDataset";
            this.kontrolDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CevaplarTableAdapter
            // 
            this.tbl_CevaplarTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_KontrolTableAdapter
            // 
            this.tbl_KontrolTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Test Doğru-Yanlış Sayısı",
            "Konu Doğru-Yanlış Sayısı"});
            this.comboBox1.Location = new System.Drawing.Point(428, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltest.Location = new System.Drawing.Point(531, 555);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(86, 25);
            this.lbltest.TabIndex = 8;
            this.lbltest.Text = "Test No";
            this.lbltest.Visible = false;
            // 
            // tblDogruBindingSource
            // 
            this.tblDogruBindingSource.DataMember = "Tbl_Dogru";
            this.tblDogruBindingSource.DataSource = this.datasetdoğru;
            // 
            // datasetdoğru
            // 
            this.datasetdoğru.DataSetName = "datasetdoğru";
            this.datasetdoğru.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DogruTableAdapter
            // 
            this.tbl_DogruTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 100);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1056, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(341, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aşağıdan hangisini görmek istediğnizi seçin";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.tblDogruBindingSource1;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(49, 129);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "testno";
            series3.YValueMembers = "dogru";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1041, 347);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // dogruSayisiDataset
            // 
            this.dogruSayisiDataset.DataSetName = "DogruSayisiDataset";
            this.dogruSayisiDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDogruBindingSource1
            // 
            this.tblDogruBindingSource1.DataMember = "Tbl_Dogru";
            this.tblDogruBindingSource1.DataSource = this.dogruSayisiDataset;
            // 
            // tbl_DogruTableAdapter1
            // 
            this.tbl_DogruTableAdapter1.ClearBeforeFill = true;
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 602);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.datakontrol);
            this.Controls.Add(this.datasonuc);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnonce);
            this.Controls.Add(this.btnsonra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Istatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCevaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cevaplarDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKontrolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrolDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetdoğru)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogruSayisiDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogruBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsonra;
        private System.Windows.Forms.Button btnonce;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView datasonuc;
        private System.Windows.Forms.DataGridView datakontrol;
        private CevaplarDataset cevaplarDataset;
        private System.Windows.Forms.BindingSource tblCevaplarBindingSource;
        private CevaplarDatasetTableAdapters.Tbl_CevaplarTableAdapter tbl_CevaplarTableAdapter;
        private KontrolDataset kontrolDataset;
        private System.Windows.Forms.BindingSource tblKontrolBindingSource;
        private KontrolDatasetTableAdapters.Tbl_KontrolTableAdapter tbl_KontrolTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbltest;
        private datasetdoğru datasetdoğru;
        private System.Windows.Forms.BindingSource tblDogruBindingSource;
        private datasetdoğruTableAdapters.Tbl_DogruTableAdapter tbl_DogruTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn testnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutlakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cebirselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ondalikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncelikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolunebilmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usluDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutlakDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cebirselDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ondalikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncelikDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolunebilmeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private DogruSayisiDataset dogruSayisiDataset;
        private System.Windows.Forms.BindingSource tblDogruBindingSource1;
        private DogruSayisiDatasetTableAdapters.Tbl_DogruTableAdapter tbl_DogruTableAdapter1;
    }
}