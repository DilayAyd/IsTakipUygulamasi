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
    public partial class AktifGorevler : Form
    {
        public AktifGorevler()
        {
            InitializeComponent();
        }

        private void AktifGorevler_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            //entity dahil edildi 
            //Grid kontrole Görev tablosu çağrıldı
            DbIsKartiEntities db = new DbIsKartiEntities();

            //tabloda istediğimiz degerleri sıralıyoruz
            var aktif = (from x in db.TblGorev
                             select new
                             {
                                 x.GorevAdi,
                                 x.Aciklama,
                                 x.TblDurums.DurumAdi,
                                 x.DurumID,




                             }).ToList();

            gridControl1.DataSource = aktif.Where(x => x.DurumID != 5).ToList();
           // gridControl1.DataSource = aktif.Where(x => x.DurumID == 2).ToList(); ;
            //gridControl1.DataSource = aktif.Where(x => x.DurumID == 3).ToList(); ;
            //gridControl1.DataSource = aktif.Where(x => x.DurumID == 4).ToList(); ;

        }
        private void AktifListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
