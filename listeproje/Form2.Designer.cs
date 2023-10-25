namespace listeproje
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ktpblg = new GroupBox();
            btnsecsil = new Button();
            btnsil = new Button();
            btnara = new Button();
            txtara = new TextBox();
            Temizle = new Button();
            sirala = new ListBox();
            ktpek = new GroupBox();
            Kaydet = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mskdtel = new MaskedTextBox();
            dtptrh = new DateTimePicker();
            txtktp = new TextBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            ktpblg.SuspendLayout();
            ktpek.SuspendLayout();
            SuspendLayout();
            // 
            // ktpblg
            // 
            ktpblg.BackColor = Color.Transparent;
            ktpblg.Controls.Add(btnsecsil);
            ktpblg.Controls.Add(btnsil);
            ktpblg.Controls.Add(btnara);
            ktpblg.Controls.Add(txtara);
            ktpblg.Controls.Add(Temizle);
            ktpblg.Controls.Add(sirala);
            ktpblg.Location = new Point(510, 27);
            ktpblg.Name = "ktpblg";
            ktpblg.Size = new Size(278, 357);
            ktpblg.TabIndex = 3;
            ktpblg.TabStop = false;
            ktpblg.Text = "Kitap Kayıt Bilgisi";
            // 
            // btnsecsil
            // 
            btnsecsil.Location = new Point(30, 271);
            btnsecsil.Name = "btnsecsil";
            btnsecsil.Size = new Size(99, 40);
            btnsecsil.TabIndex = 8;
            btnsecsil.Text = "Sil";
            btnsecsil.UseVisualStyleBackColor = true;
            btnsecsil.Click += btnsecsil_Click;
            // 
            // btnsil
            // 
            btnsil.Location = new Point(164, 19);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(108, 39);
            btnsil.TabIndex = 7;
            btnsil.Text = "Arama Sonucuna Göre Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btnara
            // 
            btnara.Location = new Point(99, 22);
            btnara.Name = "btnara";
            btnara.Size = new Size(59, 32);
            btnara.TabIndex = 6;
            btnara.Text = "Ara";
            btnara.UseVisualStyleBackColor = true;
            btnara.Click += btnara_Click;
            // 
            // txtara
            // 
            txtara.Location = new Point(6, 22);
            txtara.Multiline = true;
            txtara.Name = "txtara";
            txtara.PlaceholderText = "Ara";
            txtara.Size = new Size(87, 32);
            txtara.TabIndex = 5;
            // 
            // Temizle
            // 
            Temizle.Location = new Point(164, 271);
            Temizle.Name = "Temizle";
            Temizle.Size = new Size(99, 40);
            Temizle.TabIndex = 4;
            Temizle.Text = "Temizle";
            Temizle.UseVisualStyleBackColor = true;
            Temizle.Click += Temizle_Click;
            // 
            // sirala
            // 
            sirala.FormattingEnabled = true;
            sirala.ItemHeight = 15;
            sirala.Location = new Point(6, 68);
            sirala.Name = "sirala";
            sirala.Size = new Size(272, 199);
            sirala.TabIndex = 0;
            // 
            // ktpek
            // 
            ktpek.BackColor = Color.Transparent;
            ktpek.Controls.Add(Kaydet);
            ktpek.Controls.Add(label5);
            ktpek.Controls.Add(label4);
            ktpek.Controls.Add(label3);
            ktpek.Controls.Add(label2);
            ktpek.Controls.Add(label1);
            ktpek.Controls.Add(mskdtel);
            ktpek.Controls.Add(dtptrh);
            ktpek.Controls.Add(txtktp);
            ktpek.Controls.Add(txtsoyad);
            ktpek.Controls.Add(txtad);
            ktpek.Location = new Point(10, 27);
            ktpek.Name = "ktpek";
            ktpek.Size = new Size(268, 357);
            ktpek.TabIndex = 2;
            ktpek.TabStop = false;
            ktpek.Text = "Kitap Kayıt Ekranı";
            // 
            // Kaydet
            // 
            Kaydet.Location = new Point(118, 282);
            Kaydet.Name = "Kaydet";
            Kaydet.Size = new Size(107, 38);
            Kaydet.TabIndex = 5;
            Kaydet.Text = "Kaydet";
            Kaydet.UseVisualStyleBackColor = true;
            Kaydet.Click += Kaydet_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 200);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 3;
            label5.Text = "Aldığı Tarih  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 168);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefon No  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 139);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Kitap Ad  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 107);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyad  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad  :";
            // 
            // mskdtel
            // 
            mskdtel.Location = new Point(118, 165);
            mskdtel.Mask = "(999) 000-0000";
            mskdtel.Name = "mskdtel";
            mskdtel.Size = new Size(126, 23);
            mskdtel.TabIndex = 2;
            // 
            // dtptrh
            // 
            dtptrh.Location = new Point(118, 194);
            dtptrh.Name = "dtptrh";
            dtptrh.Size = new Size(126, 23);
            dtptrh.TabIndex = 1;
            // 
            // txtktp
            // 
            txtktp.Location = new Point(118, 136);
            txtktp.Name = "txtktp";
            txtktp.PlaceholderText = "Kitap Adını Girin";
            txtktp.Size = new Size(126, 23);
            txtktp.TabIndex = 0;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(118, 107);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.PlaceholderText = "Soyadınızı Girin";
            txtsoyad.Size = new Size(126, 23);
            txtsoyad.TabIndex = 0;
            // 
            // txtad
            // 
            txtad.Location = new Point(118, 78);
            txtad.Multiline = true;
            txtad.Name = "txtad";
            txtad.PlaceholderText = "Adınızı Girin";
            txtad.Size = new Size(126, 23);
            txtad.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Resim1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ktpblg);
            Controls.Add(ktpek);
            Cursor = Cursors.Default;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.NoControl;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Kütüphane";
            ktpblg.ResumeLayout(false);
            ktpblg.PerformLayout();
            ktpek.ResumeLayout(false);
            ktpek.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ktpblg;
        private ListBox sirala;
        private Button Temizle;
        private GroupBox ktpek;
        private Button Kaydet;
        private MaskedTextBox mskdtel;
        private DateTimePicker dtptrh;
        private TextBox txtktp;
        private TextBox txtsoyad;
        private TextBox txtad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnara;
        private TextBox txtara;
        private Button btnsil;
        private Button btnsecsil;
    }
}