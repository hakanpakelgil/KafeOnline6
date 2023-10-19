namespace KafeOnline6
{
    partial class SiparisForm
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
            dgvDetaylar = new DataGridView();
            label2 = new Label();
            cboUrun = new ComboBox();
            nudAdet = new NumericUpDown();
            btnDetayEkle = new Button();
            cboMasaNo = new ComboBox();
            label3 = new Label();
            btnMasaTasi = new Button();
            btnSiparisIptal = new Button();
            btnOdemeAl = new Button();
            btnAnasayfayaDon = new Button();
            lblMasaNo = new Label();
            label5 = new Label();
            lblOdemeTutari = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(12, 82);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.Size = new Size(451, 356);
            dgvDetaylar.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // cboUrun
            // 
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(15, 35);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(206, 23);
            cboUrun.TabIndex = 2;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(238, 36);
            nudAdet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(116, 23);
            nudAdet.TabIndex = 3;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDetayEkle
            // 
            btnDetayEkle.Location = new Point(370, 12);
            btnDetayEkle.Name = "btnDetayEkle";
            btnDetayEkle.Size = new Size(93, 57);
            btnDetayEkle.TabIndex = 4;
            btnDetayEkle.Text = "EKLE";
            btnDetayEkle.UseVisualStyleBackColor = true;
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(575, 38);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(98, 23);
            cboMasaNo.TabIndex = 6;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(575, 11);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 5;
            label3.Text = "Masa No:";
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Location = new Point(684, 12);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(104, 57);
            btnMasaTasi.TabIndex = 7;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            // 
            // btnSiparisIptal
            // 
            btnSiparisIptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSiparisIptal.BackColor = Color.Red;
            btnSiparisIptal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisIptal.ForeColor = SystemColors.Control;
            btnSiparisIptal.Location = new Point(494, 324);
            btnSiparisIptal.Name = "btnSiparisIptal";
            btnSiparisIptal.Size = new Size(136, 57);
            btnSiparisIptal.TabIndex = 12;
            btnSiparisIptal.Text = "SİPARİŞ İPTAL";
            btnSiparisIptal.UseVisualStyleBackColor = false;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.BackColor = Color.Lime;
            btnOdemeAl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.ForeColor = SystemColors.Control;
            btnOdemeAl.Location = new Point(656, 324);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(132, 57);
            btnOdemeAl.TabIndex = 13;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = false;
            // 
            // btnAnasayfayaDon
            // 
            btnAnasayfayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayfayaDon.BackColor = Color.Yellow;
            btnAnasayfayaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnasayfayaDon.ForeColor = Color.FromArgb(192, 0, 0);
            btnAnasayfayaDon.Location = new Point(494, 387);
            btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            btnAnasayfayaDon.Size = new Size(294, 51);
            btnAnasayfayaDon.TabIndex = 14;
            btnAnasayfayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.FromArgb(255, 128, 0);
            lblMasaNo.Font = new Font("Segoe UI Semibold", 96F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = SystemColors.ControlLight;
            lblMasaNo.Location = new Point(494, 82);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(294, 167);
            lblMasaNo.TabIndex = 9;
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(494, 258);
            label5.Name = "label5";
            label5.Size = new Size(136, 54);
            label5.TabIndex = 10;
            label5.Text = "Ödeme Tutarı:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOdemeTutari
            // 
            lblOdemeTutari.Anchor = AnchorStyles.Right;
            lblOdemeTutari.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOdemeTutari.Location = new Point(636, 258);
            lblOdemeTutari.Name = "lblOdemeTutari";
            lblOdemeTutari.Size = new Size(152, 54);
            lblOdemeTutari.TabIndex = 11;
            lblOdemeTutari.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOdemeTutari);
            Controls.Add(label5);
            Controls.Add(lblMasaNo);
            Controls.Add(btnAnasayfayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(btnSiparisIptal);
            Controls.Add(btnMasaTasi);
            Controls.Add(cboMasaNo);
            Controls.Add(label3);
            Controls.Add(btnDetayEkle);
            Controls.Add(nudAdet);
            Controls.Add(cboUrun);
            Controls.Add(label2);
            Controls.Add(dgvDetaylar);
            Controls.Add(label1);
            MinimumSize = new Size(816, 489);
            Name = "SiparisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvDetaylar;
        private Label label2;
        private ComboBox cboUrun;
        private NumericUpDown nudAdet;
        private Button btnDetayEkle;
        private ComboBox cboMasaNo;
        private Label label3;
        private Button btnMasaTasi;
        private Button btnSiparisIptal;
        private Button btnOdemeAl;
        private Button btnAnasayfayaDon;
        private Label lblMasaNo;
        private Label label5;
        private Label lblOdemeTutari;
    }
}