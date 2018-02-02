namespace InventoryTekstil.Input
{
    partial class InputKain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.jenisKainComboBox = new System.Windows.Forms.ComboBox();
            this.tbLot = new System.Windows.Forms.TextBox();
            this.tbPanjang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGramasi = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Panjang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gramasi";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(297, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // jenisKainComboBox
            // 
            this.jenisKainComboBox.FormattingEnabled = true;
            this.jenisKainComboBox.Location = new System.Drawing.Point(77, 32);
            this.jenisKainComboBox.Name = "jenisKainComboBox";
            this.jenisKainComboBox.Size = new System.Drawing.Size(171, 21);
            this.jenisKainComboBox.TabIndex = 6;
            // 
            // tbLot
            // 
            this.tbLot.Location = new System.Drawing.Point(77, 62);
            this.tbLot.Name = "tbLot";
            this.tbLot.Size = new System.Drawing.Size(171, 20);
            this.tbLot.TabIndex = 7;
            // 
            // tbPanjang
            // 
            this.tbPanjang.Location = new System.Drawing.Point(77, 91);
            this.tbPanjang.Name = "tbPanjang";
            this.tbPanjang.Size = new System.Drawing.Size(171, 20);
            this.tbPanjang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stok";
            // 
            // tbGramasi
            // 
            this.tbGramasi.Location = new System.Drawing.Point(77, 122);
            this.tbGramasi.Name = "tbGramasi";
            this.tbGramasi.Size = new System.Drawing.Size(171, 20);
            this.tbGramasi.TabIndex = 10;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(77, 153);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(171, 20);
            this.tbStok.TabIndex = 11;
            // 
            // InputKain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 204);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbGramasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPanjang);
            this.Controls.Add(this.tbLot);
            this.Controls.Add(this.jenisKainComboBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputKain";
            this.Text = "InputKain";
            this.Load += new System.EventHandler(this.InputKain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox jenisKainComboBox;
        private System.Windows.Forms.TextBox tbLot;
        private System.Windows.Forms.TextBox tbPanjang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGramasi;
        private System.Windows.Forms.TextBox tbStok;
    }
}