using ClassLibrary1;

namespace HastaneProje
{
    public partial class GirisForm : Form
    {
        public static Hastane hastane= new Hastane();

        public GirisForm()
        {
            InitializeComponent();
            comboBoxRol.Items.Add("Hasta");
            comboBoxRol.Items.Add("Doktor");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string rol = comboBoxRol.Text;

            if (rol == "Hasta")
            {
                Hasta h = new Hasta("Hasta", txtSifre.Text);
                HastaForm hf = new HastaForm(hastane, h);
                hf.Show();
                this.Hide();
            }
            else if (rol == "Doktor")
            {
                DoktorForm df = new DoktorForm(hastane);
                df.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen giriþ tipi seçiniz");
            }
        }


    }
}
