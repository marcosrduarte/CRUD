using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpSql.Modelo
{
    public class Validacao
    {
        public String mensagem;
        public int id;

        public void ValidarDados(List<String> dadosPessoas)
        {
            if (dadosPessoas[1].Length > 30)
                this.mensagem = "Nome com mais de 30 caracteres \n";
            if (dadosPessoas[2].Length > 10)
                this.mensagem += "Rg com mais de 10 caracteres \n";
            if (dadosPessoas[3].Length < 13)
                this.mensagem += "CPF com mais de 13 caracteres \n";

            try
            {
                this.id = Convert.ToInt32(dadosPessoas[0]);
            }
            catch (FormatException e)
            {

                this.mensagem += "ID inválido";
            }
        }

    }
}
