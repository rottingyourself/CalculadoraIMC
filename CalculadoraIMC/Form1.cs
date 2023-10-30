namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCalculadora_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)

        {   //obter os numeros do form
            double peso, altura, resultado;
            peso = double.Parse(txbPeso.Text);
            altura = double.Parse(txbAltura.Text);

            // verificar se os campos foram preenchidos antes de calcular
            if (string.IsNullOrEmpty(txbPeso.Text) || string.IsNullOrEmpty(txbAltura.Text))
            {
                lblSaude.Text = ("Por favor, digite um valor para o peso e a altura.");
            }
            else
            {
                resultado = peso / Math.Pow(altura, 2);

                if (resultado < 18.6)
                {
                    lblSaude.Text = ("Abaixo do peso");
                }
                else if (resultado >= 18.5 && resultado <= 24.9)
                {
                    lblSaude.Text = ("Peso normal");
                }
                else if (resultado >= 25 && resultado <= 29.9)
                {
                    lblSaude.Text = ("Sobrepeso");
                }
                else if (resultado >= 30 && resultado <= 34.9)
                {
                    lblSaude.Text = ("Obesidade grau I");
                }
                else if (resultado >= 35 && resultado <= 39.9)
                {
                    lblSaude.Text = ("Obesidade grau II(severa)");
                }
                else
                {
                    lblSaude.Text = ("Obesidade grau III(mórbida)");
                }
            }
        }
    }
}

