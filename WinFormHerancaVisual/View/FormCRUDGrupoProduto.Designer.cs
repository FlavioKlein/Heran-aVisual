namespace WinFormHerancaVisual.View
{
    partial class FormCRUDGrupoProduto
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.tbID);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.tbNome);
            this.pnDados.Controls.Add(this.label3);
            // 
            // MTBDataAlteracao
            // 
            this.MTBDataAlteracao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "DataAlteracao", true));
            // 
            // MTBDataCadastro
            // 
            this.MTBDataCadastro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "DataCadastro", true));
            // 
            // bsDados
            // 
            this.bsDados.DataSource = typeof(WinFormHerancaVisual.Model.GrupoProduto);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "Nome", true));
            this.tbNome.Location = new System.Drawing.Point(22, 132);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(219, 27);
            this.tbNome.TabIndex = 3;
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDados, "ID", true));
            this.tbID.Location = new System.Drawing.Point(22, 63);
            this.tbID.Margin = new System.Windows.Forms.Padding(4);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(80, 27);
            this.tbID.TabIndex = 1;
            this.tbID.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // FormCRUDGrupoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Name = "FormCRUDGrupoProduto";
            this.Text = "Grupo de produtos";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnControles.ResumeLayout(false);
            this.pnControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label4;
    }
}
