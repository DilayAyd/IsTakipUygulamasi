using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using İsKarti.Entity;

namespace İsKarti.Formlar
{
    public partial class FrmGorevler : Form
    {
        public FrmGorevler()
        {
            InitializeComponent();
        }

        //listele fonksiyonu yazıyoruz
         void Listele()
        {
            //entity dahil edildi 
            //Grid kontrole Görev tablosu çağrıldı
            DbIsKartiEntities db = new DbIsKartiEntities();

            //tabloda istediğimiz degerleri sıralıyoruz
            var degerler = (from x in db.TblGorev
                            select new
                            {
                                x.GorevAdi,
                                x.Aciklama,
                                x.DurumID,
                             
                               

                            }).ToList();

            gridControl1.DataSource = degerler.Where(x => x.DurumID == 1).ToList(); 

            var deger = (from x in db.TblGorev
                            select new
                            {
                                x.GorevAdi,
                                x.Aciklama,
                                x.DurumID,
                               
                                // x.TblDurums.DurumAdi,


                            }).ToList();
            //istediğimiz sütunları sıralıyoruz
            gridControl2.DataSource = deger.Where (x=>x.DurumID == 2).ToList();



            var deger3 = (from x in db.TblGorev
                         select new
                         {
                             x.GorevAdi,
                             x.Aciklama,
                             x.DurumID,
                             // x.TblDurums.DurumAdi,


                         }).ToList();
            //istediğimiz sütunları sıralıyoruz
            gridControl3.DataSource = deger3.Where(x => x.DurumID == 3).ToList();



            var deger4 = (from x in db.TblGorev
                         select new
                         {
                             x.GorevAdi,
                             x.Aciklama,
                             x.DurumID,
                             // x.TblDurums.DurumAdi,


                         }).ToList();
            //istediğimiz sütunları sıralıyoruz
            gridControl4.DataSource = deger4.Where(x => x.DurumID == 4).ToList();





        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {

        }

        

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //txtGorevAdi.Text = gridView1.GetFocusedRowCellValue("Gorev Adi").ToString();
        }

        private void gridView3_DragObjectDrop(object sender, DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs e)
        {

        }

        private void FrmGorevler_Load(object sender, EventArgs e)
        {

        }
    }
}
