namespace ExemploPOO
{
    public class Aluno : Pessoa
    {
        private string ra;
        private string curso;

        public Aluno()
        {
            this.nome = "";
            this.rg = "";
            this.cpf = "";
            this.email = "";
            this.ra = "";
            this.curso = "";
        }

        public Aluno(string _ra, string _curso, string _nome, string _rg, string _cpf, string _email)
        {
            this.ra = _ra;
            this.curso = _curso;
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
            this.email = _email;
        }

        //getter setters
        public string RA
        {
            get { return this.ra; }
            set { this.ra = value; }
        }

        public string CURSO
        {
            get { return this.curso; }
            set { this.curso = value; }
        }
    }
}
