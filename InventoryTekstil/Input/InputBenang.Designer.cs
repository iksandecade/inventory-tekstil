namespace InventoryTekstil.Input
{
    partial class InputBenang
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
            this.tbLot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbHargaBeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jenisComboBox = new System.Windows.Forms.ComboBox();
            this.benangGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.benangGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLot
            // 
            this.tbLot.Location = new System.Drawing.Point(111, 62);
            this.tbLot.Name = "tbLot";
            this.tbLot.Size = new System.Drawing.Size(171, 20);
            this.tbLot.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Stok";
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(420, 91);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(171, 20);
            this.tbStok.TabIndex = 37;
            // 
            // tbHargaBeli
            // 
            this.tbHargaBeli.Location = new System.Drawing.Point(420, 28);
            this.tbHargaBeli.Name = "tbHargaBeli";
            this.tbHargaBeli.Size = new System.Drawing.Size(171, 20);
            this.tbHargaBeli.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Lot";
            // 
            // tbSupplier
            // 
            this.tbSupplier.Location = new System.Drawing.Point(420, 59);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(171, 20);
            this.tbSupplier.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(129, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Harga Beli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Jenis";
            // 
            // jenisComboBox
            // 
            this.jenisComboBox.FormattingEnabled = true;
            this.jenisComboBox.Items.AddRange(new object[] {
            "Pintal",
            "Gintir",
            "Filament",
            "Tekstur",
            "Hias",
            "Jahit"});
            this.jenisComboBox.Location = new System.Drawing.Point(111, 32);
            this.jenisComboBox.Name = "jenisComboBox";
            this.jenisComboBox.Size = new System.Drawing.Size(171, 21);
            this.jenisComboBox.TabIndex = 41;
            // 
            // benangGridView
            // 
            this.benangGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benangGridView.Location = new System.Drawing.Point(35, 188);
            this.benangGridView.Name = "benangGridView";
            this.benangGridView.Size = new System.Drawing.Size(556, 150);
            this.benangGridView.TabIndex = 42;
            // 
            // InputBenang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 359);
            this.Controls.Add(this.benangGridView);
            this.Controls.Add(this.jenisComboBox);
            this.Controls.Add(this.tbLot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbHargaBeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSupplier);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InputBenang";
            this.Text = " ";
            this.Load += new System.EventHandler(this.InputBenang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benangGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbHargaBeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSupplier;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jenisComboBox;
        private System.Windows.Forms.DataGridView benangGridView;
    }
}