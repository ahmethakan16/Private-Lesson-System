using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Etüt_Ders_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RVCRK4G\\SQLEXPRESS;Initial Catalog=EtütDersSistemi;Integrated Security=True");

        bool durum;

        private void Form1_Load(object sender, EventArgs e)
        {
            ogretmenders();
            derslistesi();
            etutlistele();
        }

        public void derslistesi()
        {
            //Combobox'a Dersleri Çekme
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", baglanti);
            SqlDataAdapter dt= new SqlDataAdapter(komut);
            DataTable da = new DataTable();
            dt.Fill(da);
            comboBoxDers.ValueMember = "DERSID";
            comboBoxDers.DisplayMember = "DERSAD";
            comboBoxDers.DataSource = da;


        }

        private void comboBoxDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter dt2 = new SqlDataAdapter("Select OGRETMENID, (OGRETMENAD+' '+OGRETMENSOYAD) as 'OGRETMEN' from Tbl_Ogretmen where BRANSID=" + comboBoxDers.SelectedValue, baglanti);
            DataTable da2= new DataTable(); 
            dt2.Fill(da2);
            comboBoxOgretmen.ValueMember = "OGRETMENID";
            comboBoxOgretmen.DisplayMember = "OGRETMEN";
            comboBoxOgretmen.DataSource= da2;
        }

        private void buttonEtutOlustur_Click(object sender, EventArgs e)
        {
            DialogResult etut = new DialogResult();
            etut= MessageBox.Show("Etüt Oluşturulsun Mu?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);  
            if(etut==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Tbl_Etüt(DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", comboBoxDers.SelectedValue);
                komut.Parameters.AddWithValue("@p2", comboBoxOgretmen.SelectedValue);
                komut.Parameters.AddWithValue("@p3", maskedTextBoxTarih.Text);
                komut.Parameters.AddWithValue("@p4", maskedTextBoxSaat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Etüt Oluşturulmadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       public void etutlistele()
       {
           SqlDataAdapter da = new SqlDataAdapter("EXECUTE etut", baglanti);
           DataTable dt = new DataTable();
           da.Fill(dt);
          dataGridView1.DataSource= dt;
            //DataGridView'e Duruma Göre Renk Verme;
            for(int i=0; i<dataGridView1.Rows.Count -1 ; i++) 
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value) == true)
                {
                    renk.BackColor = Color.Red;
                }
                else
                {
                    renk.BackColor = Color.Green;
                }
                dataGridView1.Rows[i].DefaultCellStyle= renk;
            }
       }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void buttonEtutVer_Click(object sender, EventArgs e)
        {

            DialogResult ett = new DialogResult();
            ett= MessageBox.Show("Etüt Öğrenciye Verilsin Mi?","Onay",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ett == DialogResult.Yes )
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Update Tbl_Etüt set OGRENCIID=@p1, DURUM=@p2 where ID=@p3", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", "True");
                komut.Parameters.AddWithValue("@p3", textBox2.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Etüt Öğrenciye Verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Etüt Öğrenciye Verilemedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
    
            
        }

        private void buttonFotografYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        public void ogrenciekle()
        {
            DialogResult ogrenci = new DialogResult();
            ogrenci = MessageBox.Show("Öğrenci Eklensin Mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(ogrenci == DialogResult.Yes )
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Tbl_Ogrenci(AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", textBoxOgrenciAd.Text);
                komut.Parameters.AddWithValue("@p2", textBoxOgrenciSoyad.Text);
                komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
                komut.Parameters.AddWithValue("@p4",textBoxOgrenciSinif.Text);
                komut.Parameters.AddWithValue("@p5", maskedTextBoxOgrenciTelefon.Text);
                komut.Parameters.AddWithValue("@p6", textBoxOgrenciMail.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Bilgileri Başarı İle Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğrenci Eklenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            ogrenciekle();
        }

        public void dersekle()
        {
            Mukerrer();

            if (durum == true)
            {
                DialogResult ders = new DialogResult();
                ders = MessageBox.Show("Ders Eklensin Mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ders == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Insert Into Tbl_Dersler(DERSAD) values(@p1)", baglanti);
                    komut.Parameters.AddWithValue("@p1", textBoxDers.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ders Başarı İle Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ders Eklenmedi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Dersin Kayıdı Zaten Yapılmış.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            dersekle();
        }

        public void ogretmenekle()
        {
            DialogResult ogretmen = new DialogResult();
            ogretmen = MessageBox.Show("Öğretmen Eklensin Mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ogretmen == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert Into Tbl_Ogretmen(OGRETMENAD,OGRETMENSOYAD,BRANSID) values(@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", textBoxOgretmenAd.Text);
                komut.Parameters.AddWithValue("@p2", textBoxOgretmenSoyad.Text);
                komut.Parameters.AddWithValue("@p3", comboBox1.SelectedValue);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğretmen Eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Öğretmen Eklenmedi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonOgretmenEkle_Click(object sender, EventArgs e)
        {
            ogretmenekle();
        }

        public void ogretmenders()
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler", baglanti);
            SqlDataAdapter dt = new SqlDataAdapter(komut);
            DataTable da = new DataTable();
            dt.Fill(da);
            comboBox1.ValueMember = "DERSID";
            comboBox1.DisplayMember = "DERSAD";
            comboBox1.DataSource = da;
        }

        public void Mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Dersler where DERSAD=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", textBoxDers.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }


    }
}
