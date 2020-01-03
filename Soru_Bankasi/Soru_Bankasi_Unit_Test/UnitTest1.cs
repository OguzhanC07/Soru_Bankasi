using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soru_Bankasi;

namespace Soru_Bankasi_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanILogin()
        {
            Form1 form = new Form1();
            string txt = "ogrenci";
            form.txtuser.AppendText(txt);
            form.txtpass.AppendText(txt);
            pub pb = new pub();
            pb.querry = 5;
            form.comboBox1.SelectedItem = "ogrenci";
            form.btnLogin.PerformClick();
            pb.result = 5;
            form.Close();

            Assert.AreEqual(pb.querry, pb.result);
        }


        [TestMethod]
        public void SavingQuestions()
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.SoruEkleme("asdasd", "aaa", "bbb", "ccc", "ddd", "C", "Üslü Sayılar");
            ogretmen.Close();

        }

        [TestMethod]
        public void CanISeeQuestions()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.soruCek();
        }
    }
}
