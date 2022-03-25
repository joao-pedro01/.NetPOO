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
            Aluno aluno = new Aluno();
            Animal animal = new Animal();

            if (tipo == TIPOPESSOA.ALUNO)
            {
                aluno = new Aluno() {
                    NOME = txtNome.Text,
                    EMAIL = txtEmail.Text,
                    CPF = txtCpf.Text,
                    CURSO = txtCurso.Text,
                    RA = txtRa.Text,
                    RG = txtRg.Text
                };
            }

            Pessoa pessoa = new Pessoa(txtNome.Text, txtRg.Text, txtCpf.Text, txtEmail.Text);

            ExibirObj(aluno);
        }
        
        //Label text
        public void ExibirObj(Object objeto)
        {
            Aluno aluno = new Aluno();
            Animal animal = new Animal();
            string texto = "";
            if (objeto.GetType() == aluno.GetType())
            {
                aluno = (Aluno)objeto;
                texto = $"\nNome: { aluno.NOME} \nE - mail: { aluno.EMAIL} \nRG: {aluno.RG} \nCPF: {aluno.CPF} \nRA: {aluno.RA} \nCurso: {aluno.CURSO}";

                label1.Text = texto;

                //label1.Text = "\nNome: " + aluno.NOME + "\nE-mail: " + aluno.EMAIL + "\nRG: " + aluno.RG + "\nCPF: " + aluno.CPF + "\nRA: " + aluno.RA + "\nCurso: " + aluno.CURSO;
            }

            //pessoa = new Pessoa();
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
            //forma de uso não indicada
            //const int aluno = 1;
            //const int professor = 2;

            if (rbAluno.Checked == true)
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
    }
}