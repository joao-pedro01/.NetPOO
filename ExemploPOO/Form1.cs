namespace ExemploPOO
{
    public partial class Form1 : Form
    {
        private TIPOPESSOA tipo;

        public Form1()
        {
            InitializeComponent();
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

        private void rbAluno_CheckedChanged(object sender, EventArgs e)
        {
            validaPessoa();
        }

        private void rbProfessor_CheckedChanged(object sender, EventArgs e)
        {
            validaPessoa();
        }

        private void validaPessoa()
        {
            const int aluno = 1;
            const int professor = 2;

            if(rbAluno.Checked == true)
            {
                pnProfessor.Visible = false;
                pnAluno.Visible = true;
                this.tipo = TIPOPESSOA.ALUNO;
            }
            else if(rbProfessor.Checked == true)
            {
                pnProfessor.Visible = true;
                pnAluno.Visible = false;
                this.tipo = TIPOPESSOA.PROFESSOR;
            }
        }

        private void pnProfessor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}