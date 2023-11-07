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
    public partial class PesquisarClientes : Form
    {
        public PesquisarClientes()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lstNome.Items.Clear();
            lstNumConta.Items.Clear();
             try
            {
                if (Banco.Nomes.Count - 1 >= int.Parse(txtPesquisar.Text) - 1 && int.Parse(txtPesquisar.Text) - 1 >= 0)
                {
                    lstNome.Items.Add(Banco.Nomes[int.Parse(txtPesquisar.Text) - 1]);
                    lstNumConta.Items.Add(Banco.Numeros[int.Parse(txtPesquisar.Text) - 1]);
                }

                else
                {
                    lstNome.Items.Add("Não existe o Nome");
                    lstNumConta.Items.Add("Não existe o número da Conta");
                }
            }
            catch (FormatException)
            {
                foreach (string item in Banco.Nomes)
                    if (item.Contains(txtPesquisar.Text))
                    {
                        lstNome.Items.Add(item);
                        lstNumConta.Items.Add(Banco.Numeros[Banco.Nomes.IndexOf(item)]);
                    }
            }


             if (lstNome.Items.Count == 0 || txtPesquisar.Text == " ")
             {
                 lstNome.Items.Add("Nenhuma referência encontrada");
                 lstNumConta.Items.Add("Sem Número de Conta");
             }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }