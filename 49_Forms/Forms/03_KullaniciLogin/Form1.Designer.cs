namespace _03_KullaniciLogin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txt_AdSoyad = new TextBox();
            lst_Listele = new ListBox();
            btn_Ekle = new Button();
            btn_GirisYap = new Button();
            txt_Password = new TextBox();
            txt_Kad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_AdSoyad);
            groupBox1.Controls.Add(lst_Listele);
            groupBox1.Controls.Add(btn_Ekle);
            groupBox1.Controls.Add(btn_GirisYap);
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(txt_Kad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(992, 567);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txt_AdSoyad
            // 
            txt_AdSoyad.Location = new Point(619, 156);
            txt_AdSoyad.Name = "txt_AdSoyad";
            txt_AdSoyad.Size = new Size(190, 29);
            txt_AdSoyad.TabIndex = 4;
            // 
            // lst_Listele
            // 
            lst_Listele.FormattingEnabled = true;
            lst_Listele.ItemHeight = 22;
            lst_Listele.Location = new Point(505, 34);
            lst_Listele.Name = "lst_Listele";
            lst_Listele.Size = new Size(439, 92);
            lst_Listele.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            btn_Ekle.Location = new Point(619, 202);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(190, 31);
            btn_Ekle.TabIndex = 5;
            btn_Ekle.Text = "Ekle";
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.Location = new Point(196, 171);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(152, 37);
            btn_GirisYap.TabIndex = 2;
            btn_GirisYap.Text = "Giriş Yap";
            btn_GirisYap.UseVisualStyleBackColor = true;
            btn_GirisYap.Click += btn_GirisYap_Click;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(196, 109);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(152, 29);
            txt_Password.TabIndex = 1;
            // 
            // txt_Kad
            // 
            txt_Kad.Location = new Point(196, 63);
            txt_Kad.Name = "txt_Kad";
            txt_Kad.Size = new Size(152, 29);
            txt_Kad.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 112);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 0;
            label2.Text = "Şifreniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 159);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 64);
            label1.Name = "label1";
            label1.Size = new Size(147, 22);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adınız:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 567);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Password;
        private TextBox txt_Kad;
        private Label label2;
        private Label label1;
        private TextBox txt_AdSoyad;
        private ListBox lst_Listele;
        private Button btn_Ekle;
        private Button btn_GirisYap;
        private Label label3;
    }
}
