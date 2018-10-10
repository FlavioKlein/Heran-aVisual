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
using WinFormHerancaVisual.View;

namespace WinFormHerancaVisual
{
    public partial class FormPrincipal : Form
    {
        private readonly SisDBContext sisDBContext;

        public FormPrincipal(SisDBContext sisDBContext)
        {
            InitializeComponent();
            this.sisDBContext = sisDBContext;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUDCliente umFormCRUDCliente = new FormCRUDCliente(sisDBContext);
            umFormCRUDCliente.MdiParent = this;
            umFormCRUDCliente.Show();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 umFormTeste = new Form1(sisDBContext);
            umFormTeste.MdiParent = this;
            umFormTeste.Show();
        }     

        private void barraDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = barraDeFerramentasToolStripMenuItem.Checked;
        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = barraDeStatusToolStripMenuItem.Checked;
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripButtonCliente_Click(object sender, EventArgs e)
        {
            clienteToolStripMenuItem_Click(sender, e);
        }

        private void grupoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUDGrupoProduto umFormCRUDGrupoProduto = new FormCRUDGrupoProduto(sisDBContext);
            umFormCRUDGrupoProduto.MdiParent = this;
            umFormCRUDGrupoProduto.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            grupoDeProdutosToolStripMenuItem_Click(sender, e);
        }
    }
}
