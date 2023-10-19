namespace KafeOnline6
{
    partial class UrunlerForm
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
            label1 = new Label();
            label2 = new Label();
            txtUrunAd = new TextBox();
            nudBirimFiyat = new NumericUpDown();
            btnEkle = new Button();
            dgvUrunler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "Birim Fiyat (₺)";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(12, 33);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(230, 23);
            txtUrunAd.TabIndex = 2;
            // 
            // nudBirimFiyat
            // 
            nudBirimFiyat.Location = new Point(270, 33);
            nudBirimFiyat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudBirimFiyat.Name = "nudBirimFiyat";
            nudBirimFiyat.Size = new Size(106, 23);
            nudBirimFiyat.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(413, 12);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(123, 44);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvUrunler
            // 
            dgvUrunler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(10, 68);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowTemplate.Height = 25;
            dgvUrunler.Size = new Size(781, 378);
            dgvUrunler.TabIndex = 5;
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvUrunler);
            Controls.Add(btnEkle);
            Controls.Add(nudBirimFiyat);
            Controls.Add(txtUrunAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)nudBirimFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUrunAd;
        private NumericUpDown nudBirimFiyat;
        private Button btnEkle;
        private DataGridView dgvUrunler;
    }
}