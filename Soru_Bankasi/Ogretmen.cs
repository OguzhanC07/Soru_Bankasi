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
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=OğuzhanCan;Initial Catalog=SoruBankasi;Integrated Security=True");
        private void Cmbsecim_TextChanged(object sender, EventArgs e)
        {
            if (Cmbsecim.Text == "Soru Yaz")
            {
                Temizle();
                boxsoruekleme.Visible = true;
                boxsoruliste.Visible = false;
                Btnsoruguncel.Visible = false;
                Btnsorusil.Visible = false;
                Btnsorusil.Visible = false;
                Btnsoruekleme.Visible = true;
                txtboxsoru.Enabled = true;
                txtboxasikki.Enabled = true;
                txtboxbsikki.Enabled = true;
                txtboxcsikki.Enabled = true;
                txtboxdsikki.Enabled = true;
                cmbkonu.Enabled = true;
                cmbsiklar.Enabled = true;
            }
            if (Cmbsecim.Text == "Soru Düzenle")
            {
                Temizle();
                boxsoruekleme.Visible = true;
                boxsoruliste.Visible = true;
                Btnsoruguncel.Visible = true;
                Btnsorusil.Visible = false;
                Btnsoruekleme.Visible = false;
                txtboxsoru.Enabled = true;
                txtboxasikki.Enabled = true;
                txtboxbsikki.Enabled = true;
                txtboxcsikki.Enabled = true;
                txtboxdsikki.Enabled = true;
                cmbkonu.Enabled = true;
                cmbsiklar.Enabled = true;
            }

            if (Cmbsecim.Text == "Soru Sil")
            {
                Temizle();
                boxsoruekleme.Visible = true;
                boxsoruliste.Visible = true;
                Btnsoruguncel.Visible = false;
                Btnsoruekleme.Visible = false;
                Btnsorusil.Visible = true;
                txtboxsoru.Enabled = false;
                txtboxasikki.Enabled = false;
                txtboxbsikki.Enabled = false;
                txtboxcsikki.Enabled = false;
                txtboxdsikki.Enabled = false;
                cmbkonu.Enabled = false;
                cmbsiklar.Enabled = false;
                txtboxsoru.BackColor = Color.Black;
            }
        }

        private void Ogretmen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soruListelemeDataset.Tbl_Sorular' table. You can move, or remove it, as needed.
            this.tbl_SorularTableAdapter.Fill(this.soruListelemeDataset.Tbl_Sorular);
            boxsoruliste.Visible = false;
            boxsoruekleme.Visible = false;



            /*DESIGN KODLARIDIR ELLEMEYİNİZ.*/
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            txtboxsoru.BackColor = Color.FromArgb(149, 165, 166);
            txtboxsoru.ForeColor = Color.FromArgb(255, 255, 255);

            txtboxasikki.BackColor = Color.FromArgb(149, 165, 166);
            txtboxasikki.ForeColor = Color.FromArgb(255, 255, 255);

            txtboxbsikki.BackColor = Color.FromArgb(149, 165, 166);
            txtboxbsikki.ForeColor = Color.FromArgb(255, 255, 255);

            txtboxcsikki.BackColor = Color.FromArgb(149, 165, 166);
            txtboxcsikki.ForeColor = Color.FromArgb(255, 255, 255);

            txtboxdsikki.BackColor = Color.FromArgb(149, 165, 166);
            txtboxdsikki.ForeColor = Color.FromArgb(255, 255, 255);

            cmbkonu.BackColor = Color.FromArgb(149, 165, 166);
            cmbkonu.ForeColor = Color.FromArgb(255, 255, 255);

            cmbsiklar.BackColor = Color.FromArgb(149, 155, 166);
            cmbsiklar.ForeColor = Color.FromArgb(255,255,255);

            Cmbsecim.BackColor = Color.FromArgb(149, 155, 166);
            Cmbsecim.ForeColor = Color.FromArgb(255, 255, 255);




            panel1.BackColor = Color.FromArgb(34, 167, 240);
            panel2.BackColor = Color.FromArgb(34, 49, 63);



            Btnsoruekleme.BackColor = Color.FromArgb(46, 204, 113);
            Btnsoruguncel.BackColor = Color.FromArgb(52, 152, 219);
            Btnsorusil.BackColor = Color.FromArgb(231, 76, 60);
            /*DESIGN KODLARIDIR ELLEMEYİNİZ.*/


        }

        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRIDVİEW'DAKİ VERİYE ÇİFT TIKLANDIĞINDA BURAYA YAZDIRACAK
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            lblsoruno.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            txtboxsoru.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            txtboxasikki.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            txtboxbsikki.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            txtboxcsikki.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            txtboxdsikki.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            cmbsiklar.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            cmbkonu.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void Btnsoruekleme_Click(object sender, EventArgs e)
        {
            if (txtboxsoru.Text == "" || txtboxasikki.Text == "" || txtboxbsikki.Text == "" || txtboxcsikki.Text == "" || txtboxdsikki.Text == "" || cmbkonu.Text == "" || cmbsiklar.Text == "")
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız.", "Hata");
            }
            else
            {
                SoruEkleme(txtboxsoru.Text, txtboxasikki.Text, txtboxbsikki.Text, txtboxcsikki.Text, txtboxdsikki.Text, cmbsiklar.SelectedItem.ToString(), cmbkonu.SelectedItem.ToString());
            }
        }

        private void Btnsoruguncel_Click(object sender, EventArgs e)
        {
            SoruGuncelle();
        }

        private void Btnsorusil_Click(object sender, EventArgs e)
        {
            SoruSil();
        }






        //TÜM FONKSİYONLAR BURADA
        //SORU EKLEME FONKSİYONU
        public void SoruEkleme(string soru, string a, string b, string c, string d, string cevap, string konu)
        {
            DialogResult dlg = MessageBox.Show("Yeni soru kayıdı yapılacaktır. Emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlg == DialogResult.Yes)
            {
                //DIŞARIDAN PARAMETRE İLE GELEN BİLGİLERİ VERİTABANINA KAYDETME
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Tbl_Sorular (soru,asikki,bsikki,csikki,dsikki,cevap,konu) values (@soru,@a,@b,@c,@d,@cevap,@konu)", cn);
                cmd.Parameters.AddWithValue("@soru", soru);
                cmd.Parameters.AddWithValue("@a", a);
                cmd.Parameters.AddWithValue("@b", b);
                cmd.Parameters.AddWithValue("@c", c);
                cmd.Parameters.AddWithValue("@d", d);
                cmd.Parameters.AddWithValue("@cevap", cevap);
                cmd.Parameters.AddWithValue("@konu", konu);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Soru Eklendi", "Bilgilendirme Penceresi");
                Temizle();
                cn.Close();
            }
        }


        public void SoruSil()
        {
            if (lblsoruno.Text =="lblsoruno" || txtboxsoru.Text == "" || txtboxasikki.Text == "" || txtboxbsikki.Text == "" || txtboxcsikki.Text == "" || txtboxdsikki.Text == "" || cmbkonu.Text == "" || cmbsiklar.Text == "")
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız.", "Hata");
            }
            else
            {
                DialogResult dlg = MessageBox.Show(lblsoruno.Text + " numaralı soru silinecektir. Emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dlg == DialogResult.Yes)
                {

                    //DATAGRIDVİEW'DAN SEÇİLEN SORUYU VERİTABANINDAN SİLME İŞLEMİ
                    cn.Open();
                    SqlCommand cmddel = new SqlCommand("Delete From Tbl_Sorular Where soruno=@k1", cn);
                    cmddel.Parameters.AddWithValue("@k1", lblsoruno.Text);
                    cmddel.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Kayit silindi!", "Bilgilendirme Penceresi");
                    Temizle();
                }
            }
        }


        public void SoruGuncelle()
        {
            if (lblsoruno.Text =="lblsoruno" || txtboxsoru.Text == "" || txtboxasikki.Text == "" || txtboxbsikki.Text == "" || txtboxcsikki.Text == "" || txtboxdsikki.Text == "" || cmbkonu.Text == "" || cmbsiklar.Text == "")
            {
                MessageBox.Show("Lütfen yan taraftan soruyu seçiniz ve boş yer bırakmayınız.", "Hata");
            }
            else
            {
                DialogResult dlg = MessageBox.Show(lblsoruno.Text + " numaralı soru güncellenecektir. Emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlg == DialogResult.Yes)
                {

                    //DATAGRIDVIEWDAN SEÇİLEN BİR SORUNUN GÜNCELLENMESİ NOT:SORUNO'YA GÖRE YAPILIYOR.
                    cn.Open();
                    SqlCommand cmdupd = new SqlCommand("Update Tbl_Sorular Set soru=@soru,asikki=@a,bsikki=@b,csikki=@c,dsikki=@d,cevap=@cevap,konu=@konu where soruno=@no", cn);
                    cmdupd.Parameters.AddWithValue("@no", lblsoruno.Text);
                    cmdupd.Parameters.AddWithValue("@soru", txtboxsoru.Text);
                    cmdupd.Parameters.AddWithValue("@a", txtboxasikki.Text);
                    cmdupd.Parameters.AddWithValue("@b", txtboxbsikki.Text);
                    cmdupd.Parameters.AddWithValue("@c", txtboxcsikki.Text);
                    cmdupd.Parameters.AddWithValue("@d", txtboxdsikki.Text);
                    cmdupd.Parameters.AddWithValue("@cevap", cmbsiklar.Text);
                    cmdupd.Parameters.AddWithValue("@konu", cmbkonu.Text);
                    cmdupd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Güncellendi.", "Bilgilendirme Penceresi");
                    Temizle();
                }
            }
        }

        public void Temizle()
        {
            //HERŞEYİ TEMİZLEYEN FONKSIYON.
            lblsoruno.Text = "lblsoruno";
            txtboxsoru.Text = "";
            txtboxasikki.Text = "";
            txtboxbsikki.Text = "";
            txtboxcsikki.Text = "";
            txtboxdsikki.Text = "";
            cmbkonu.SelectedIndex = -1;
            cmbsiklar.SelectedIndex = -1;
            this.tbl_SorularTableAdapter.Fill(this.soruListelemeDataset.Tbl_Sorular);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
