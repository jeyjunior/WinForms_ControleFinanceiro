namespace ControleFinanceiro.Telas
{
    partial class ControleTipoEntidadeFinanceira
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotoesCRUD = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.lblNomeValido = new System.Windows.Forms.Label();
            this.dtgTipoEntidade = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeTipoEntidade = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.colPK_TipoEntidadeFinanceira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoesCRUD.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoEntidade)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.Controls.Add(this.pnlBotoesCRUD, 1, 0);
            this.tlpPrincipal.Controls.Add(this.pnlConteudo, 0, 0);
            this.tlpPrincipal.Controls.Add(this.lblStatus, 0, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(584, 361);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlBotoesCRUD
            // 
            this.pnlBotoesCRUD.Controls.Add(this.btnCancelar);
            this.pnlBotoesCRUD.Controls.Add(this.btnSalvar);
            this.pnlBotoesCRUD.Controls.Add(this.btnExcluir);
            this.pnlBotoesCRUD.Controls.Add(this.btnEditar);
            this.pnlBotoesCRUD.Controls.Add(this.btnAdicionar);
            this.pnlBotoesCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoesCRUD.Location = new System.Drawing.Point(487, 3);
            this.pnlBotoesCRUD.Name = "pnlBotoesCRUD";
            this.pnlBotoesCRUD.Size = new System.Drawing.Size(94, 335);
            this.pnlBotoesCRUD.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Location = new System.Drawing.Point(0, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalvar.Location = new System.Drawing.Point(0, 111);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 37);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.Location = new System.Drawing.Point(0, 74);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 37);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.Location = new System.Drawing.Point(0, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 37);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdicionar.Location = new System.Drawing.Point(0, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(94, 37);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.lblNomeValido);
            this.pnlConteudo.Controls.Add(this.dtgTipoEntidade);
            this.pnlConteudo.Controls.Add(this.lblTitulo);
            this.pnlConteudo.Controls.Add(this.txtNomeTipoEntidade);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(3, 3);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(478, 335);
            this.pnlConteudo.TabIndex = 1;
            // 
            // lblNomeValido
            // 
            this.lblNomeValido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeValido.AutoSize = true;
            this.lblNomeValido.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeValido.ForeColor = System.Drawing.Color.Red;
            this.lblNomeValido.Location = new System.Drawing.Point(383, 11);
            this.lblNomeValido.Name = "lblNomeValido";
            this.lblNomeValido.Size = new System.Drawing.Size(86, 15);
            this.lblNomeValido.TabIndex = 3;
            this.lblNomeValido.Text = "Nome inválido";
            // 
            // dtgTipoEntidade
            // 
            this.dtgTipoEntidade.AllowUserToAddRows = false;
            this.dtgTipoEntidade.AllowUserToDeleteRows = false;
            this.dtgTipoEntidade.AllowUserToResizeRows = false;
            this.dtgTipoEntidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTipoEntidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTipoEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoEntidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_TipoEntidadeFinanceira,
            this.colNome});
            this.dtgTipoEntidade.Location = new System.Drawing.Point(9, 61);
            this.dtgTipoEntidade.MultiSelect = false;
            this.dtgTipoEntidade.Name = "dtgTipoEntidade";
            this.dtgTipoEntidade.ReadOnly = true;
            this.dtgTipoEntidade.RowHeadersVisible = false;
            this.dtgTipoEntidade.RowHeadersWidth = 60;
            this.dtgTipoEntidade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgTipoEntidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTipoEntidade.Size = new System.Drawing.Size(460, 260);
            this.dtgTipoEntidade.TabIndex = 2;
            this.dtgTipoEntidade.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(164, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tipo de Entidade Financeira:";
            // 
            // txtNomeTipoEntidade
            // 
            this.txtNomeTipoEntidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeTipoEntidade.Enabled = false;
            this.txtNomeTipoEntidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTipoEntidade.Location = new System.Drawing.Point(9, 29);
            this.txtNomeTipoEntidade.Name = "txtNomeTipoEntidade";
            this.txtNomeTipoEntidade.Size = new System.Drawing.Size(460, 22);
            this.txtNomeTipoEntidade.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 341);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(478, 20);
            this.lblStatus.TabIndex = 2;
            // 
            // colPK_TipoEntidadeFinanceira
            // 
            this.colPK_TipoEntidadeFinanceira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPK_TipoEntidadeFinanceira.DataPropertyName = "PK_TipoEntidadeFinanceira";
            this.colPK_TipoEntidadeFinanceira.Frozen = true;
            this.colPK_TipoEntidadeFinanceira.HeaderText = "PK_TipoEntidadeFinanceira";
            this.colPK_TipoEntidadeFinanceira.MinimumWidth = 160;
            this.colPK_TipoEntidadeFinanceira.Name = "colPK_TipoEntidadeFinanceira";
            this.colPK_TipoEntidadeFinanceira.ReadOnly = true;
            this.colPK_TipoEntidadeFinanceira.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPK_TipoEntidadeFinanceira.Width = 160;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.FillWeight = 118.7817F;
            this.colNome.HeaderText = "Tipo de Entidade Financeira";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ControleTipoEntidadeFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tlpPrincipal);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ControleTipoEntidadeFinanceira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Entidade Financeira";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoesCRUD.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoEntidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlBotoesCRUD;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dtgTipoEntidade;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeTipoEntidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomeValido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_TipoEntidadeFinanceira;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
    }
}