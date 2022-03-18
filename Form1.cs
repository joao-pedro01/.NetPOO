namespace ExemploPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            //(string _nome, string _rg, string _cpf, string _email)
            string nome = txtNome.Text;

            Pessoa pessoa = new Pessoa(txtNome.Text, txtRg.Text, txtCpf.Text, txtEmail.Text);

            ExibirObj(pessoa);
        }
        
        public void ExibirObj(Pessoa pessoa)
        {
            label1.Text = "\nNome: " + pessoa.NOME + "\nE-mail: " + pessoa.EMAIL + "\nRG: " + pessoa.RG + "\nCPF: " + pessoa.CPF;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}