using NumeroPrimoManha.modelo;

namespace NumeroPrimoManha
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero.Text);
            lblResposta.Text = controle.mensagem;
        }
    }
}
