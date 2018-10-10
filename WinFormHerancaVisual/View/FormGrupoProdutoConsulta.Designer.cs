namespace WinFormHerancaVisual.View
{
    partial class FormGrupoProdutoConsulta
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textFiltro = new System.Windows.Forms.TextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.grupoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textFiltro);
            this.panel1.Controls.Add(this.btFiltrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCampo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTipoFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 6;
            // 
            // textFiltro
            // 
            this.textFiltro.Location = new System.Drawing.Point(266, 34);
            this.textFiltro.Name = "textFiltro";
            this.textFiltro.Size = new System.Drawing.Size(340, 22);
            this.textFiltro.TabIndex = 11;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(618, 33);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(77, 23);
            this.btFiltrar.TabIndex = 10;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Campo do filtro";
            // 
            // cbCampo
            // 
            this.cbCampo.AutoCompleteCustomSource.AddRange(new string[] {
            "Contém",
            "Incia com",
            "Termina com"});
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "ID",
            "Nome"});
            this.cbCampo.Location = new System.Drawing.Point(139, 32);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 24);
            this.cbCampo.TabIndex = 7;
            this.cbCampo.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de Filtro";
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.AutoCompleteCustomSource.AddRange(new string[] {
            "Contém",
            "Incia com",
            "Termina com"});
            this.cbTipoFiltro.FormattingEnabled = true;
            this.cbTipoFiltro.Items.AddRange(new object[] {
            "Contém",
            "Inicia com",
            "Termina com"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(12, 32);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(121, 24);
            this.cbTipoFiltro.TabIndex = 5;
            this.cbTipoFiltro.Text = "Contém";
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.AutoGenerateColumns = false;
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.dataAlteracaoDataGridViewTextBoxColumn});
            this.dataGridViewGrupo.DataSource = this.grupoProdutoBindingSource;
            this.dataGridViewGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGrupo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(0, 71);
            this.dataGridViewGrupo.MultiSelect = false;
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.ReadOnly = true;
            this.dataGridViewGrupo.RowTemplate.Height = 24;
            this.dataGridViewGrupo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupo.Size = new System.Drawing.Size(800, 379);
            this.dataGridViewGrupo.TabIndex = 7;
            this.dataGridViewGrupo.VirtualMode = true;
            this.dataGridViewGrupo.DoubleClick += new System.EventHandler(this.dataGridViewGrupos_DoubleClick);
            // 
            // grupoProdutoBindingSource
            // 
            this.grupoProdutoBindingSource.DataSource = typeof(WinFormHerancaVisual.Model.GrupoProduto);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAlteracaoDataGridViewTextBoxColumn
            // 
            this.dataAlteracaoDataGridViewTextBoxColumn.DataPropertyName = "DataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.HeaderText = "DataAlteracao";
            this.dataAlteracaoDataGridViewTextBoxColumn.Name = "dataAlteracaoDataGridViewTextBoxColumn";
            this.dataAlteracaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormGrupoProdutoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewGrupo);
            this.Controls.Add(this.panel1);
            this.Name = "FormGrupoProdutoConsulta";
            this.Text = "FormGrupoProdutoConsulta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource grupoProdutoBindingSource;
    }
}