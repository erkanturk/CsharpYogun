namespace _02_Basit_HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IslemYap_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc = 0;
            if (cmb_Islem.Text=="-")
            {
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1-sayi2;
                lst_Listele.Items.Add(sonuc.ToString());
            }
            else if (cmb_Islem.Text=="+")
            {
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1+sayi2;
                lst_Listele.Items.Add(sonuc.ToString());
            }
            else if (cmb_Islem.Text=="*")
            {
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1*sayi2;
                lst_Listele.Items.Add(sonuc.ToString());
            }
            else if (cmb_Islem.Text=="/")
            {
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                if (sayi2==0)
                {
                    MessageBox.Show("S�f�ra b�l�nme hatas�");
                }
                else
                {
                    sonuc=sayi1/sayi2;
                    lst_Listele.Items.Add(sonuc.ToString());
                }
            }
            else if (cmb_Islem.Text=="%")
            {
                sayi1=Convert.ToDouble(mtxt_sayi1.Text);
                sayi2=Convert.ToDouble(mtxt_sayi2.Text);
                sonuc=sayi1%sayi2;
                lst_Listele.Items.Add((sonuc.ToString()));
            }
            else
            {
                MessageBox.Show("Hatal� ��lem se�imi");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            lst_Listele.Items.Clear();
        }
    }
}
