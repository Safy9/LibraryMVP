
namespace Library_MVP.Views
{
    partial class MainFRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFRM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_Setting = new System.Windows.Forms.TabPage();
            this.TP_Book = new System.Windows.Forms.TabPage();
            this.ts_Setting = new System.Windows.Forms.ToolStrip();
            this.tsbtnCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAuthor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDarElNasher = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnPlace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_Book = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.TP_Borrow = new System.Windows.Forms.TabPage();
            this.ts_Borrow = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TP_Setting.SuspendLayout();
            this.TP_Book.SuspendLayout();
            this.ts_Setting.SuspendLayout();
            this.ts_Book.SuspendLayout();
            this.TP_Borrow.SuspendLayout();
            this.ts_Borrow.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 114);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP_Setting);
            this.tabControl1.Controls.Add(this.TP_Book);
            this.tabControl1.Controls.Add(this.TP_Borrow);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 114);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // TP_Setting
            // 
            this.TP_Setting.BackColor = System.Drawing.Color.White;
            this.TP_Setting.Controls.Add(this.ts_Setting);
            this.TP_Setting.Location = new System.Drawing.Point(4, 34);
            this.TP_Setting.Name = "TP_Setting";
            this.TP_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Setting.Size = new System.Drawing.Size(991, 76);
            this.TP_Setting.TabIndex = 0;
            this.TP_Setting.Text = "الإعدادات";
            // 
            // TP_Book
            // 
            this.TP_Book.Controls.Add(this.ts_Book);
            this.TP_Book.Location = new System.Drawing.Point(4, 34);
            this.TP_Book.Name = "TP_Book";
            this.TP_Book.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Book.Size = new System.Drawing.Size(991, 76);
            this.TP_Book.TabIndex = 1;
            this.TP_Book.Text = "الكتاب";
            this.TP_Book.UseVisualStyleBackColor = true;
            // 
            // ts_Setting
            // 
            this.ts_Setting.BackColor = System.Drawing.Color.White;
            this.ts_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsbtnCategory,
            this.toolStripSeparator1,
            this.tsbtnAuthor,
            this.toolStripSeparator3,
            this.tsbtnDarElNasher,
            this.toolStripSeparator4,
            this.tsbtnCountry,
            this.toolStripSeparator5,
            this.tsbtnPlace,
            this.toolStripSeparator6});
            this.ts_Setting.Location = new System.Drawing.Point(3, 3);
            this.ts_Setting.Name = "ts_Setting";
            this.ts_Setting.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_Setting.Size = new System.Drawing.Size(985, 70);
            this.ts_Setting.TabIndex = 0;
            this.ts_Setting.Text = "toolStrip1";
            // 
            // tsbtnCategory
            // 
            this.tsbtnCategory.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCategory.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCategory.Image")));
            this.tsbtnCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCategory.Name = "tsbtnCategory";
            this.tsbtnCategory.Size = new System.Drawing.Size(99, 67);
            this.tsbtnCategory.Text = "تصنيف الكتاب";
            this.tsbtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCategory.Click += new System.EventHandler(this.tsbtnCategory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // tsbtnAuthor
            // 
            this.tsbtnAuthor.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnAuthor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAuthor.Image")));
            this.tsbtnAuthor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAuthor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAuthor.Name = "tsbtnAuthor";
            this.tsbtnAuthor.Size = new System.Drawing.Size(92, 67);
            this.tsbtnAuthor.Text = "مؤلف الكتاب";
            this.tsbtnAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // tsbtnDarElNasher
            // 
            this.tsbtnDarElNasher.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnDarElNasher.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDarElNasher.Image")));
            this.tsbtnDarElNasher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDarElNasher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDarElNasher.Name = "tsbtnDarElNasher";
            this.tsbtnDarElNasher.Size = new System.Drawing.Size(68, 67);
            this.tsbtnDarElNasher.Text = "دار النشر";
            this.tsbtnDarElNasher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 70);
            // 
            // tsbtnCountry
            // 
            this.tsbtnCountry.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnCountry.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCountry.Image")));
            this.tsbtnCountry.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCountry.Name = "tsbtnCountry";
            this.tsbtnCountry.Size = new System.Drawing.Size(50, 67);
            this.tsbtnCountry.Text = "الدول";
            this.tsbtnCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // tsbtnPlace
            // 
            this.tsbtnPlace.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnPlace.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPlace.Image")));
            this.tsbtnPlace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnPlace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPlace.Name = "tsbtnPlace";
            this.tsbtnPlace.Size = new System.Drawing.Size(88, 67);
            this.tsbtnPlace.Text = "مكان الكتاب";
            this.tsbtnPlace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // ts_Book
            // 
            this.ts_Book.BackColor = System.Drawing.Color.White;
            this.ts_Book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Book.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator14,
            this.toolStripButton6,
            this.toolStripSeparator15,
            this.toolStripButton7,
            this.toolStripSeparator16});
            this.ts_Book.Location = new System.Drawing.Point(3, 3);
            this.ts_Book.Name = "ts_Book";
            this.ts_Book.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_Book.Size = new System.Drawing.Size(985, 70);
            this.ts_Book.TabIndex = 1;
            this.ts_Book.Text = "toolStrip2";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(82, 67);
            this.toolStripButton6.Text = "إدارة الكتب";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(112, 67);
            this.toolStripButton7.Text = "البحث فى الكتب";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 70);
            // 
            // TP_Borrow
            // 
            this.TP_Borrow.Controls.Add(this.ts_Borrow);
            this.TP_Borrow.Location = new System.Drawing.Point(4, 34);
            this.TP_Borrow.Name = "TP_Borrow";
            this.TP_Borrow.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Borrow.Size = new System.Drawing.Size(991, 76);
            this.TP_Borrow.TabIndex = 2;
            this.TP_Borrow.Text = "الإستعارة";
            this.TP_Borrow.UseVisualStyleBackColor = true;
            // 
            // ts_Borrow
            // 
            this.ts_Borrow.BackColor = System.Drawing.Color.White;
            this.ts_Borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ts_Borrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Borrow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.toolStripButton1,
            this.toolStripSeparator8,
            this.toolStripButton2,
            this.toolStripSeparator9,
            this.toolStripButton3,
            this.toolStripSeparator10});
            this.ts_Borrow.Location = new System.Drawing.Point(3, 3);
            this.ts_Borrow.Name = "ts_Borrow";
            this.ts_Borrow.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts_Borrow.Size = new System.Drawing.Size(985, 70);
            this.ts_Borrow.TabIndex = 2;
            this.ts_Borrow.Text = "toolStrip3";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 67);
            this.toolStripButton1.Text = "بيانات المستعير";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(104, 67);
            this.toolStripButton2.Text = "أستعارة الكتاب";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Droid Arabic Kufi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(108, 67);
            this.toolStripButton3.Text = "تقارير الإستعارة";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 70);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(999, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 25);
            this.toolStripStatusLabel1.Text = "برنامج إدارة المكتبة";
            // 
            // MainFRM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "MainFRM";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TP_Setting.ResumeLayout(false);
            this.TP_Setting.PerformLayout();
            this.TP_Book.ResumeLayout(false);
            this.TP_Book.PerformLayout();
            this.ts_Setting.ResumeLayout(false);
            this.ts_Setting.PerformLayout();
            this.ts_Book.ResumeLayout(false);
            this.ts_Book.PerformLayout();
            this.TP_Borrow.ResumeLayout(false);
            this.TP_Borrow.PerformLayout();
            this.ts_Borrow.ResumeLayout(false);
            this.ts_Borrow.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_Setting;
        private System.Windows.Forms.ToolStrip ts_Setting;
        private System.Windows.Forms.TabPage TP_Book;
        private System.Windows.Forms.ToolStripButton tsbtnCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAuthor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnDarElNasher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnCountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnPlace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStrip ts_Book;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.TabPage TP_Borrow;
        private System.Windows.Forms.ToolStrip ts_Borrow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}