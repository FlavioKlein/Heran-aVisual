using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormHerancaVisual.Enums;
using WinFormHerancaVisual.Model;

namespace WinFormHerancaVisual.View
{
    public partial class FormCRUDBase : Form
    {
        protected StatusCRUD statusTela;
        protected CRUDBase objAtual;
        protected readonly SisDBContext sisDBContext;

        public FormCRUDBase()
        {
            InitializeComponent();
        }

        public FormCRUDBase(SisDBContext sisDBContext)
        {
            InitializeComponent();
            this.sisDBContext = sisDBContext;

            objAtual = null;
            statusTela = StatusCRUD.Visualizacao;
            AtualizarControlesTela();
        }

        protected virtual void BTConsultar_Click(object sender, EventArgs e)
        {
            if (objAtual != null)
            {
                MTBDataCadastro.Text = objAtual.DataCadastro.ToShortDateString();
                MTBDataAlteracao.Text = objAtual.DataAlteracao.ToShortDateString();
                BTEditar.Focus();
            }           
        }

        protected virtual void BTIncluir_Click(object sender, EventArgs e)
        {
            statusTela = StatusCRUD.Inclusao;
            LimparTela();
            AtualizarControlesTela();            
        }

        protected virtual void BTEditar_Click(object sender, EventArgs e)
        {
            statusTela = StatusCRUD.Edicao;
            AtualizarControlesTela();
        }

        protected virtual void BTSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarDados())
            {
                return;
            }
            //Atualizar obj com dados da tela
            FormToObj();

            SalvarRegistro(objAtual);

            //Atualizar status para visualização
            statusTela = StatusCRUD.Visualizacao;
            AtualizarControlesTela();
            BTIncluir.Focus();
        }

        protected virtual void BTCancelar_Click(object sender, EventArgs e)
        {
            if (statusTela == StatusCRUD.Inclusao)
            {
                //Limpar tela e obj
                objAtual = null;
                LimparTela();
            }
            else
            {
                //Voltar dados originais para a tela
                ObjToForm();
            }
            statusTela = StatusCRUD.Visualizacao;
            AtualizarControlesTela();
            BTIncluir.Focus();
        }

        protected virtual void BTExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmar exclusão do registro?", "Exluir",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if (ExcluirRegistro(objAtual))
                {
                    //Atualizando tela/controles
                    objAtual = null;
                    LimparTela();
                    AtualizarControlesTela();
                }
            }
        }

        protected virtual void BTSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Método virtual deverá ser implementado (override) na classe derivada.
        /// Serve para validar os dados de entrada na tela antes de salvar.
        /// </summary>
        protected virtual bool ValidarDados()
        {
            //
            // Resumo:
            //      Serve para validar os dados de entrada na tela antes de salvar.
            // Exemplo:
            //  
            return true;
        }

        /// <summary>
        /// Método virtual deverá ser implementado (override) na classe derivada.
        /// Serve para salvar o registro referenciado pelo parâmetro obj.        
        /// </summary>
        protected virtual bool SalvarRegistro(CRUDBase obj)
        {
            //
            // Resumo:
            //      Serve para salvar o registro referenciado pelo parâmetro obj.
            // Exemplo:
            //      if (statusTela == StatusCRUD.Inclusao)
            //      {
            //          sisDBContext.Cliente.Add(obj as Cliente);               
            //      }
            //      sisDBContext.SaveChanges();
            return true;
        }

        /// <summary>
        /// Método virtual deverá ser implementado (override) na classe derivada.
        /// Serve para excluir o registro referenciado pelo parâmetro obj.        
        /// </summary>
        protected virtual bool ExcluirRegistro(CRUDBase obj)
        {
            //
            // Resumo:
            //      Serve para excluir o registro referenciado pelo parâmetro obj.
            // Exemplo:
            //      sisDBContext.Cliente.Remove(obj);
            //      sisDBContext.SaveChanges();
            //      return true;
            return true;
        }

        /// <summary>
        /// Método virtual deverá ser implementado (override) na classe derivada.
        /// Serve para configurar os controles de E/S com a definição de padrão ou somente visualização.
        /// Assim como outras configurações default.
        /// </summary>
        protected virtual void ConfigurarObjES()
        {
            //
            // Resumo:
            //     Serve para configurar os controles de E/S com a definição de padrão ou somente visualização.
            //     Assim como outras configurações default.
            // Exemplo:
            //     textCodigo.Tag = TipoObjES.Visualizacao;
            //     textNome.Tag = TipoObjES.Padrao;
            MTBDataCadastro.Tag = TipoObjES.Visualizacao;
            MTBDataAlteracao.Tag = TipoObjES.Visualizacao;           
        }

        /// <summary>
        /// Método virtual deverá ser implementado (override) na classe derivada.
        /// Serve para atualizar componetes de E/S com os valores das propriedades do objeto de CRUD.
        /// </summary>
        protected virtual void ObjToForm()
        {
            //
            // Resumo:
            //     Serve para atualizar componetes de E/S com os valores das propriedades do objeto de CRUD.
            //
            // Exemplo:
            //     textNome.Text = clienteAtual.nome;            
        }

        protected virtual void FormToObj()
        {
            //clienteAtual.codigo = int.Parse(textCodigo.Text);
            //clienteAtual.nome = textNome.Text;
            //clienteAtual.fone = textFone.Text;
            //clienteAtual.sexo = (Sexo)(cbSexo.SelectedIndex + 1);
        }

        /// <summary>
        /// Método virtual deverá ser implementado (override) na classe derivada.
        /// Serve para limpar componetes de E/S.
        /// </summary>
        protected virtual void LimparTela()
        {
            //Limpar controles de ES da área de dados
            foreach (Control item in pnDados.Controls)
            {
                if (item is TextBoxBase)
                {
                    if (item.Tag.Equals(TipoObjES.Visualizacao) || item.Tag.Equals(TipoObjES.Padrao))
                    {
                        item.Text = "";
                    }
                }
            }

            //Limpar controles de ES da área de botões de controle
            foreach (Control item in pnControles.Controls)
            {
                if (item is TextBoxBase)
                {
                    if (item.Tag.Equals(TipoObjES.Visualizacao) || item.Tag.Equals(TipoObjES.Padrao))
                    {
                        item.Text = "";
                    }
                }
            }
        }

        /// <summary>
        /// Atualizar controles da tela de CRUD de acordo com o Status de operação
        /// </summary>
        protected virtual void AtualizarControlesTela()
        {
            //Habilitar/desabilitar painel de dados 
            pnDados.Enabled = (statusTela == StatusCRUD.Inclusao || statusTela == StatusCRUD.Edicao);

            //Habilitar/desabilitar botões
            BTConsultar.Enabled = (statusTela == StatusCRUD.Visualizacao);
            BTIncluir.Enabled = (statusTela == StatusCRUD.Visualizacao);

            BTEditar.Enabled = (statusTela == StatusCRUD.Visualizacao && objAtual != null);
            BTExcluir.Enabled = (statusTela == StatusCRUD.Visualizacao && objAtual != null);

            BTSalvar.Enabled = (statusTela == StatusCRUD.Inclusao || statusTela == StatusCRUD.Edicao);
            BTCancelar.Enabled = (statusTela == StatusCRUD.Inclusao || statusTela == StatusCRUD.Edicao);
            BTSair.Enabled = (statusTela == StatusCRUD.Visualizacao);
        }        
    }
}
