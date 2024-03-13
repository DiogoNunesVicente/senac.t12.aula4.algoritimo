namespace WinFormsApp

{   //classe
    public partial class Form1 : Form
    {
        //contrutor da classe
        public Form1()
        {
            //metodo inicializa os componentes
            InitializeComponent();
        }

        private void btnNome_Click(object sender, EventArgs e)
        {
            //exiber mensagem com texto informado
            MessageBox.Show("cliclou no botão nuevo");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicou no botão nuevo");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vc clincou no botão salvar");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vc exclui a system32 :)");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vc clicou nu botao imprima");
        }
    }
}
