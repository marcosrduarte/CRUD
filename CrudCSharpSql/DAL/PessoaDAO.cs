using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudCSharpSql.Modelo;
using System.Data.SqlClient;

namespace CrudCSharpSql.DAL
{
    public class PessoaDAO : intPessoaDAO
    {
        Conexao conexaoBD = new Conexao();
        public String mensagem;
        public void CadastrarPessoa(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Pessoas (nome, rg, cpf)
                        values 
                        ('teste', '123', '456')";
            try
            {
                cmd.Connection = conexaoBD.Conectar();
                cmd.ExecuteNonQuery();
                conexaoBD.Desconectar();
                this.mensagem = "Pessoa cadastrada com sucesso !";
            }
            catch (SqlException e)
            {

                this.mensagem = e.ToString();
            }
        }

        public void EditarPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPessoa(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public Pessoa PesquisarPessoaPorID(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> PesquisarPessoaPorNome(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
