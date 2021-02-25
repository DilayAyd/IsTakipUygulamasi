using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using İsKarti.Entity;

namespace İsKarti.Formlar
{
    public partial class GorevEkle : Form
    {
        public GorevEkle()
        {
            InitializeComponent();
        }

        private void pictureEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        DbIsKartiEntities dtb = new DbIsKartiEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            //görev nesnesi tanımlandı
            TblGorev gorev = new TblGorev();

            //formdaki veriler alınıp veritabanına kayıt ediliyor
            gorev.GorevAdi = txtGorevAdi.Text;
            gorev.GorevSahip = int.Parse(GorevSahibi.EditValue.ToString());
            gorev.DurumID = int.Parse(GorevDurum.EditValue.ToString());

            gorev.GorevTarih = DateTime.Parse(txtTarih.Text);
            gorev.Aciklama = GorevAciklama.Text;
            gorev.Notlar = GorevNot.Text;
            gorev.TahminDate = DateTime.Parse(txtTarih.Text).AddDays(1);


            /*if (ZorlukDerecesi.SelectedIndex = 1 )
            gorev.TahminDate = DateTime.Parse(txtTarih.Text).AddDays(1); 
            if (ZorlukDerecesi.SelectedIndex = 2 )
            gorev.TahminDate = DateTime.Parse(txtTarih.Text).AddDays(2);
            if (ZorlukDerecesi.SelectedIndex = 3 )
            gorev.TahminDate = DateTime.Parse(txtTarih.Text).AddDays(4);
            if (ZorlukDerecesi.SelectedIndex = 4 )
            gorev.TahminDate = DateTime.Parse(txtTarih.Text).AddDays(6);
            if (ZorlukDerecesi.SelectedIndex = 5 )
            gorev.TahminDate = DateTime.Parse(txtTarih.Text).AddDays(8);*/


            dtb.TblGorev.Add(gorev);
            dtb.SaveChanges();

            //bilgi mesajı
            XtraMessageBox.Show("Görev başarılı bir şekilde listeye eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GorevEkle_Load(object sender, EventArgs e)
        {

            // LookUp'larımıza databaseden veri çekiyoruz
            var durumlar = (from x in dtb.TblDurums

                            select new
                            {
                                x.DurumID,
                                x.DurumAdi
                            }).ToList();
            GorevDurum.Properties.ValueMember = "DurumID";
            GorevDurum.Properties.DisplayMember = "Durumadi";
            GorevDurum.Properties.DataSource = durumlar;

            ///////////////////////////////////////////////
            var sahip = (from y in dtb.TblKullanici

                            select new
                            {
                                y.UserID,
                                y.UserName
                            }).ToList();
            GorevSahibi.Properties.ValueMember = "UserID";
            GorevSahibi.Properties.DisplayMember = "UserName";
            GorevSahibi.Properties.DataSource = sahip;

            ///////////////////////////////////////////////

            var proje = (from z in dtb.TblProje

                            select new
                            {
                                z.ProjeID,
                                z.ProjeAdi
                            }).ToList();
            ProjeAdi.Properties.ValueMember = "ProjeID";
            ProjeAdi.Properties.DisplayMember = "ProjeAdii";
            ProjeAdi.Properties.DataSource = proje;



        }

        private void ZorlukDerecesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
