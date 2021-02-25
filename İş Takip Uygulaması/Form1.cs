using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İsKarti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GorevListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //yeni nesne oluşturduk sonra yeni formu mdi içerisine gömdük
            Formlar.FrmGorevler frm = new Formlar.FrmGorevler();
            frm.MdiParent = this;
            frm.Show();

        }

        //Anasayfa görev ekleme
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.GorevEkle frm = new Formlar.GorevEkle();
            frm.MdiParent = this;
            frm.Show();

        }


        //Bitmiş Görevleri Listeleme
        private void Bitmis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.BitmisGorev frm = new Formlar.BitmisGorev();
            frm.MdiParent = this;
            frm.Show();
        }



        //Aktif Görevleri Listeleme
        private void Aktif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AktifGorevler frm = new Formlar.AktifGorevler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
