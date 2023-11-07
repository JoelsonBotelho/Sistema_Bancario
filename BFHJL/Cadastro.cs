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
    public partial class Cadastro : Form
    {
        int numConta=0;
        float saldo;
            public Cadastro()
            {
                InitializeComponent();
            }
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                for ( int i = 0; i< 1; i++)
                {
                    numConta = numConta+1;
                    Banco.Numeros.Add(numConta);
                }
            string nomes = txtNome.Text.ToString();
            Banco.Nomes.Add(txtNome.Text);
            Banco.Senhas.Add(txtSenha.Text);
            saldo = float.Parse(txtSaldoInicial.Text);
            Banco.Saldos.Add(saldo);
            MessageBox.Show("O senhor (a): "+ nomes +" foi Cadastrado com Saldo inicial de "+saldo+" Kz");
            txtNome.Text=("Digite o Nome");
            txtSaldoInicial.Text = ("Digite o Saldo");
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            numConta = Banco.Numeros.Count;
        }
    }
}
