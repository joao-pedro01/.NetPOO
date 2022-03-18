using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Pessoa
    {
        // nome, rg, cpf, email
        protected string nome;
        protected string rg;
        protected string cpf;
        protected string email;

        // construtor sem parâmetros
        public Pessoa()
        {
            this.nome = "";
            this.rg = "";
            this.cpf = "";
            this.email = "";
        }

        // construtor com parâmetros
        /// <summary>
        /// construtor da classe pessoa que recebe parâmetros
        /// </summary>
        /// <param name="_nome">nome da pessoa</param>
        /// <param name="_rg">rg</param>
        /// <param name="_cpf">cpf</param>
        /// <param name="_email">email</param>
        public Pessoa(string _nome, string _rg, string _cpf, string _email)
        {
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
            this.email = _email;
        }

        // metodo para recuperar dados
        public Pessoa getPessoa()
        {
            // instanciamos a classe pessoa usando o construtor vazio
            Pessoa pessoa = new Pessoa();
            // alimentamos os atributos
            pessoa.nome = this.nome;
            pessoa.rg = this.rg;
            pessoa.cpf = this.cpf;
            pessoa.email = this.email;


            return pessoa;
        }

        public string NOME
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string RG
        {
            get { return this.rg; }
            set { this.rg = value; }
        }

        public string CPF
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        public string EMAIL
        {
            get { return this.email; }
            set { this.email = value; }
        }
        

    }
}
