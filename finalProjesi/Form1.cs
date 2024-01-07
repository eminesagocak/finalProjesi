namespace finalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public List<finalProjesi.Kullanici> List_Kullanici = new List<finalProjesi.Kullanici>();
        static public List<finalProjesi.ogrenci> List_ogrenci = new List<finalProjesi.ogrenci>();
        static public List<finalProjesi.Ogretmen> List_Ogretmen = new List<finalProjesi.Ogretmen>();
        private void button1_Click(object sender, EventArgs e)
        {
            finalProjesi.Kullanici entity = new finalProjesi.Kullanici();
            entity.Id = Guid.NewGuid();
            entity.KullaniciAdi = textBox1.Text;
            entity.KullaniciId = int.Parse(textBox2.Text);
            entity.KullaniciMail = textBox3.Text;
            List_Kullanici.Add(entity);

            Kullanici_Combo();

            MessageBox.Show("Kullanýcý Eklenmiþtir.");
        }

        public void Kullanici_Combo()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < List_Kullanici.Count; i++)
            {
                finalProjesi.ComboItem item = new finalProjesi.ComboItem();
                item.Text = List_Kullanici[i].Ad;
                item.Text = List_Kullanici[i].KullaniciAdi;
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finalProjesi.ogrenci entity = new finalProjesi.ogrenci();
            entity.Id = Guid.NewGuid();
            entity.SoruSayisi = textBox4.Text;

            listBox2.Items.Add(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            finalProjesi.Ogretmen entity = new finalProjesi.Ogretmen();
            entity.Id = Guid.NewGuid();
            entity.SoruSayisi = textBox5.Text;

            listBox1.Items.Add(textBox5.Text);
        }
    }
}