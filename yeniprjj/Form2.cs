using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace yeniprjj
{
    public partial class Form2 : Form
    {
        int tahminEdilecekSayi = 0;
        int hamleSayisi = 10;
        int denemesayi = 10;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

                Random rnd = new Random();
            tahminEdilecekSayi = rnd.Next(1000, 9999);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tahmin = txtTahmin.Text;
            int x = int.Parse(tahmin);
            try
            {
                int sayı = int.Parse(txtTahmin.Text);
            }
            catch
            {
                MessageBox.Show("harf girilemez");
                return;
            }

            if (string.IsNullOrEmpty(tahmin))
            {
                MessageBox.Show("boş bırakılamaz");
                return;
            }
            else if (tahmin.Length != 4)
            {
                MessageBox.Show("4 basamaklı bir sayı gir!");
                return;
            }

            else if (tahmin[0] == '0')
            {
                MessageBox.Show("0 ile başlayamaz!");
                return;
            }

            denemesayi = denemesayi - 1; ;
            label1.Text = denemesayi.ToString();
            if (denemesayi <= 0)
            {
                button1.Enabled = false;
                // button1.Visible = false;
            }
            /*
            int fark = tahminEdilecekSayi - x;

            
            string m = fark switch
            {
                0 => "Tebrikler, bildiniz! ",
                > 0 and <= 15 => "Yukarı! Neredeyse bildin ",
                < 0 and >= -15 => "Aşağı! Neredeyse bildin ",
                > 15 and <= 60 => "Yukarı! Çok yaklaştın ",
                < -15 and >= -60 => "Aşağı! Çok yaklaştın ",
                > 60 and <= 200 => "Yukarı! Yaklaştın ",
                < -60 and >= -200 => "Aşağı! Yaklaştın ",
                > 200 => "Yukarı! Çok uzaksın ",
                _ => "Aşağı! Çok uzaksın " 
            };

            lstSonuclar.Items.Add(m);

            lstSonuclar.Items.Add($"{hamleSayisi}.Tahmin: {string.Join("", tahmin)}");
            
            txtTahmin.Clear();
            */


            int fark = tahminEdilecekSayi - x;

            string m = fark switch
            {
                0 => "Tebrikler, bildin",

                > 0 and <= 20 => "Yukarı! Neredeyse bildin ",
                < 0 and >= -20 => "Aşağı! Neredeyse bildin ",

                > 20 and <= 40 => "Yukarı! Çok yaklaştın ",
                < -20 and >= -40 => "Aşağı! Çok yaklaştın ",

                > 40 and <= 60 => "Yukarı! Yaklaştın ",
                < -40 and >= -60 => "Aşağı! Yaklaştın ",

                > 60 and <= 80 => "Yukarı! Biraz yaklaştın ",
                < -60 and >= -80 => "Aşağı! Biraz yaklaştın ",

                > 80 and <= 100 => "Yukarı! Uzak değilsin ",
                < -80 and >= -100 => "Aşağı! Uzak değilsin ",

                > 100 and <= 150 => "Yukarı! Uzaksın ",
                < -100 and >= -150 => "Aşağı! Uzaksın ",

                > 150 and <= 200 => "Yukarı! Çok uzaksın ",
                < -150 and >= -200 => "Aşağı! Çok uzaksın ",

                > 200 => "Yukarı! Bayağı uzaksınız ",
                _ => "Aşağı! Bayağı uzaksınız"
            };

                txtTahmin.Clear();


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstSonuclar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
