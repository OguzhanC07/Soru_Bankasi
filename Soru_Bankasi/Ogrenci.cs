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

namespace Soru_Bankasi
{
    public partial class Ogrenci : Form
    {
        static int nowquest = 1;
        public static int doru = 0;
        public static int yanlis = 0;
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < datasonuc.Columns.Count; i++)
            {
                datasonuc.Rows[0].Cells[i].Value = 0;
                datakontrol.Rows[0].Cells[i].Value = 0;
            }
            /*DESIGN KODLARIDIR LÜTFEN ELLEMEYİNİZ*/
            panel1.BackColor = Color.FromArgb(45, 52, 54);
            panel2.BackColor = Color.FromArgb(99, 110, 114);
            txtboxsoru.BackColor = Color.FromArgb(99, 110, 114);
            btnbasla.BackColor = Color.FromArgb(85, 239, 196);
            btnistatistik.BackColor = Color.FromArgb(223, 230, 233);
            btnnext.BackColor = Color.FromArgb(9, 132, 227);
            btnnext.Enabled = false;
            /*DESIGN KODLARIDIR LÜTFEN ELLEMEYİNİZ*/
        }

        private void Btnbasla_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Testiniz başlayacktır. Emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == dlg)
            {
                txtboxsoru.Visible = true;
                radioa.Visible = true;
                radiob.Visible = true;
                radioc.Visible = true;
                radiod.Visible = true;
                btnnext.Visible = true;
                btnistatistik.Enabled = false;
                btnbasla.Enabled = false;
                soruCek();
            }
        }

        private void Radioa_CheckedChanged(object sender, EventArgs e)
        {
            lblselected.Text = "A";
            btnnext.Enabled = true;
        }

        private void Radiob_CheckedChanged(object sender, EventArgs e)
        {
            lblselected.Text = "B";
            btnnext.Enabled = true;
        }

        private void Radioc_CheckedChanged(object sender, EventArgs e)
        {
            lblselected.Text = "C";
            btnnext.Enabled = true;
        }

        private void Radiod_CheckedChanged(object sender, EventArgs e)
        {
            lblselected.Text = "D";
            btnnext.Enabled = true;
        }

        private void Btnnext_Click(object sender, EventArgs e)
        {
            SoruKaydet();
            soruCek();
        }

        private void Btnistatistik_Click(object sender, EventArgs e)
        {
            Istatistik i = new Istatistik();
            i.Show();
        }

        public void radioFalse() //radiobuttonları kapatma
        {
            radioa.Checked = false;
            radiob.Checked = false;
            radioc.Checked = false;
            radiod.Checked = false;
            btnnext.Enabled = false;
        }

        public void soruCek() //Soruları database'den çekme  >>>>>>>>>>>>>>>>BURAYA YENİDEN BAKILACAK.<<<<<<<<<<<<<<<<<<
        {
            btnnext.Enabled = false;
            if (nowquest < 31) 
            {
                //HER KONUDAN 5 SORU SORULMALI EĞER BİLEMEZSE O KONUDAN DAHA FAZLA SORU GELECEK.
                SqlConnection baglanti = new SqlConnection(@"Data Source=OĞUZHANCAN;Initial Catalog=SoruBankasi;Integrated Security=True");
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Select * from Tbl_Sorular where soruno ='" + nowquest.ToString() + "'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                /*if(lblkonu.Text==dr["konu"].ToString()(database'deki konu kontrol edilecek.) && (burda doğru sayısı yine database'den kontrol edilecek.) dogrusayisi>=2)* konu bitmiş olabilir.
                {
                    nowquest++;
                }*/
                if (dr.Read())
                {
                    txtboxsoru.Text = dr["soru"].ToString();
                    radioa.Text = "A) " + dr["asikki"].ToString();
                    radiob.Text = "B) " + dr["bsikki"].ToString();
                    radioc.Text = "C) " + dr["csikki"].ToString();
                    radiod.Text = "D) " + dr["dsikki"].ToString();
                    lbltrue.Text = dr["cevap"].ToString();
                    lblkonu.Text = dr["konu"].ToString();
                }
                else
                {
                    txtboxsoru.Text = "veri cekilemedi";
                }
                nowquest++;
                baglanti.Dispose();
                baglanti.Close();
                radioFalse();
            }
            else
            {
                QuestionSaving();
                MessageBox.Show("Sorular bitti! Sonuçlar: doğru sayısı " + doru + "\n yanlış sayısı: " + yanlis);
                radioFalse();
                TrueFalseSaving();
                btnnext.Enabled = false;
                btnistatistik.Enabled = true;
                btnbasla.Enabled = false;
                doru = 0;
                yanlis = 0;
            }

        }

        public void SoruKaydet() //Soruyu Datagridview'a Kaydetme
        {
            //HER KONUDAN 5 SORU SORULMALI EĞER BİLEMEZSE O KONUDAN DAHA FAZLA SORU GELECEK
            int i = 0, k = 0;

            for (int a = 1; a < datasonuc.Columns.Count - 1 /*eski hali 4*/ ; a++)
            {
                if (lblkonu.Text == datakontrol.Columns[a].HeaderText.ToString()) //konu ile colum headertext'i birbirine uyumluysa gridview a işlem yapıyor
                {
                    lbltest2.Text = datakontrol.Rows[0].Cells[a].Value.ToString();
                    k = Convert.ToInt32(lbltest2.Text);
                    k++;
                    datakontrol.Rows[0].Cells[a].Value = k;

                    if (lblselected.Text == lbltrue.Text)//soruyu doğru çözmüşse buda sonuç a ekleniyor
                    {
                        lbltest.Text = datasonuc.Rows[0].Cells[a].Value.ToString();
                        i = Convert.ToInt32(lbltest.Text);
                        i++;
                        datasonuc.Rows[0].Cells[a].Value = i;
                        doru++;
                    }
                    else
                    {
                        yanlis++;
                    }
                }
            }
        }

        public void QuestionSaving() //Sql Kaydetme İşlemleri 
        {
            DateTime datetimevariable = DateTime.Now; //Tarih Alma
            //datagridview daki veriyi sql e aktarma..
            //<<<<<<<<<<<<<<<<<<<<<BURAYA KONULAR EKLENECEK>>>>>>>>>>>>>>>>><
            SqlConnection cnn = new SqlConnection(@"Data Source = OĞUZHANCAN; Initial Catalog = SoruBankasi; Integrated Security = True");
            SqlCommand mmd = new SqlCommand("insert into Tbl_Cevaplar (uslu,mutlak,cebirsel,ondalik,oncelik,bolunebilme,tarih) values (@us,@mut,@cebir,@onda,@once,@bol,@date)", cnn);
            cnn.Open();
            mmd.Parameters.AddWithValue("@us", datasonuc.Rows[0].Cells[1].Value);
            mmd.Parameters.AddWithValue("@mut", datasonuc.Rows[0].Cells[2].Value);
            mmd.Parameters.AddWithValue("@cebir", datasonuc.Rows[0].Cells[3].Value);
            mmd.Parameters.AddWithValue("@onda", datasonuc.Rows[0].Cells[4].Value);
            mmd.Parameters.AddWithValue("@once", datasonuc.Rows[0].Cells[5].Value);
            mmd.Parameters.AddWithValue("@bol", datasonuc.Rows[0].Cells[6].Value);
            mmd.Parameters.AddWithValue("@date", datetimevariable);
            mmd.ExecuteNonQuery();
            cnn.Close();
            //<<<<<<<<<<<<<<<<<<<<<BURAYA KONULAR EKLENECEK>>>>>>>>>>>>>>>>><

            SqlConnection cnn2 = new SqlConnection(@"Data Source=OĞUZHANCAN;Initial Catalog=SoruBankasi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Tbl_Kontrol (uslu,mutlak,cebirsel,ondalik,oncelik,bolunebilme,tarih) values (@us,@mut,@cebir,@onda,@once,@bol,@date)", cnn2);
            cnn2.Open();
            cmd.Parameters.AddWithValue("@us", datakontrol.Rows[0].Cells[1].Value);
            cmd.Parameters.AddWithValue("@mut", datakontrol.Rows[0].Cells[2].Value);
            cmd.Parameters.AddWithValue("@cebir", datakontrol.Rows[0].Cells[3].Value);
            cmd.Parameters.AddWithValue("@onda", datakontrol.Rows[0].Cells[4].Value);
            cmd.Parameters.AddWithValue("@once", datakontrol.Rows[0].Cells[5].Value);
            cmd.Parameters.AddWithValue("@bol", datakontrol.Rows[0].Cells[6].Value);
            cmd.Parameters.AddWithValue("@date", datetimevariable);
            cmd.ExecuteNonQuery();
            cnn2.Close();

            //<<<<<<<<<<<<<<<<<<<<<BURAYA KONULAR EKLENECEK>>>>>>>>>>>>>>>>><
        }


        public void TrueFalseSaving() // doğru yanlış sayısını sql'e kaydetme
        {
            SqlConnection conn = new SqlConnection(@"Data Source=OĞUZHANCAN;Initial Catalog=SoruBankasi;Integrated Security=True");
            conn.Open();
            SqlCommand kommand = new SqlCommand("insert into Tbl_Dogru (dogru,yanlis) values (@dogru,@yanlis)", conn);
            kommand.Parameters.AddWithValue("@dogru", doru.ToString());
            kommand.Parameters.AddWithValue("@yanlis", yanlis.ToString());
            kommand.ExecuteNonQuery();
            conn.Close();

        }

        private void Txtboxsoru_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
