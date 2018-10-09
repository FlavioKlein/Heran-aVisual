namespace WinFormHerancaVisual.View
{
    partial class FormCRUDBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDBase));
            this.pnDados = new System.Windows.Forms.Panel();
            this.pnControles = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MTBDataAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MTBDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.BTSair = new System.Windows.Forms.Button();
            this.BTExcluir = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.BTEditar = new System.Windows.Forms.Button();
            this.BTIncluir = new System.Windows.Forms.Button();
            this.BTConsultar = new System.Windows.Forms.Button();
            this.pnControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDados.Location = new System.Drawing.Point(0, 0);
            this.pnDados.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(1000, 562);
            this.pnDados.TabIndex = 2;
            // 
            // pnControles
            // 
            this.pnControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControles.Controls.Add(this.label2);
            this.pnControles.Controls.Add(this.MTBDataAlteracao);
            this.pnControles.Controls.Add(this.label1);
            this.pnControles.Controls.Add(this.MTBDataCadastro);
            this.pnControles.Controls.Add(this.BTSair);
            this.pnControles.Controls.Add(this.BTExcluir);
            this.pnControles.Controls.Add(this.BTSalvar);
            this.pnControles.Controls.Add(this.BTCancelar);
            this.pnControles.Controls.Add(this.BTEditar);
            this.pnControles.Controls.Add(this.BTIncluir);
            this.pnControles.Controls.Add(this.BTConsultar);
            this.pnControles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnControles.Location = new System.Drawing.Point(846, 0);
            this.pnControles.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnControles.Name = "pnControles";
            this.pnControles.Size = new System.Drawing.Size(154, 562);
            this.pnControles.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alteração";
            // 
            // MTBDataAlteracao
            // 
            this.MTBDataAlteracao.Location = new System.Drawing.Point(11, 406);
            this.MTBDataAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.MTBDataAlteracao.Mask = "00/00/0000";
            this.MTBDataAlteracao.Name = "MTBDataAlteracao";
            this.MTBDataAlteracao.ReadOnly = true;
            this.MTBDataAlteracao.Size = new System.Drawing.Size(132, 27);
            this.MTBDataAlteracao.TabIndex = 0;
            this.MTBDataAlteracao.TabStop = false;
            this.MTBDataAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro";
            // 
            // MTBDataCadastro
            // 
            this.MTBDataCadastro.Location = new System.Drawing.Point(11, 345);
            this.MTBDataCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.MTBDataCadastro.Mask = "00/00/0000";
            this.MTBDataCadastro.Name = "MTBDataCadastro";
            this.MTBDataCadastro.ReadOnly = true;
            this.MTBDataCadastro.Size = new System.Drawing.Size(132, 27);
            this.MTBDataCadastro.TabIndex = 9;
            this.MTBDataCadastro.TabStop = false;
            this.MTBDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // BTSair
            // 
            this.BTSair.Image = ((System.Drawing.Image)(resources.GetObject("BTSair.Image")));
            this.BTSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSair.Location = new System.Drawing.Point(11, 276);
            this.BTSair.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTSair.Name = "BTSair";
            this.BTSair.Size = new System.Drawing.Size(132, 32);
            this.BTSair.TabIndex = 7;
            this.BTSair.Text = "Sair";
            this.BTSair.UseVisualStyleBackColor = true;
            this.BTSair.Click += new System.EventHandler(this.BTSair_Click);
            // 
            // BTExcluir
            // 
            this.BTExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BTExcluir.Image")));
            this.BTExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTExcluir.Location = new System.Drawing.Point(11, 234);
            this.BTExcluir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTExcluir.Name = "BTExcluir";
            this.BTExcluir.Size = new System.Drawing.Size(132, 32);
            this.BTExcluir.TabIndex = 5;
            this.BTExcluir.Text = "Excluir";
            this.BTExcluir.UseVisualStyleBackColor = true;
            this.BTExcluir.Click += new System.EventHandler(this.BTExcluir_Click);
            // 
            // BTSalvar
            // 
            this.BTSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BTSalvar.Image")));
            this.BTSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSalvar.Location = new System.Drawing.Point(11, 149);
            this.BTSalvar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(132, 32);
            this.BTSalvar.TabIndex = 3;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // BTCancelar
            // 
            this.BTCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BTCancelar.Image")));
            this.BTCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTCancelar.Location = new System.Drawing.Point(11, 191);
            this.BTCancelar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(132, 32);
            this.BTCancelar.TabIndex = 4;
            this.BTCancelar.Text = "Cancelar";
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // BTEditar
            // 
            this.BTEditar.Image = ((System.Drawing.Image)(resources.GetObject("BTEditar.Image")));
            this.BTEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTEditar.Location = new System.Drawing.Point(11, 106);
            this.BTEditar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTEditar.Name = "BTEditar";
            this.BTEditar.Size = new System.Drawing.Size(132, 32);
            this.BTEditar.TabIndex = 2;
            this.BTEditar.Text = "Editar";
            this.BTEditar.UseVisualStyleBackColor = true;
            this.BTEditar.Click += new System.EventHandler(this.BTEditar_Click);
            // 
            // BTIncluir
            // 
            this.BTIncluir.Image = ((System.Drawing.Image)(resources.GetObject("BTIncluir.Image")));
            this.BTIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTIncluir.Location = new System.Drawing.Point(11, 64);
            this.BTIncluir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTIncluir.Name = "BTIncluir";
            this.BTIncluir.Size = new System.Drawing.Size(132, 32);
            this.BTIncluir.TabIndex = 1;
            this.BTIncluir.Text = "Incluir";
            this.BTIncluir.UseVisualStyleBackColor = true;
            this.BTIncluir.Click += new System.EventHandler(this.BTIncluir_Click);
            // 
            // BTConsultar
            // 
            this.BTConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BTConsultar.Image")));
            this.BTConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTConsultar.Location = new System.Drawing.Point(10, 11);
            this.BTConsultar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BTConsultar.Name = "BTConsultar";
            this.BTConsultar.Size = new System.Drawing.Size(132, 32);
            this.BTConsultar.TabIndex = 0;
            this.BTConsultar.Text = "Consultar";
            this.BTConsultar.UseVisualStyleBackColor = true;
            this.BTConsultar.Click += new System.EventHandler(this.BTConsultar_Click);
            // 
            // FormCRUDBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.pnControles);
            this.Controls.Add(this.pnDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FormCRUDBase";
            this.Text = "FormCRUDBase";
            this.pnControles.ResumeLayout(false);
            this.pnControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnDados;
        protected System.Windows.Forms.Button BTSair;
        protected System.Windows.Forms.Button BTExcluir;
        protected System.Windows.Forms.Button BTSalvar;
        protected System.Windows.Forms.Button BTCancelar;
        protected System.Windows.Forms.Button BTEditar;
        protected System.Windows.Forms.Button BTIncluir;
        protected System.Windows.Forms.Button BTConsultar;
        protected System.Windows.Forms.Panel pnControles;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.MaskedTextBox MTBDataAlteracao;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.MaskedTextBox MTBDataCadastro;
    }
}