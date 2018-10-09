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
using WinFormHerancaVisual.Enums;

namespace WinFormHerancaVisual.View
{
    public partial class Form1 : Form
    {
        private readonly SisDBContext sisDBContext;
        public Cliente objCliente;
        private StatusCRUD StatusTela;
       
        public Form1(SisDBContext sisDBContext)
        {
            this.sisDBContext = sisDBContext;
            InitializeComponent();
            objCliente = null;
            //bsDados.DataSource = objCliente;
            bsGrid.DataSource = sisDBContext.Cliente.ToList();
            StatusTela = StatusCRUD.Visualizacao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCliente = new Cliente();
            objCliente.Sexo = Enums.Sexo.Masculino;
            objCliente.DataCadastro = DateTime.Now;
            objCliente.DataAlteracao = DateTime.Now;

            bsDados.DataSource = objCliente;
            StatusTela = StatusCRUD.Inclusao;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StatusTela == StatusCRUD.Inclusao)
            {
                sisDBContext.Cliente.Add(objCliente);
            }
            sisDBContext.SaveChanges();
            StatusTela = StatusCRUD.Visualizacao;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objCliente = (bsGrid.Current as Cliente);
            bsDados.DataSource = objCliente;
            StatusTela = StatusCRUD.Edicao;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sisDBContext.Cliente.Remove(bsGrid.Current as Cliente);
            sisDBContext.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsDados.CancelEdit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bsGrid.DataSource = sisDBContext.Cliente.ToList();
        }
    }
}
