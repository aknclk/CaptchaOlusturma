namespace CaptchaOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] karakter1 = { "a", "b", "c", "e", "g", "ö", "p", "m", "w", "+", "/", "ü", "Ü", "?" };
            string[] karakter2 = { "A", "B", "C", "E", "G", "Ö", "P", "M", "W", "*", "+", "-", "?" };
            string[] karakter3 = { "-", "+", ";", "/", "?", "#", "R", "X", "x", "Y", "z", "Q", "a", "A", "b", "B", "Ç", "c" };

            Random rndm = new Random();
            int k1, k2, k3, k4, k5;
            k1 = rndm.Next(0, karakter1.Length);
            k2 = rndm.Next(0, 9);
            k3 = rndm.Next(0, karakter3.Length);
            k4 = rndm.Next(0, 9);
            k5 = rndm.Next(0, karakter2.Length);

            label1.Text = karakter1[k1].ToString();
            label2.Text = k2.ToString();
            label3.Text = karakter3[k3].ToString();
            label4.Text = k4.ToString();
            label5.Text = karakter2[k5].ToString();

            kontrolcu.Text = label1.Text + label2.Text + label3.Text + label4.Text + label5.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kontrolcu.Text)
            {
                MessageBox.Show("Baþarýlý!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
            else
            {
                MessageBox.Show("Hatalý giriþ yaptýnýz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}