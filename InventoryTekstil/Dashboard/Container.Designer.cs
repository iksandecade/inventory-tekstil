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
            this.semicalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tubeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedGoodsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jenisKainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jenisSemicalMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rakMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardMenu,
            this.rawMaterialMenu,
            this.finishedGoodsMenu,
            this.settingMenu,
            this.logoutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
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
            this.semicalMenu,
            this.tubeMenu});
            this.rawMaterialMenu.Name = "rawMaterialMenu";
            this.rawMaterialMenu.Size = new System.Drawing.Size(87, 20);
            this.rawMaterialMenu.Text = "Raw Material";
            // 
            // benangMenu
            // 
            this.benangMenu.Name = "benangMenu";
            this.benangMenu.Size = new System.Drawing.Size(115, 22);
            this.benangMenu.Text = "Benang";
            this.benangMenu.Click += new System.EventHandler(this.benangMenu_Click);
            // 
            // semicalMenu
            // 
            this.semicalMenu.Name = "semicalMenu";
            this.semicalMenu.Size = new System.Drawing.Size(115, 22);
            this.semicalMenu.Text = "Semical";
            this.semicalMenu.Click += new System.EventHandler(this.semicalMenu_Click);
            // 
            // tubeMenu
            // 
            this.tubeMenu.Name = "tubeMenu";
            this.tubeMenu.Size = new System.Drawing.Size(115, 22);
            this.tubeMenu.Text = "Tube";
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
            this.kainMenu.Name = "kainMenu";
            this.kainMenu.Size = new System.Drawing.Size(97, 22);
            this.kainMenu.Text = "Kain";
            // 
            // settingMenu
            // 
            this.settingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenu,
            this.jenisKainMenu,
            this.jenisSemicalMenu,
            this.rakMenu});
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
            this.jenisKainMenu.Click += new System.EventHandler(this.jenisKainMenu_Click);
            // 
            // jenisSemicalMenu
            // 
            this.jenisSemicalMenu.Name = "jenisSemicalMenu";
            this.jenisSemicalMenu.Size = new System.Drawing.Size(152, 22);
            this.jenisSemicalMenu.Text = "Jenis Semical";
            // 
            // rakMenu
            // 
            this.rakMenu.Name = "rakMenu";
            this.rakMenu.Size = new System.Drawing.Size(152, 22);
            this.rakMenu.Text = "Rak";
            // 
            // logoutMenu
            // 
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(57, 20);
            this.logoutMenu.Text = "Logout";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 273);
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
        private System.Windows.Forms.ToolStripMenuItem tubeMenu;
        private System.Windows.Forms.ToolStripMenuItem finishedGoodsMenu;
        private System.Windows.Forms.ToolStripMenuItem kainMenu;
        private System.Windows.Forms.ToolStripMenuItem dashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem settingMenu;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem jenisKainMenu;
        private System.Windows.Forms.ToolStripMenuItem jenisSemicalMenu;
        private System.Windows.Forms.ToolStripMenuItem rakMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
    }
}