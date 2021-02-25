namespace İsKarti
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.GorevListele = new DevExpress.XtraBars.BarButtonItem();
            this.Aktif = new DevExpress.XtraBars.BarButtonItem();
            this.Bitmis = new DevExpress.XtraBars.BarButtonItem();
            this.AnaSayfa = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Gorevler = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.GorevListele,
            this.Aktif,
            this.Bitmis});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.AnaSayfa,
            this.Gorevler});
            this.ribbonControl1.Size = new System.Drawing.Size(984, 150);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ana Sayfa";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // GorevListele
            // 
            this.GorevListele.Caption = "Görev Listele";
            this.GorevListele.Id = 2;
            this.GorevListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GorevListele.ImageOptions.Image")));
            this.GorevListele.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GorevListele.ImageOptions.LargeImage")));
            this.GorevListele.Name = "GorevListele";
            this.GorevListele.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GorevListele_ItemClick);
            // 
            // Aktif
            // 
            this.Aktif.Caption = "Aktif Görevler";
            this.Aktif.Id = 3;
            this.Aktif.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Aktif.ImageOptions.Image")));
            this.Aktif.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Aktif.ImageOptions.LargeImage")));
            this.Aktif.Name = "Aktif";
            this.Aktif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Aktif_ItemClick);
            // 
            // Bitmis
            // 
            this.Bitmis.Caption = "Bitmiş Görevler";
            this.Bitmis.Id = 4;
            this.Bitmis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Bitmis.ImageOptions.Image")));
            this.Bitmis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Bitmis.ImageOptions.LargeImage")));
            this.Bitmis.Name = "Bitmis";
            this.Bitmis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Bitmis_ItemClick);
            // 
            // AnaSayfa
            // 
            this.AnaSayfa.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.AnaSayfa.Name = "AnaSayfa";
            this.AnaSayfa.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // Gorevler
            // 
            this.Gorevler.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.Gorevler.Name = "Gorevler";
            this.Gorevler.Text = "Görevler";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.GorevListele);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Aktif);
            this.ribbonPageGroup3.ItemLinks.Add(this.Bitmis);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage AnaSayfa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem GorevListele;
        private DevExpress.XtraBars.Ribbon.RibbonPage Gorevler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem Aktif;
        private DevExpress.XtraBars.BarButtonItem Bitmis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

