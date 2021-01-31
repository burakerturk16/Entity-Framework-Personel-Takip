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
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace EfPersonelOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PersonelDal _personelDal = new PersonelDal();
        private void Form1_Load(object sender, EventArgs e)
        {
          
                dgv_list.DataSource = _personelDal.personelList();
            
        }
       private void personelListele()
        {
            dgv_list.DataSource = _personelDal.personelList();
        }
       
        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbx_Gadi.Text = dgv_list.CurrentRow.Cells[1].Value.ToString();
            tbx_Gsoyadi.Text = dgv_list.CurrentRow.Cells[2].Value.ToString();
            tbx_Gemail.Text = dgv_list.CurrentRow.Cells[3].Value.ToString();
            tbx_GtelNo.Text = dgv_list.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _personelDal.personelEkle(new Personeller
            {
                PerID = Guid.NewGuid(),
                PerAdi = tbx_EkleAd.Text,
                PerSoyad = tbx_EkleSoyad.Text,
                PerEmail = tbx_EkleEmail.Text,
                PerTelno = tbx_EkleTelNo.Text
            });
            personelListele();
            MessageBox.Show("KAYIT BASARI ILE EKLENDI");
           
        }

        private void Update_Click(object sender, EventArgs e)
        {

            _personelDal.personelGuncelle(new Personeller
            {
                PerID = (Guid)dgv_list.CurrentRow.Cells[0].Value,
                PerAdi = tbx_Gadi.Text,
                PerSoyad = tbx_Gsoyadi.Text,
                PerEmail = tbx_Gemail.Text,
                PerTelno = tbx_GtelNo.Text
            }); 
            personelListele();
            MessageBox.Show("KAYIT BASARI ILE GUNCELLENDI");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _personelDal.personelSil(new Personeller
            {
                PerID = (Guid)dgv_list.CurrentRow.Cells[0].Value,
            });
            personelListele();
            MessageBox.Show("KAYIT BASARI ILE SILINDI");
        }
    }
}
