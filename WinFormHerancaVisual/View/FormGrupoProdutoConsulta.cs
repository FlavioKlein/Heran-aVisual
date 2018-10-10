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

namespace WinFormHerancaVisual.View
{
    public partial class FormGrupoProdutoConsulta : Form
    {
        public GrupoProduto grupoSelecionado;
        private readonly SisDBContext sisDBContext;
        private List<GrupoProduto> listaGrupo;


        public FormGrupoProdutoConsulta(SisDBContext sisDBContext)
        {
            InitializeComponent();

            this.sisDBContext = sisDBContext;

            listaGrupo = (from GrupoProduto in sisDBContext.GrupoProduto select GrupoProduto).ToList();

            dataGridViewGrupo.DataSource = listaGrupo;
            dataGridViewGrupo.Refresh();
            grupoSelecionado = null;
            cbCampo.SelectedIndex = 0;
            cbTipoFiltro.SelectedIndex = 0;

        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            if (textFiltro.Text != "")
            {

                if (cbCampo.SelectedIndex == 0)
                {
                    int codigo = int.Parse(textFiltro.Text, 0);
                    listaGrupo = sisDBContext.GrupoProduto
                        .Where(b => b.ID.Equals(codigo)).ToList();
                }
                else
                {
                    string comandoSQL = MontaConsulta();
                    listaGrupo = sisDBContext.GrupoProduto.SqlQuery(comandoSQL).ToList();
                }
            }
            else
            {
                listaGrupo = (from GrupoProduto in sisDBContext.GrupoProduto select GrupoProduto).ToList();
            }
            dataGridViewGrupo.DataSource = listaGrupo;
            dataGridViewGrupo.Refresh();
        }

        private string MontaConsulta()
        {
            string comandoSQL = "SELECT * FROM dbo.GrupoProduto";
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

        private void dataGridViewGrupos_DoubleClick(object sender, EventArgs e)
        {
            grupoSelecionado = (dataGridViewGrupo.CurrentRow.DataBoundItem as GrupoProduto);
            this.Close();
        }
    }
}
