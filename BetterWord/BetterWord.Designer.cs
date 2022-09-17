namespace BetterWord
{
    partial class BetterWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetterWord));
            this.FD_1 = new System.Windows.Forms.FontDialog();
            this.TSMI_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSCB_FontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.SFD_1 = new System.Windows.Forms.SaveFileDialog();
            this.OFD_1 = new System.Windows.Forms.OpenFileDialog();
            this.TSCB_Size = new System.Windows.Forms.ToolStripComboBox();
            this.CD_1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Yeni = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ac = new System.Windows.Forms.ToolStripButton();
            this.TSB_Kaydet = new System.Windows.Forms.ToolStripButton();
            this.TSB_FarkliKaydet = new System.Windows.Forms.ToolStripButton();
            this.TSB_Bold = new System.Windows.Forms.ToolStripButton();
            this.TSB_UnderLine = new System.Windows.Forms.ToolStripButton();
            this.TSB_Strike = new System.Windows.Forms.ToolStripButton();
            this.TSB_Italic = new System.Windows.Forms.ToolStripButton();
            this.TSMI_Cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Yazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_FarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Ac = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RTB_1 = new System.Windows.Forms.RichTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSMI_Color
            // 
            this.TSMI_Color.Name = "TSMI_Color";
            this.TSMI_Color.Size = new System.Drawing.Size(148, 22);
            this.TSMI_Color.Text = "Color Settings";
            // 
            // TSMI_Font
            // 
            this.TSMI_Font.Name = "TSMI_Font";
            this.TSMI_Font.Size = new System.Drawing.Size(148, 22);
            this.TSMI_Font.Text = "Font Settings";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Font,
            this.TSMI_Color});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.düzenToolStripMenuItem.Text = "Mics.";
            // 
            // TSCB_FontFamily
            // 
            this.TSCB_FontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TSCB_FontFamily.Name = "TSCB_FontFamily";
            this.TSCB_FontFamily.Size = new System.Drawing.Size(121, 25);
            this.TSCB_FontFamily.SelectedIndexChanged += new System.EventHandler(this.TSCB_FontFamily_SelectedIndexChanged);
            // 
            // SFD_1
            // 
            this.SFD_1.FileName = "save file dialog";
            // 
            // OFD_1
            // 
            this.OFD_1.FileName = "openFileDialog1";
            // 
            // TSCB_Size
            // 
            this.TSCB_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.TSCB_Size.Name = "TSCB_Size";
            this.TSCB_Size.Size = new System.Drawing.Size(121, 25);
            this.TSCB_Size.SelectedIndexChanged += new System.EventHandler(this.TSCB_Size_SelectedIndexChanged);
            this.TSCB_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSCB_Size_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Yeni,
            this.TSB_Ac,
            this.TSB_Kaydet,
            this.TSB_FarkliKaydet,
            this.TSCB_Size,
            this.TSCB_FontFamily,
            this.TSB_Bold,
            this.TSB_UnderLine,
            this.TSB_Strike,
            this.TSB_Italic,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Yeni
            // 
            this.TSB_Yeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Yeni.Image = global::BetterWord.Properties.Resources.yeni;
            this.TSB_Yeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Yeni.Name = "TSB_Yeni";
            this.TSB_Yeni.Size = new System.Drawing.Size(23, 22);
            this.TSB_Yeni.Text = "New";
            this.TSB_Yeni.Click += new System.EventHandler(this.Yeni);
            // 
            // TSB_Ac
            // 
            this.TSB_Ac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Ac.Image = global::BetterWord.Properties.Resources.ac;
            this.TSB_Ac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ac.Name = "TSB_Ac";
            this.TSB_Ac.Size = new System.Drawing.Size(23, 22);
            this.TSB_Ac.Text = "Open";
            this.TSB_Ac.Click += new System.EventHandler(this.Ac);
            // 
            // TSB_Kaydet
            // 
            this.TSB_Kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Kaydet.Image = global::BetterWord.Properties.Resources.kaydet;
            this.TSB_Kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Kaydet.Name = "TSB_Kaydet";
            this.TSB_Kaydet.Size = new System.Drawing.Size(23, 22);
            this.TSB_Kaydet.Text = "Save";
            this.TSB_Kaydet.Click += new System.EventHandler(this.Kaydet);
            // 
            // TSB_FarkliKaydet
            // 
            this.TSB_FarkliKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_FarkliKaydet.Image = global::BetterWord.Properties.Resources.farklikaydet;
            this.TSB_FarkliKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_FarkliKaydet.Name = "TSB_FarkliKaydet";
            this.TSB_FarkliKaydet.Size = new System.Drawing.Size(23, 22);
            this.TSB_FarkliKaydet.Text = "Save As";
            this.TSB_FarkliKaydet.Click += new System.EventHandler(this.FarkliKaydet);
            // 
            // TSB_Bold
            // 
            this.TSB_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSB_Bold.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Bold.Image")));
            this.TSB_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Bold.Name = "TSB_Bold";
            this.TSB_Bold.Size = new System.Drawing.Size(23, 22);
            this.TSB_Bold.Text = "B";
            this.TSB_Bold.Click += new System.EventHandler(this.TSB_Bold_Click);
            // 
            // TSB_UnderLine
            // 
            this.TSB_UnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_UnderLine.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.TSB_UnderLine.Image = ((System.Drawing.Image)(resources.GetObject("TSB_UnderLine.Image")));
            this.TSB_UnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_UnderLine.Name = "TSB_UnderLine";
            this.TSB_UnderLine.Size = new System.Drawing.Size(23, 22);
            this.TSB_UnderLine.Text = "U";
            this.TSB_UnderLine.Click += new System.EventHandler(this.TSB_UnderLine_Click);
            // 
            // TSB_Strike
            // 
            this.TSB_Strike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Strike.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout);
            this.TSB_Strike.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Strike.Image")));
            this.TSB_Strike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Strike.Name = "TSB_Strike";
            this.TSB_Strike.Size = new System.Drawing.Size(23, 22);
            this.TSB_Strike.Text = "S";
            this.TSB_Strike.Click += new System.EventHandler(this.TSB_Strike_Click);
            // 
            // TSB_Italic
            // 
            this.TSB_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Italic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.TSB_Italic.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Italic.Image")));
            this.TSB_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Italic.Name = "TSB_Italic";
            this.TSB_Italic.Size = new System.Drawing.Size(23, 22);
            this.TSB_Italic.Text = "I";
            this.TSB_Italic.Click += new System.EventHandler(this.TSB_Italic_Click);
            // 
            // TSMI_Cikis
            // 
            this.TSMI_Cikis.Name = "TSMI_Cikis";
            this.TSMI_Cikis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.TSMI_Cikis.Size = new System.Drawing.Size(216, 22);
            this.TSMI_Cikis.Text = "Exit";
            this.TSMI_Cikis.Click += new System.EventHandler(this.TSMI_Cikis_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // TSMI_Yazdir
            // 
            this.TSMI_Yazdir.Name = "TSMI_Yazdir";
            this.TSMI_Yazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TSMI_Yazdir.Size = new System.Drawing.Size(216, 22);
            this.TSMI_Yazdir.Text = "Print (doesnt work)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // TSMI_FarkliKaydet
            // 
            this.TSMI_FarkliKaydet.Name = "TSMI_FarkliKaydet";
            this.TSMI_FarkliKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMI_FarkliKaydet.Size = new System.Drawing.Size(216, 22);
            this.TSMI_FarkliKaydet.Text = "Save As";
            this.TSMI_FarkliKaydet.Click += new System.EventHandler(this.FarkliKaydet);
            // 
            // TSMI_Kaydet
            // 
            this.TSMI_Kaydet.Name = "TSMI_Kaydet";
            this.TSMI_Kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_Kaydet.Size = new System.Drawing.Size(216, 22);
            this.TSMI_Kaydet.Text = "Save";
            this.TSMI_Kaydet.Click += new System.EventHandler(this.Kaydet);
            // 
            // TSMI_Ac
            // 
            this.TSMI_Ac.Name = "TSMI_Ac";
            this.TSMI_Ac.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_Ac.Size = new System.Drawing.Size(216, 22);
            this.TSMI_Ac.Text = "Open";
            this.TSMI_Ac.Click += new System.EventHandler(this.Ac);
            // 
            // TSMI_Menu
            // 
            this.TSMI_Menu.Name = "TSMI_Menu";
            this.TSMI_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMI_Menu.Size = new System.Drawing.Size(216, 22);
            this.TSMI_Menu.Text = "New";
            this.TSMI_Menu.Click += new System.EventHandler(this.Yeni);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Menu,
            this.TSMI_Ac,
            this.TSMI_Kaydet,
            this.TSMI_FarkliKaydet,
            this.toolStripSeparator1,
            this.TSMI_Yazdir,
            this.toolStripSeparator2,
            this.TSMI_Cikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dosyaToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RTB_1
            // 
            this.RTB_1.Location = new System.Drawing.Point(0, 52);
            this.RTB_1.Name = "RTB_1";
            this.RTB_1.Size = new System.Drawing.Size(684, 412);
            this.RTB_1.TabIndex = 5;
            this.RTB_1.Text = "";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "N";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BetterWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RTB_1);
            this.Name = "BetterWord";
            this.Text = "BetterWord";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog FD_1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Color;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Font;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TSB_Italic;
        private System.Windows.Forms.ToolStripButton TSB_Strike;
        private System.Windows.Forms.ToolStripButton TSB_UnderLine;
        private System.Windows.Forms.ToolStripButton TSB_Bold;
        private System.Windows.Forms.ToolStripComboBox TSCB_FontFamily;
        private System.Windows.Forms.SaveFileDialog SFD_1;
        private System.Windows.Forms.OpenFileDialog OFD_1;
        private System.Windows.Forms.ToolStripComboBox TSCB_Size;
        private System.Windows.Forms.ToolStripButton TSB_FarkliKaydet;
        private System.Windows.Forms.ColorDialog CD_1;
        private System.Windows.Forms.ToolStripButton TSB_Kaydet;
        private System.Windows.Forms.ToolStripButton TSB_Yeni;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cikis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Yazdir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FarkliKaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Menu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox RTB_1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}