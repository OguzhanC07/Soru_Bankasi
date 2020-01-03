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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*DESIGN KODLARIDIR ELLEMEYİNİZ.*/
            panel2.BackColor = Color.FromArgb(142, 68, 173);
            panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;


            txtuser.BackColor = Color.FromArgb(149, 165, 166);
            txtpass.BackColor = Color.FromArgb(149, 165, 166);
            comboBox1.BackColor = Color.FromArgb(149, 165, 166);

            txtuser.ForeColor = Color.FromArgb(255, 255, 255);
            txtpass.ForeColor = Color.FromArgb(255, 255, 255);
            comboBox1.ForeColor = Color.FromArgb(255, 255, 255);


            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.BackColor = Color.FromArgb(46, 204, 113);
            btnLogin.FlatAppearance.BorderColor = Color.White;


            txtpass.UseSystemPasswordChar = true;
            /*DESIGN KODLARIDIR ELLEMEYİNİZ.*/
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OğuzhanCan;Initial Catalog=SoruBankasi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from login where username='" + txtuser.Text + "' and password='" + txtpass.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = "";
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Giriş Türünü Seçiniz.", "Hata");
            }
            else
            {
                cmbItemValue = comboBox1.SelectedItem.ToString();
            }

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show(dt.Rows[i][2] + " olarak giriş yapıyorsunuz.", "Uyarı");
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Ogrenci o = new Ogrenci();
                            this.Hide();
                            o.Show();
                        }
                        if (comboBox1.SelectedIndex == 1)
                        {
                            Ogretmen ot = new Ogretmen();
                            this.Hide();
                            ot.Show();
                        }
                    }
                    if (dt.Rows[i]["usertype"].ToString() != cmbItemValue)
                    {
                        MessageBox.Show("Yanlış seçim yaptınız! Lütfen tekrar deneyiniz", "Hata");
                    }

                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata");
            }
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
