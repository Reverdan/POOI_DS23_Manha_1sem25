using Calculadora.modelo;

namespace Calculadora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Calcular(String operacao)
        {
            Controle controle = new Controle();
            controle.executar(txbPrimeiroNumero.Text, txbSegundoNumero.Text, operacao);
            lblResultado.Text = controle.Mensagem;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calcular("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calcular("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calcular("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calcular("/");
        }
    }
}
