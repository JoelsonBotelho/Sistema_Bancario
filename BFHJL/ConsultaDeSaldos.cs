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
    public partial class ConsultaDeSaldos : Form
    {
        public ConsultaDeSaldos()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lstListaSaldo.Items.Clear();
             try
            {
                if (Banco.Nomes.Count - 1 >= int.Parse(txtPesquisar.Text) - 1 && int.Parse(txtPesquisar.Text) - 1 >= 0)
                {
                    if (Banco.Senhas[int.Parse(txtPesquisar.Text) - 1] == txtSenha.Text)
                        lstListaSaldo.Items.Add(Banco.Saldos[int.Parse(txtPesquisar.Text) - 1] + " Kz");
                    else
                        MessageBox.Show("Senha incorreta");
                }

                else
                {
                   lstListaSaldo.Items.Add("0 Kz");
                }
            }
            catch (FormatException)
            {
                foreach (string item in Banco.Nomes)
                    if (item.Contains(txtPesquisar.Text))
                    {
                        if (Banco.Senhas[Banco.Nomes.IndexOf(item)] == txtSenha.Text)
                            lstListaSaldo.Items.Add(Banco.Saldos[Banco.Nomes.IndexOf(item)] + " Kz");
                        else
                            MessageBox.Show("Senha Incorreta");
                    }
            }
             if (txtPesquisar.Text == "0" || txtPesquisar.Text == " ")
             {
                 lstListaSaldo.Items.Add("0 Kz");
             }
        }
    }
}
