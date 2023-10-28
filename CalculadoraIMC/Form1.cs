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

            resultado = peso / Math.Pow(altura,2);

            if (resultado > 0 )
            {

            }






        }
    }
}