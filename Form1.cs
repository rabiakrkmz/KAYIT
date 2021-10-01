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

namespace KAYIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-0GRN21E\\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True");

        private void verilerigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Tablo", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AD"].ToString();
                ekle.SubItems.Add (oku["SOYAD"].ToString());
                ekle.SubItems.Add (oku["TC"].ToString());
                ekle.SubItems.Add (oku["TEL"].ToString());
                ekle.SubItems.Add (oku["KANGRUBU"].ToString());
                ekle.SubItems.Add (oku["CİNSİYET"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Tablo (AD,SOYAD,TC,TEL,KANGRUBU,CİNSİYET) Values ('" + textBox1.Text.ToString() + " ' ,'" + textBox2.Text.ToString() + " ' ,'" + textBox3.Text.ToString() + " ','" + textBox4.Text.ToString() + " ' , '" + textBox5.Text.ToString() + " ' , '" + textBox6.Text.ToString() +" ')",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigöster();
            
        }
    }
}
