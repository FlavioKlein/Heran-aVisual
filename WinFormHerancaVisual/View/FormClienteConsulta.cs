using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormHerancaVisual.Model;

namespace WinFormHerancaVisual
{
    public partial class FormClienteConsulta : Form
    {
        public Cliente clienteSelecionado;
        private readonly SisDBContext sisDBContext;
        private List<Cliente> listaCliente;

        public FormClienteConsulta(SisDBContext sisDBContext)
        {
            InitializeComponent();

            this.sisDBContext = sisDBContext;

            listaCliente = (from Cliente in sisDBContext.Cliente select Cliente).ToList();

            dataGridViewClientes.DataSource = listaCliente;
            dataGridViewClientes.Refresh();
            clienteSelecionado = null;
            cbCampo.SelectedIndex = 0;
            cbTipoFiltro.SelectedIndex = 0;

        }

        private void dataGridViewClientes_DoubleClick(object sender, EventArgs e)
        {
            clienteSelecionado = (dataGridViewClientes.CurrentRow.DataBoundItem as Cliente);
            this.Close();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (textFiltro.Text != "")
            {
                if (cbCampo.SelectedIndex == 0)
                {
                    int codigo = int.Parse(textFiltro.Text, 0);
                    listaCliente = sisDBContext.Cliente
                        .Where(b => b.ID.Equals(codigo)).ToList();
                }
                else
                {
                    string comandoSQL = MontaConsulta();
                    listaCliente = sisDBContext.Cliente.SqlQuery(comandoSQL).ToList();
                }
                dataGridViewClientes.DataSource = listaCliente;
                dataGridViewClientes.Refresh();
            }
        }

        private string MontaConsulta()
        {
            string comandoSQL = "SELECT * FROM dbo.Cliente";
            string parametro = "";
            comandoSQL += " WHERE " + cbCampo.SelectedItem.ToString() + " LIKE ";

            switch (cbTipoFiltro.SelectedIndex)
            {
                case 0:
                    parametro = "'%" + textFiltro.Text + "%'";
                    break;
                case 1:
                    parametro = "'" + textFiltro.Text + "%'";
                    break;
                case 2:
                    parametro = "'%" + textFiltro.Text + "'";
                    break;
                default:
                    parametro = "'%" + textFiltro.Text + "%'";
                    break;
            }
            comandoSQL += parametro;
            return comandoSQL;
        }

    }
}
