namespace _02_Basit_HesapMakinesi
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
            label1 = new Label();
            label2 = new Label();
            mtxt_sayi1 = new MaskedTextBox();
            mtxt_sayi2 = new MaskedTextBox();
            cmb_Islem = new ComboBox();
            label3 = new Label();
            lst_Listele = new ListBox();
            btn_IslemYap = new Button();
            btn_Temizle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(395, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 0;
            label1.Text = "1.Sayi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(395, 82);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 0;
            label2.Text = "2.Sayi";
            // 
            // mtxt_sayi1
            // 
            mtxt_sayi1.Location = new Point(452, 35);
            mtxt_sayi1.Mask = "000000000";
            mtxt_sayi1.Name = "mtxt_sayi1";
            mtxt_sayi1.Size = new Size(119, 23);
            mtxt_sayi1.TabIndex = 1;
            mtxt_sayi1.ValidatingType = typeof(int);
            // 
            // mtxt_sayi2
            // 
            mtxt_sayi2.Location = new Point(452, 82);
            mtxt_sayi2.Mask = "000000000";
            mtxt_sayi2.Name = "mtxt_sayi2";
            mtxt_sayi2.Size = new Size(119, 23);
            mtxt_sayi2.TabIndex = 1;
            mtxt_sayi2.ValidatingType = typeof(int);
            // 
            // cmb_Islem
            // 
            cmb_Islem.FormattingEnabled = true;
            cmb_Islem.Items.AddRange(new object[] { "+", "-", "*", "/", "%" });
            cmb_Islem.Location = new Point(451, 130);
            cmb_Islem.Name = "cmb_Islem";
            cmb_Islem.Size = new Size(121, 23);
            cmb_Islem.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(375, 132);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 0;
            label3.Text = "İşleminiz";
            // 
            // lst_Listele
            // 
            lst_Listele.FormattingEnabled = true;
            lst_Listele.ItemHeight = 15;
            lst_Listele.Location = new Point(620, 37);
            lst_Listele.Name = "lst_Listele";
            lst_Listele.Size = new Size(204, 199);
            lst_Listele.TabIndex = 3;
            // 
            // btn_IslemYap
            // 
            btn_IslemYap.Location = new Point(450, 174);
            btn_IslemYap.Name = "btn_IslemYap";
            btn_IslemYap.Size = new Size(121, 30);
            btn_IslemYap.TabIndex = 4;
            btn_IslemYap.Text = "İşlem";
            btn_IslemYap.UseVisualStyleBackColor = true;
            btn_IslemYap.Click += btn_IslemYap_Click;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Location = new Point(452, 231);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(121, 30);
            btn_Temizle.TabIndex = 4;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Yapay_Zeka_ile_Uretilen_Gorsel_ve_Videolari_Ayirt_Etme_Yontemleri;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(836, 624);
            Controls.Add(btn_Temizle);
            Controls.Add(btn_IslemYap);
            Controls.Add(lst_Listele);
            Controls.Add(cmb_Islem);
            Controls.Add(mtxt_sayi2);
            Controls.Add(mtxt_sayi1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox mtxt_sayi1;
        private MaskedTextBox mtxt_sayi2;
        private ComboBox cmb_Islem;
        private Label label3;
        private ListBox lst_Listele;
        private Button btn_IslemYap;
        private Button btn_Temizle;
    }
}
