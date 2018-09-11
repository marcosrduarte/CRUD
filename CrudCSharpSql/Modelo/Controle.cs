using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpSql.Modelo
{
    public class Controle
    {
        public String mensagem;
        public void CadastrarPessoa(List<String> dadosPessoa)
        {
            this.mensagem = "";

            Validacao validacao = new Validacao();
            validacao.ValidarDados(dadosPessoa);

            if (validacao.mensagem.Equals(""))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = dadosPessoa[1];
                pessoa.rg = dadosPessoa[2];
                pessoa.cpf = dadosPessoa[3];

                DAL.PessoaDAO pessoaDAO = new DAL.PessoaDAO();
                pessoaDAO.CadastrarPessoa(pessoa);
                this.mensagem = pessoaDAO.mensagem;
            }

            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
