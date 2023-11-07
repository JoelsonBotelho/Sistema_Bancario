using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BFHJL
{
    public partial class ControleDeClientes : Form
    {
        public ControleDeClientes()
        {
            InitializeComponent();
        }
        
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaClientes listaGeral = new ListaClientes();
            listaGeral.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarClientes pesquisarClientes = new PesquisarClientes();
            pesquisarClientes.Show();
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            TransferenciaBancaria transBancaria = new TransferenciaBancaria();
            transBancaria.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDeSaldos consulta = new ConsultaDeSaldos();
            consulta.Show();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            DepositoSaque depositoLevantar = new DepositoSaque();
            depositoLevantar.Show();
        }
    }
}
