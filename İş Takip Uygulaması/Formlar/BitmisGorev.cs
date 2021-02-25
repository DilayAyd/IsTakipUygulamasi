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
    public partial class BitmisGorev : Form
    {
        public BitmisGorev()
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
            var degerler5 = (from x in db.TblGorev
                            select new
                            {
                                x.GorevAdi,
                                x.Aciklama,
                                x.DurumID,



                            }).ToList();

            gridControl1.DataSource = degerler5.Where(x => x.DurumID == 5).ToList(); ;

        }
            private void BitmisGorev_Load(object sender, EventArgs e)
        {

        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
                Listele();
        }
    }
}
