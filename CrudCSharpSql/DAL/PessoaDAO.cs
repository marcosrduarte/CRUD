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
        SqlDataReader dataReader;

        public String mensagem;
        public void CadastrarPessoa(Pessoa pessoa)
        {
            this.mensagem = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Pessoas (nome, rg, cpf) values (@nome, @rg, @cpf)";
            cmd.Parameters.AddWithValue("@nome", pessoa.nome);
            cmd.Parameters.AddWithValue("@rg", pessoa.rg);
            cmd.Parameters.AddWithValue("@cpf", pessoa.cpf);

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
            {
                this.mensagem = "";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"select * from where id  = @id";
                cmd.Parameters.AddWithValue("@id", pessoa.id);
                

                try
                {
                    cmd.Connection = conexaoBD.Conectar();
                    dataReader = cmd.ExecuteReader(); // consultar
                    if (dataReader.HasRows) // verificar se tem dados 
                    {
                        dataReader.Read();
                        pessoa.nome = dataReader["nome"].ToString();
                        pessoa.rg = dataReader["rg"].ToString();
                        pessoa.cpf = dataReader["cpf"].ToString();
                    }
                    else
                    {
                        pessoa.id = 0;
                    }
                    dataReader.Close();
                    conexaoBD.Desconectar();
                    
                }
                catch (SqlException e)
                {

                    this.mensagem = e.ToString();
                }
                return pessoa;

        public List<Pessoa> PesquisarPessoaPorNome(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
