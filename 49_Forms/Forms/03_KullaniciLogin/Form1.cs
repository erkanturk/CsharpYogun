namespace _03_KullaniciLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_Ekle.Visible = false;//Görünürlüðü gizleme
            lst_Listele.Visible = false;
            txt_AdSoyad.Visible = false;
            label3.Visible = false;
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            txt_Kad.Visible=true;
            txt_Password.Visible=true;
            btn_GirisYap.Visible=true;
            if ((txt_Kad.Text.ToUpper()=="ERKAN" || txt_Kad.Text.ToUpper()=="E")&&txt_Password.Text=="1453")
            {
                txt_Kad.Visible = false;
                txt_Password.Visible = false;
                txt_AdSoyad.Visible=true;//görünürlüðü aç
                btn_GirisYap.Visible = false;
                btn_Ekle.Visible=true;
                label1.Visible=false;
                label2.Visible=false;
                label3.Visible=true;
                lst_Listele.Visible=true;

                MessageBox.Show("Hoþgeldiniz Sayýn "+txt_Kad.Text);
            }
            else
            {
                MessageBox.Show("Hatalý iþlem");
            }

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_AdSoyad.Text))
            {
                txt_AdSoyad.BackColor=Color.White;//Arka plan rengi
                lst_Listele.Items.Add(txt_AdSoyad.Text);
            }
            else
            {
                MessageBox.Show("Boþ alaný doldurunuz");
                txt_AdSoyad.BackColor = Color.Red;
            }
        }
    }
}
