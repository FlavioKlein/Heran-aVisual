namespace WinFormHerancaVisual.View
{
    partial class FormCRUDCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbFone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.cbSexo);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.mtbFone);
            this.pnDados.Controls.Add(this.tbNome);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.tbID);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Size = new System.Drawing.Size(740, 531);
            // 
            // BTSair
            // 
            this.BTSair.Location = new System.Drawing.Point(10, 276);
            // 
            // BTExcluir
            // 
            this.BTExcluir.Location = new System.Drawing.Point(10, 234);
            // 
            // BTSalvar
            // 
            this.BTSalvar.Location = new System.Drawing.Point(10, 149);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Location = new System.Drawing.Point(10, 191);
            // 
            // BTEditar
            // 
            this.BTEditar.Location = new System.Drawing.Point(10, 106);
            // 
            // BTIncluir
            // 
            this.BTIncluir.Location = new System.Drawing.Point(10, 64);
            // 
            // BTConsultar
            // 
            this.BTConsultar.Location = new System.Drawing.Point(9, 11);
            // 
            // pnControles
            // 
            this.pnControles.Location = new System.Drawing.Point(584, 0);
            this.pnControles.Size = new System.Drawing.Size(156, 531);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 382);
            this.label2.TabIndex = 9;
            // 
            // MTBDataAlteracao
            // 
            this.MTBDataAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "DataAlteracao", true));
            this.MTBDataAlteracao.Location = new System.Drawing.Point(10, 406);
            this.MTBDataAlteracao.Margin = new System.Windows.Forms.Padding(5);
            this.MTBDataAlteracao.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 321);
            this.label1.TabIndex = 7;
            // 
            // MTBDataCadastro
            // 
            this.MTBDataCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "DataCadastro", true));
            this.MTBDataCadastro.Location = new System.Drawing.Point(10, 345);
            this.MTBDataCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.MTBDataCadastro.TabIndex = 8;
            // 
            // bsDados
            // 
            this.bsDados.DataSource = typeof(WinFormHerancaVisual.Model.Cliente);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "ID", true));
            this.tbID.Location = new System.Drawing.Point(11, 52);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(80, 27);
            this.tbID.TabIndex = 1;
            this.tbID.TabStop = false;
            // 
            // tbNome
            // 
            this.tbNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "Nome", true));
            this.tbNome.Location = new System.Drawing.Point(11, 115);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(313, 27);
            this.tbNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome";
            // 
            // mtbFone
            // 
            this.mtbFone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "Fone", true));
            this.mtbFone.Location = new System.Drawing.Point(11, 175);
            this.mtbFone.Margin = new System.Windows.Forms.Padding(4);
            this.mtbFone.Mask = "(99) 90000-0000";
            this.mtbFone.Name = "mtbFone";
            this.mtbFone.Size = new System.Drawing.Size(153, 27);
            this.mtbFone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fone";
            // 
            // cbSexo
            // 
            this.cbSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "Sexo", true));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(11, 239);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(216, 28);
            this.cbSexo.TabIndex = 7;
            this.cbSexo.Text = "Selecione uma opção";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo";
            // 
            // FormCRUDCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(740, 531);
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "FormCRUDCliente";
            this.Text = "Cliente";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnControles.ResumeLayout(false);
            this.pnControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbFone;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
    }
}
