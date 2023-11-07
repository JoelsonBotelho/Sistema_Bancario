using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFHJL
{
    public partial class DepositoSaque : Form
    {
        float Saldo, SaldoTirar, SaldoAdd, SaldoPor, SaldoTotal;
        public DepositoSaque()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            lstListaNumConta.Items.Clear();
            lstListaNomes.Items.Clear();
            lstListaSaldo.Items.Clear();
            try
            {
                if (Banco.Nomes.Count - 1 >= int.Parse(txtNome.Text) - 1 && int.Parse(txtNome.Text) - 1 >= 0)
                {
                    Saldo = float.Parse(txtValor.Text);
                    SaldoPor = (Banco.Saldos[int.Parse(txtNome.Text) - 1]);
                    SaldoAdd = SaldoPor + Saldo;
                    Banco.Saldos.Add(Banco.Saldos[int.Parse(txtNome.Text) - 1] = SaldoAdd);
                    lstListaSaldo.Items.Clear();
                    lstListaSaldo.Items.Add(Banco.Saldos[int.Parse(txtNome.Text) - 1] + " Kz");
                    lstListaNomes.Items.Add(Banco.Nomes[int.Parse(txtNome.Text) - 1]);
                    lstListaNumConta.Items.Add(Banco.Numeros[int.Parse(txtNome.Text) - 1]);
                }
                else
                {
                    lstListaNomes.Items.Add("Nenhuma referência encontrada");
                    lstListaSaldo.Items.Add("0 Kz");
                    lstListaNumConta.Items.Add("Sem Número de Conta");
                }
            }
            catch (FormatException)
            {
                foreach (string item in Banco.Nomes)
                {
                    if (item.Contains(txtNome.Text))
                    {
                        lstListaNomes.Items.Add("Conta Encontrada");
                        lstListaSaldo.Items.Add("Sem Saldo Contablístico");
                        lstListaNumConta.Items.Add("Sem Número de Conta");
                        MessageBox.Show("Digite O Número Da Sua Conta Senhor (a): "+ item +"\n Não é Possível fazer Depositar Dinheiro com o Nome da Conta Senhor (a): "+ item);
                    }
                }
            }
                if (lstListaNomes.Items.Count == 0 || txtNome.Text == " ")
                {
                    lstListaNumConta.Items.Add("Não existe o Número De Conta");
                    lstListaSaldo.Items.Add("0 Kz");
                    lstListaNomes.Items.Add("Não existe o Nome");
                }
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {

            lstListaNumConta.Items.Clear();
            lstListaNomes.Items.Clear();
            lstListaSaldo.Items.Clear();
            try
            {
                if (Banco.Nomes.Count - 1 >= int.Parse(txtNome.Text) - 1 && int.Parse(txtNome.Text) - 1 >= 0)
                {
                    if (Banco.Senhas[int.Parse(txtNome.Text) -1] == txtSenha.Text)
                    {
                         Saldo = float.Parse(txtValor.Text);
                        if ((Banco.Saldos[int.Parse(txtNome.Text) - 1]) >= Saldo)
                        {
                            SaldoTirar = (Banco.Saldos[int.Parse(txtNome.Text) - 1]);
                            SaldoTotal = SaldoTirar - Saldo;
                            Banco.Saldos.Add(Banco.Saldos[int.Parse(txtNome.Text) - 1] = SaldoTotal);
                            lstListaSaldo.Items.Clear();
                            lstListaSaldo.Items.Add(Banco.Saldos[int.Parse(txtNome.Text) - 1] + " Kz");
                            lstListaNomes.Items.Add(Banco.Nomes[int.Parse(txtNome.Text) - 1]);
                            lstListaNumConta.Items.Add(Banco.Numeros[int.Parse(txtNome.Text) - 1]);
                        }
                        else
                        {
                            lstListaNomes.Items.Add("Conta encontrada");
                            lstListaNumConta.Items.Add("Número de Conta encontrado");
                            lstListaSaldo.Items.Add("Saldo Inferior ao que deseja levantar");
                            MessageBox.Show("Saldo Insuficiente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
                else
                {
                    lstListaNomes.Items.Add("Nenhuma referência encontrada");
                    lstListaSaldo.Items.Add("0 Kz");
                    lstListaNumConta.Items.Add("Sem Número de Conta");
                }
            }
            catch (FormatException)
            {
                foreach (string item in Banco.Nomes)
                {
                    if (item.Contains(txtNome.Text))
                    {
                        lstListaNomes.Items.Add("Conta Encontrada");
                        lstListaSaldo.Items.Add("Sem Saldo Contablístico");
                        lstListaNumConta.Items.Add("Sem Número de Conta");
                        MessageBox.Show("Digite O Número Da Sua Conta Senhor (a): " + item + "\n Não é Possível fazer Levantar Dinheiro com o Nome da Conta Senhor (a): " + item);
                    }
                }
            }
            if (lstListaNomes.Items.Count == 0 || txtNome.Text == " ")
            {
                lstListaNumConta.Items.Add("Não existe o Número De Conta");
                lstListaSaldo.Items.Add("0 Kz");
                lstListaNomes.Items.Add("Não existe o Nome");
            }
        }
    }
}
