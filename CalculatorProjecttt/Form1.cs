namespace CalculatorProjecttt
{
    public partial class Form1 : Form
    {
        byte _sayac = 0;
        bool _ekranTemizlenecekMi = false;
        decimal _sonuc;
        decimal _ilkSayi;
        decimal _ikinciSayi;
        char _operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEkran.Enabled = false;
            txtEkran.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _ekranTemizlenecekMi = true;
            if (_ekranTemizlenecekMi == true)
            {
                txtEkran.Text = "0";
                _ekranTemizlenecekMi = false;
            }
        }

        private void NumberButtons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "";
            }

            if (_ekranTemizlenecekMi == true)
            {
                txtEkran.Text = "";
                _ekranTemizlenecekMi = false;
            }
            txtEkran.Text += btn.Text;
        }

        private void OperatorButtons(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _ilkSayi = Convert.ToDecimal(txtEkran.Text);
            _ekranTemizlenecekMi = true;
            _operator = Convert.ToChar(btn.Text);
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text != "0")
            {
                try
                {
                    _ikinciSayi = Convert.ToDecimal(txtEkran.Text);
                    switch (_operator)
                    {

                        case '+':
                            _sonuc = _ilkSayi + _ikinciSayi;
                            _ekranTemizlenecekMi = true;
                            break;
                        case '-':
                            _sonuc = _ilkSayi - _ikinciSayi;
                            _ekranTemizlenecekMi = true;
                            break;
                        case '*':
                            _sonuc = _ilkSayi * _ikinciSayi;
                            _ekranTemizlenecekMi = true;
                            break;
                        case '/':
                            _sonuc = _ilkSayi / _ikinciSayi;
                            _ekranTemizlenecekMi = true;
                            break;
                    }
                    txtEkran.Text = _sonuc.ToString();
                    lstSonuc.Items.Add(++_sayac + ". " + _sonuc);
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show("Payda sýfýr olamaz...\nHata Kodu:" + ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilinmeyen Hata...\nHata Kodu:" + ex);
                }

            }
        }

        private void btnArtiEksi_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text != "0")
            {
                // Mevcut sayýnýn iþaretini deðiþtir
                decimal currentNumber = Convert.ToDecimal(txtEkran.Text);
                currentNumber = -currentNumber;

                // Yeni sayýyý ekrana yaz
                txtEkran.Text = currentNumber.ToString();
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.Length > 0)
            {
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
                
                if (txtEkran.Text.Length == 0)
                {
                    txtEkran.Text = "0";
                }
            }
        }
    }
}
