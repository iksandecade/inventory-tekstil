namespace InventoryTekstil.Input
{
    partial class InputSemical
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
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbHargaBeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSupplier = new System.Windows.Forms.TextBox();
            this.jenisComboBox = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SemicalGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SemicalGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(416, 75);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(171, 20);
            this.tbStok.TabIndex = 23;
            // 
            // tbHargaBeli
            // 
            this.tbHargaBeli.Location = new System.Drawing.Point(416, 23);
            this.tbHargaBeli.Name = "tbHargaBeli";
            this.tbHargaBeli.Size = new System.Drawing.Size(171, 20);
            this.tbHargaBeli.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lot";
            // 
            // tbSupplier
            // 
            this.tbSupplier.Location = new System.Drawing.Point(416, 49);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.Size = new System.Drawing.Size(171, 20);
            this.tbSupplier.TabIndex = 20;
            // 
            // jenisComboBox
            // 
            this.jenisComboBox.FormattingEnabled = true;
            this.jenisComboBox.Items.AddRange(new object[] {
            "Caustic Soda (NaOH)",
            "Asam Klorida (HCl)",
            "Sodium Nitrit (NaNO2)",
            "Hidrogen Peroksida (H2O2)",
            "Sodium Ditionint (Na2s2O4)"});
            this.jenisComboBox.Location = new System.Drawing.Point(101, 27);
            this.jenisComboBox.Name = "jenisComboBox";
            this.jenisComboBox.Size = new System.Drawing.Size(171, 21);
            this.jenisComboBox.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Harga Beli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jenis";
            // 
            // tbLot
            // 
            this.tbLot.Location = new System.Drawing.Point(101, 54);
            this.tbLot.Name = "tbLot";
            this.tbLot.Size = new System.Drawing.Size(171, 20);
            this.tbLot.TabIndex = 25;
            this.tbLot.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Stok";
            // 
            // SemicalGridView
            // 
            this.SemicalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SemicalGridView.Location = new System.Drawing.Point(25, 182);
            this.SemicalGridView.Name = "SemicalGridView";
            this.SemicalGridView.Size = new System.Drawing.Size(597, 160);
            this.SemicalGridView.TabIndex = 26;
            // 
            // InputSemical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 354);
            this.Controls.Add(this.SemicalGridView);
            this.Controls.Add(this.tbLot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbHargaBeli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSupplier);
            this.Controls.Add(this.jenisComboBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "InputSemical";
            this.Text = "InputSemical";
            this.Load += new System.EventHandler(this.InputSemical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SemicalGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbHargaBeli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSupplier;
        private System.Windows.Forms.ComboBox jenisComboBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView SemicalGridView;
    }
}