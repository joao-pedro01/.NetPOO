namespace ExemploPOO
{
    public partial class Form1 : Form
    {
        private TIPOPESSOA tipo;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;// Inicia o código em tela cheia
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
            bool validaDados = validadados();

            if (objeto.GetType() == aluno.GetType() || validaDados)
            {
                aluno = (Aluno)objeto;
                texto = $"\nNome: { aluno.NOME} \nE - mail: { aluno.EMAIL} \nRG: {aluno.RG} \nCPF: {aluno.CPF} \nRA: {aluno.RA} \nCurso: {aluno.CURSO}";

                label1.Text = texto;
                //label1.Text = "\nNome: " + aluno.NOME + "\nE-mail: " + aluno.EMAIL + "\nRG: " + aluno.RG + "\nCPF: " + aluno.CPF + "\nRA: " + aluno.RA + "\nCurso: " + aluno.CURSO;

                // no geral toda vez que tiver queries, conversão e/ou chamada de recurso externo, utilizamos cry cath
                string diretorio = @"c:\exemplo";
                if (!Directory.Exists(diretorio))
                {
                    string[] linha = { aluno.NOME, aluno.EMAIL, aluno.RG, aluno.CPF, aluno.RA, aluno.CURSO };
                    try
                    {
                        Directory.CreateDirectory(diretorio);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao criar o diretório" + e.Message);
                    }

                    try
                    {
                        File.WriteAllLines($"{diretorio}\\exemplo.txt", linha);
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Erro ao criar o arquivo" + e.Message);
                    }

                    MessageBox.Show("Aluno cadastrado com sucesso!!! ");
                }
            }

            //pessoa = new Pessoa();
        }

        private bool validadados()
        {
            string mensagem = "";
            bool result = true;

            if (String.IsNullOrEmpty(txtNome.Text) || txtNome.Text.Length == 0)
            {
                mensagem += "O campo NOME não pode estar vazio";
                
                result = false;
            }
            if (String.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text.Length == 0)
            {
                mensagem += "\nO campo EMAIL não pode estar vazio";
                result = false;
            }
            if (!txtEmail.Text.Contains("@"))
            {
                mensagem += "\nUtilize um e-mail válido!";
                result = false;
            }
            MessageBox.Show(mensagem, "Erro ao Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return result;
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