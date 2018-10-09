using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormHerancaVisual.Enums;
using WinFormHerancaVisual.Model;

namespace WinFormHerancaVisual.View
{
    public partial class FormCRUDCliente : WinFormHerancaVisual.View.FormCRUDBase
    {
        public FormCRUDCliente()
        {
            InitializeComponent();
        }

        public FormCRUDCliente(SisDBContext sisDBContext) : base(sisDBContext)
        {
            InitializeComponent();
            ConfigurarObjES();
        }

        protected override void BTConsultar_Click(object sender, EventArgs e)
        {
            FormClienteConsulta umFormClienteConsulta = new FormClienteConsulta(sisDBContext);
            umFormClienteConsulta.ShowDialog();
            if (umFormClienteConsulta.clienteSelecionado != null)
            {
                objAtual = umFormClienteConsulta.clienteSelecionado;
                bsDados.DataSource = objAtual;

                ObjToForm();
            }
            AtualizarControlesTela();

            base.BTConsultar_Click(sender, e);
        }

        protected override void BTIncluir_Click(object sender, EventArgs e)
        {
            base.BTIncluir_Click(sender, e);
            objAtual = new Cliente();
            bsDados.DataSource = objAtual;
            tbNome.Focus();
        }

        protected override void BTEditar_Click(object sender, EventArgs e)
        {           
            base.BTEditar_Click(sender, e);            
            tbNome.Focus();
        }
       
        protected override void BTSalvar_Click(object sender, EventArgs e)
        {
            base.BTSalvar_Click(sender, e);
        }

        protected override void BTExcluir_Click(object sender, EventArgs e)
        {
            base.BTExcluir_Click(sender, e);
        }

        protected override void ObjToForm()
        {
            //Cliente objCliente = objAtual as Cliente;

            //tbID.Text = objCliente.ID.ToString();
            //tbNome.Text = objCliente.Nome;
            //mtbFone.Text = objCliente.Fone;
            //cbSexo.SelectedIndex = (int)(objCliente.Sexo) - 1;
        }

        protected override void ConfigurarObjES()
        {
            tbID.Tag = TipoObjES.Visualizacao;
            tbNome.Tag = TipoObjES.Padrao;
            mtbFone.Tag = TipoObjES.Padrao;
            cbSexo.Tag = TipoObjES.Padrao;
            cbSexo.SelectedIndex = -1;
            base.ConfigurarObjES();
        }

        protected override void LimparTela()
        {
            base.LimparTela();
            cbSexo.SelectedIndex = -1;
        }

        protected override void FormToObj()
        {
            //Cliente objCliente = objAtual as Cliente;

            //objCliente.Nome = tbNome.Text;
            //objCliente.Fone = mtbFone.Text;
            //objCliente.Sexo = (Sexo)(cbSexo.SelectedIndex + 1);
        }

        protected override bool ValidarDados()
        {
            if (cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um sexo para o registro.", "Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbSexo.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override bool SalvarRegistro(CRUDBase obj)
        {
            (obj as Cliente).DataAlteracao = DateTime.Now;
            if (statusTela == StatusCRUD.Inclusao)
            {
                (obj as Cliente).DataCadastro = DateTime.Now;

                sisDBContext.Cliente.Add(obj as Cliente);
            }
            sisDBContext.SaveChanges();
            return true;
        }

        protected override bool ExcluirRegistro(CRUDBase obj)
        {
            sisDBContext.Cliente.Remove(obj as Cliente);
            sisDBContext.SaveChanges();
            return true;
        }
    }
}