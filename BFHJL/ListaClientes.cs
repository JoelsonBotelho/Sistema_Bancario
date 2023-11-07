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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
            foreach (int item in Banco.Numeros)
            {
                lstListaNumConta.Items.Add(item);
            }
            foreach (string item in Banco.Nomes)
            {
                lstListaNomes.Items.Add(item);
            }
        }
    }
}
