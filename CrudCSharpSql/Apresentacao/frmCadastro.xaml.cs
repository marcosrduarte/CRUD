using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CrudCSharpSql.Apresentacao
{
    /// <summary>
    /// Interaction logic for frmCadastro.xaml
    /// </summary>
    public partial class frmCadastro : Window
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            List<String> dadosPessoa = new List<string>();
            dadosPessoa.Add("0");
            dadosPessoa.Add(txbNome.Text);
            dadosPessoa.Add(txbRG.Text);
            dadosPessoa.Add(txbCPF.Text);

            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastrarPessoa(dadosPessoa);
            MessageBox.Show(controle.mensagem);
        }
    }
}
