using KuzeyYeliEntity;
using KuzeyYeliORM;
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

namespace KuzeyYeliForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Urunler.listele();

            CMBKategoriler.DataSource = Kategoriler.listele();
            CMBKategoriler.DisplayMember = "KategoriAdi";
            CMBKategoriler.ValueMember = "KategoriID";

            CMBTedarikçiler.DataSource = Tedarikciler.listele();
            CMBTedarikçiler.DisplayMember = "SirketAdi";
            CMBTedarikçiler.ValueMember = "TedarikciID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KategoriForm K = new KategoriForm();
            K.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun U = new Urun();
            U.UrunAdi = textBox1.Text;
            U.Stok = (int)numericUpDown2.Value;
            U.Fiyat = numericUpDown1.Value;
            U.KategoriID = (int)CMBKategoriler.SelectedValue;
            U.TedarikciID = (int)CMBTedarikçiler.SelectedValue;
            bool sonuc = Urunler.Ekle(U);
            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi");
                dataGridView1.DataSource = Urunler.listele();

            }
            else
            {
                MessageBox.Show("Kayıt eklenirken hata oluştu!!");
            }
          
                
        }
    }
}
