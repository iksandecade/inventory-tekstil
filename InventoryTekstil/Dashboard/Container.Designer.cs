namespace InventoryTekstil
{
    partial class FormDashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rawMaterialMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.benangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.benangAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.benangTakeOut = new System.Windows.Forms.ToolStripMenuItem();
            this.semicalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.semicalAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.semicalTakeOut = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedGoodsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kainAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.kainTakeOut = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jenisKainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kainReportIn = new System.Windows.Forms.ToolStripMenuItem();
            this.kainReportOut = new System.Windows.Forms.ToolStripMenuItem();
            this.benangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benangReportIn = new System.Windows.Forms.ToolStripMenuItem();
            this.benangReportOut = new System.Windows.Forms.ToolStripMenuItem();
            this.semicalReportIn = new System.Windows.Forms.ToolStripMenuItem();
            this.semicalReportOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardMenu,
            this.rawMaterialMenu,
            this.finishedGoodsMenu,
            this.reportMenu,
            this.settingMenu,
            this.logoutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(76, 20);
            this.dashboardMenu.Text = "Dashboard";
            this.dashboardMenu.Click += new System.EventHandler(this.dashboardMenu_Click);
            // 
            // rawMaterialMenu
            // 
            this.rawMaterialMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benangMenu,
            this.semicalMenu});
            this.rawMaterialMenu.Name = "rawMaterialMenu";
            this.rawMaterialMenu.Size = new System.Drawing.Size(87, 20);
            this.rawMaterialMenu.Text = "Raw Material";
            // 
            // benangMenu
            // 
            this.benangMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benangAdd,
            this.benangTakeOut});
            this.benangMenu.Name = "benangMenu";
            this.benangMenu.Size = new System.Drawing.Size(152, 22);
            this.benangMenu.Text = "Benang";
            // 
            // benangAdd
            // 
            this.benangAdd.Name = "benangAdd";
            this.benangAdd.Size = new System.Drawing.Size(121, 22);
            this.benangAdd.Text = "Add";
            this.benangAdd.Click += new System.EventHandler(this.benangAdd_Click);
            // 
            // benangTakeOut
            // 
            this.benangTakeOut.Name = "benangTakeOut";
            this.benangTakeOut.Size = new System.Drawing.Size(121, 22);
            this.benangTakeOut.Text = "Take Out";
            // 
            // semicalMenu
            // 
            this.semicalMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semicalAdd,
            this.semicalTakeOut});
            this.semicalMenu.Name = "semicalMenu";
            this.semicalMenu.Size = new System.Drawing.Size(152, 22);
            this.semicalMenu.Text = "Semical";
            // 
            // semicalAdd
            // 
            this.semicalAdd.Name = "semicalAdd";
            this.semicalAdd.Size = new System.Drawing.Size(121, 22);
            this.semicalAdd.Text = "Add";
            this.semicalAdd.Click += new System.EventHandler(this.semicalAdd_Click);
            // 
            // semicalTakeOut
            // 
            this.semicalTakeOut.Name = "semicalTakeOut";
            this.semicalTakeOut.Size = new System.Drawing.Size(121, 22);
            this.semicalTakeOut.Text = "Take Out";
            // 
            // finishedGoodsMenu
            // 
            this.finishedGoodsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kainMenu});
            this.finishedGoodsMenu.Name = "finishedGoodsMenu";
            this.finishedGoodsMenu.Size = new System.Drawing.Size(100, 20);
            this.finishedGoodsMenu.Text = "Finished Goods";
            // 
            // kainMenu
            // 
            this.kainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kainAdd,
            this.kainTakeOut});
            this.kainMenu.Name = "kainMenu";
            this.kainMenu.Size = new System.Drawing.Size(152, 22);
            this.kainMenu.Text = "Kain";
            // 
            // kainAdd
            // 
            this.kainAdd.Name = "kainAdd";
            this.kainAdd.Size = new System.Drawing.Size(121, 22);
            this.kainAdd.Text = "Add";
            this.kainAdd.Click += new System.EventHandler(this.kainAdd_Click);
            // 
            // kainTakeOut
            // 
            this.kainTakeOut.Name = "kainTakeOut";
            this.kainTakeOut.Size = new System.Drawing.Size(121, 22);
            this.kainTakeOut.Text = "Take Out";
            this.kainTakeOut.Click += new System.EventHandler(this.kainTakeOut_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kainToolStripMenuItem,
            this.benangToolStripMenuItem,
            this.semicalToolStripMenuItem});
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(54, 20);
            this.reportMenu.Text = "Report";
            // 
            // settingMenu
            // 
            this.settingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenu,
            this.jenisKainMenu});
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(56, 20);
            this.settingMenu.Text = "Setting";
            // 
            // userMenu
            // 
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(152, 22);
            this.userMenu.Text = "User";
            // 
            // jenisKainMenu
            // 
            this.jenisKainMenu.Name = "jenisKainMenu";
            this.jenisKainMenu.Size = new System.Drawing.Size(152, 22);
            this.jenisKainMenu.Text = "Jenis Kain";
            // 
            // logoutMenu
            // 
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(57, 20);
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // kainToolStripMenuItem
            // 
            this.kainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kainReportIn,
            this.kainReportOut});
            this.kainToolStripMenuItem.Name = "kainToolStripMenuItem";
            this.kainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kainToolStripMenuItem.Text = "Kain";
            // 
            // kainReportIn
            // 
            this.kainReportIn.Name = "kainReportIn";
            this.kainReportIn.Size = new System.Drawing.Size(152, 22);
            this.kainReportIn.Text = "Data In";
            this.kainReportIn.Click += new System.EventHandler(this.kainReportIn_Click);
            // 
            // kainReportOut
            // 
            this.kainReportOut.Name = "kainReportOut";
            this.kainReportOut.Size = new System.Drawing.Size(152, 22);
            this.kainReportOut.Text = "Data Out";
            // 
            // benangToolStripMenuItem
            // 
            this.benangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benangReportIn,
            this.benangReportOut});
            this.benangToolStripMenuItem.Name = "benangToolStripMenuItem";
            this.benangToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.benangToolStripMenuItem.Text = "Benang";
            // 
            // semicalToolStripMenuItem
            // 
            this.semicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semicalReportIn,
            this.semicalReportOut});
            this.semicalToolStripMenuItem.Name = "semicalToolStripMenuItem";
            this.semicalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.semicalToolStripMenuItem.Text = "Semical";
            // 
            // benangReportIn
            // 
            this.benangReportIn.Name = "benangReportIn";
            this.benangReportIn.Size = new System.Drawing.Size(152, 22);
            this.benangReportIn.Text = "Data In";
            this.benangReportIn.Click += new System.EventHandler(this.benangReportIn_Click);
            // 
            // benangReportOut
            // 
            this.benangReportOut.Name = "benangReportOut";
            this.benangReportOut.Size = new System.Drawing.Size(152, 22);
            this.benangReportOut.Text = "Data Out";
            // 
            // semicalReportIn
            // 
            this.semicalReportIn.Name = "semicalReportIn";
            this.semicalReportIn.Size = new System.Drawing.Size(152, 22);
            this.semicalReportIn.Text = "Data In";
            this.semicalReportIn.Click += new System.EventHandler(this.semicalReportIn_Click);
            // 
            // semicalReportOut
            // 
            this.semicalReportOut.Name = "semicalReportOut";
            this.semicalReportOut.Size = new System.Drawing.Size(152, 22);
            this.semicalReportOut.Text = "Data Out";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 493);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rawMaterialMenu;
        private System.Windows.Forms.ToolStripMenuItem benangMenu;
        private System.Windows.Forms.ToolStripMenuItem semicalMenu;
        private System.Windows.Forms.ToolStripMenuItem finishedGoodsMenu;
        private System.Windows.Forms.ToolStripMenuItem kainMenu;
        private System.Windows.Forms.ToolStripMenuItem dashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem settingMenu;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem jenisKainMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ToolStripMenuItem benangAdd;
        private System.Windows.Forms.ToolStripMenuItem benangTakeOut;
        private System.Windows.Forms.ToolStripMenuItem semicalAdd;
        private System.Windows.Forms.ToolStripMenuItem semicalTakeOut;
        private System.Windows.Forms.ToolStripMenuItem kainAdd;
        private System.Windows.Forms.ToolStripMenuItem kainTakeOut;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolStripMenuItem kainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kainReportIn;
        private System.Windows.Forms.ToolStripMenuItem kainReportOut;
        private System.Windows.Forms.ToolStripMenuItem benangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benangReportIn;
        private System.Windows.Forms.ToolStripMenuItem benangReportOut;
        private System.Windows.Forms.ToolStripMenuItem semicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semicalReportIn;
        private System.Windows.Forms.ToolStripMenuItem semicalReportOut;
    }
}