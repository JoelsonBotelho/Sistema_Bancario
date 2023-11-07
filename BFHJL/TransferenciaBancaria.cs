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
    public partial class TransferenciaBancaria : Form
    {
        float Saldo, SaldoTirar, SaldoAdd, SaldoPor, SaldoTotal;
        public TransferenciaBancaria()
        {
            InitializeComponent();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            lstNomeRetirar.Items.Clear();
            lstSaldoBancarioRetirar.Items.Clear();
            lstNomePor.Items.Clear();
            lstSaldoBancarioPor.Items.Clear();
            try
            {
                if (Banco.Nomes.Count - 1 >= int.Parse(txtNomeRetirar.Text) - 1 && int.Parse(txtNomeRetirar.Text) - 1 >= 0)
                {
                    if (Banco.Senhas[int.Parse(txtNomeRetirar.Text) - 1] != txtSenha.Text)
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                    if (Banco.Senhas[int.Parse(txtNomeRetirar.Text) - 1] == txtSenha.Text)
                    {
                        SaldoTirar = float.Parse(txtSaldoTrans.Text);
                        lstNomeRetirar.Items.Add(Banco.Nomes[int.Parse(txtNomeRetirar.Text) - 1]);
                        lstSaldoBancarioRetirar.Items.Add(Banco.Saldos[int.Parse(txtNomeRetirar.Text) - 1] + " Kz");
                        if ((Banco.Saldos[int.Parse(txtNomeRetirar.Text) - 1]) >= SaldoTirar)
                        {

                            Saldo = (Banco.Saldos[int.Parse(txtNomeRetirar.Text) - 1]);
                            SaldoTotal = Saldo - SaldoTirar;
                            Banco.Saldos.Add(Banco.Saldos[int.Parse(txtNomeRetirar.Text) - 1] = SaldoTotal);
                            lstSaldoBancarioRetirar.Items.Clear();
                            lstSaldoBancarioRetirar.Items.Add(Banco.Saldos[int.Parse(txtNomeRetirar.Text) - 1] + " Kz");

                            if (Banco.Nomes.Count - 1 >= int.Parse(txtNomePor.Text) - 1 && int.Parse(txtNomePor.Text) - 1 >= 0)
                            {
                                lstNomePor.Items.Clear();
                                lstNomePor.Items.Add(Banco.Nomes[int.Parse(txtNomePor.Text) - 1]);
                                SaldoPor = (Banco.Saldos[int.Parse(txtNomePor.Text) - 1]);
                                SaldoAdd = SaldoPor + SaldoTirar;
                                Banco.Saldos.Add(Banco.Saldos[int.Parse(txtNomePor.Text) - 1] = SaldoAdd);
                                lstSaldoBancarioPor.Items.Clear();
                                lstSaldoBancarioPor.Items.Add(Banco.Saldos[int.Parse(txtNomePor.Text) - 1] + " Kz");
                            }
                            else
                            {
                                lstNomePor.Items.Add("Nenhuma referência encontrada");
                                lstSaldoBancarioPor.Items.Add("0 Kz");
                                MessageBox.Show("Saldo Insuficiente");
                            }
                        }
                    }
                    else
                    {
                        if (Banco.Nomes.Count - 1 >= int.Parse(txtNomePor.Text) - 1 && int.Parse(txtNomePor.Text) - 1 >= 0)
                        {
                            lstNomePor.Items.Clear();
                            lstSaldoBancarioPor.Items.Clear();
                            lstNomePor.Items.Add(Banco.Nomes[int.Parse(txtNomePor.Text) - 1]);
                            lstSaldoBancarioPor.Items.Add(Banco.Saldos[int.Parse(txtNomePor.Text) - 1] + " Kz");
                        }
                        else
                        {
                            lstNomePor.Items.Add("Nenhuma referência encontrada");
                            lstSaldoBancarioPor.Items.Add("0 Kz");
                        }
                    }
                }
                else
                {
                    if (Banco.Nomes.Count - 1 >= int.Parse(txtNomePor.Text) - 1 && int.Parse(txtNomePor.Text) - 1 >= 0)
                    {
                        lstNomePor.Items.Clear();
                        lstSaldoBancarioPor.Items.Clear();
                        lstNomePor.Items.Add(Banco.Nomes[int.Parse(txtNomePor.Text) - 1]);
                        lstSaldoBancarioPor.Items.Add(Banco.Saldos[int.Parse(txtNomePor.Text) - 1] + " Kz");
                    }
                    else
                    {
                        lstNomePor.Items.Add("Nenhuma referência encontrada");
                        lstSaldoBancarioPor.Items.Add("0 Kz");
                    }
                }
            }
            catch (FormatException)
            {
                foreach (string item in Banco.Nomes)
                {
                    if (item.Contains(txtNomeRetirar.Text))
                    {
                        lstNomeRetirar.Items.Add("Digite O Número Da Sua Conta Senhor (a): "+ item);
                        lstSaldoBancarioRetirar.Items.Add("Sem Saldo Contablístico");
                    }
                }
                foreach (string item in Banco.Nomes)
                {
                    if (item.Contains(txtNomePor.Text))
                    {
                        lstNomePor.Items.Add("Digite O Número Da Sua Conta Senhor (a): "+ item);
                        lstSaldoBancarioPor.Items.Add("Sem Saldo Contablístico");
                    }
                }
            }
            if (lstNomeRetirar.Items.Count == 0 || txtNomeRetirar.Text == " ")
            {
                lstNomeRetirar.Items.Add("Não existe o Número De Conta");
                lstSaldoBancarioRetirar.Items.Add("0 Kz");
            }
            if (lstNomePor.Items.Count == 0 || txtNomePor.Text == " ")
            {
                lstNomePor.Items.Add("Não existe o Número De Conta");
                lstSaldoBancarioPor.Items.Add("0 Kz");
            }
        }
    }
}