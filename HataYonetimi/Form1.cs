using System;
using System.Windows.Forms;

namespace HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, System.EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
        }

        private void btnOrnek2_Click(object sender, System.EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
            }
        }

        private void btnOrnek3_Click(object sender, System.EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrnek4_Click(object sender, System.EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch (DivideByZeroException ex) // sıfıra bölünme hatası
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex) // geçersiz format 
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException ex) //aşırı yüklenme hatası
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) // genel hatalar
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Tebrikler telefon numarasını düzgün girdiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Her durumda çalışırım bölümü");
            }
        }
    }
}
