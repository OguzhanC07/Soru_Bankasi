using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_Bankasi
{
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }

        static int selected = 0;

        private void Istatistik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dogruSayisiDataset.Tbl_Dogru' table. You can move, or remove it, as needed.
            this.tbl_DogruTableAdapter1.Fill(this.dogruSayisiDataset.Tbl_Dogru);
            // TODO: This line of code loads data into the 'datasetdoğru.Tbl_Dogru' table. You can move, or remove it, as needed.
            this.tbl_DogruTableAdapter.Fill(this.datasetdoğru.Tbl_Dogru);
            // TODO: This line of code loads data into the 'kontrolDataset.Tbl_Kontrol' table. You can move, or remove it, as needed.
            this.tbl_KontrolTableAdapter.Fill(this.kontrolDataset.Tbl_Kontrol);
            // TODO: This line of code loads data into the 'cevaplarDataset.Tbl_Cevaplar' table. You can move, or remove it, as needed.
            this.tbl_CevaplarTableAdapter.Fill(this.cevaplarDataset.Tbl_Cevaplar);
            btnonce.Enabled = false;
            //lbldoru.Visible = false;
            //lbltestsonuc.Visible = false;

            /*DESIGN KODLARIDIR. LÜTFEN ELLEMEYİNİZ.*/
            panel1.BackColor = Color.FromArgb(126, 255, 245);
            btnonce.BackColor = Color.FromArgb(23, 192, 235);
            btnsonra.BackColor = Color.FromArgb(50, 255, 126);

            /*DESIGN KODLARIDIR. LÜTFEN ELLEMEYİNİZ.*/
        }

        private void Btnonce_Click(object sender, EventArgs e)
        {
            selected--;
            Testistatistik();
            int a = selected;
            a++;
            lbltest.Text ="Test No: "+ a.ToString();
        }

        private void Btnsonra_Click(object sender, EventArgs e)
        {
            btnonce.Enabled = true;
            selected++;
            Testistatistik();
            int a = selected;
            a++;
            lbltest.Text = "Test No: "+a.ToString();
        }

        public void CheckButtons()
        {
            if (selected == 0)
            {
                btnonce.Enabled = false;
            }
            else
            {
                btnonce.Enabled = true;
            }
            if (selected + 1 == datasonuc.Rows.Count)
            {
                btnsonra.Enabled = false;
            }
            else
            {
                btnsonra.Enabled = true;
            }

        }

        public void Testistatistik() 
        {
            CheckButtons();
            foreach (var series in chart1.Series) // YENİ GELECEK KAYIT İÇİN TEMİZLEME İŞLEMİ YAPILMASI
            {
                series.Points.Clear();
            }
            
            
            if (datasonuc.Rows.Count <=1) //SONUÇLARI GÖSTERMEK İÇİN EN AZ 2 KAYIT GEREKMEKTEDİR. AKSİ HALDE GÖSTERİM YAPMIYOR.
            {
                MessageBox.Show("En az 2 kayıt gereklidir.");
                selected = 0;
                btnsonra.Enabled = false;
                btnonce.Enabled = false;
            }
            else
            {
                int b =0;    //BURASI İSE ASIL KISIMDIR. BURADA KAYITLARA TEK TEK BAKARAK YAZDIRMA İŞLEMİ GERÇEKLEŞİR.
                for (int i = 1; i < datasonuc.Columns.Count - 1; i++)
                {
                    b++;
                    string temp2 = datasonuc.Columns[i].HeaderText.ToString();
                    chart1.Series[0].Points.AddXY(temp2, datasonuc.Rows[selected].Cells[b].Value);
                    chart1.Series[1].Points.AddY(datakontrol.Rows[selected].Cells[b].Value);
                }
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text== "Test Doğru-Yanlış Sayısı")
            {
                chart2.Visible = true;
                chart1.Visible = false;
                btnonce.Visible = false;
                btnsonra.Visible = false;
                //lbldoru.Visible = true;
                //lbltestsonuc.Visible = true;
                lbltest.Visible = false;
            }
            if(comboBox1.Text== "Konu Doğru-Yanlış Sayısı")
            {
                chart1.Visible = true;
                chart2.Visible = false;
                btnsonra.Visible = true;
                btnonce.Visible = true;
                //lbldoru.Visible = false;
                //lbltestsonuc.Visible = false;
                lbltest.Visible = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
