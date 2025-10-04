namespace ControleFinanceiro.Telas
{
    partial class ControleTipoInvestimento
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
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.colPK_TipoInvestimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpPrincipal.SuspendLayout();
            this.pnlBotoesCRUD.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
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
            this.pnlConteudo.Controls.Add(this.dtgCategoria);
            this.pnlConteudo.Controls.Add(this.lblTitulo);
            this.pnlConteudo.Controls.Add(this.txtNomeCategoria);
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
            // dtgCategoria
            // 
            this.dtgCategoria.AllowUserToAddRows = false;
            this.dtgCategoria.AllowUserToDeleteRows = false;
            this.dtgCategoria.AllowUserToResizeRows = false;
            this.dtgCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPK_TipoInvestimento,
            this.colNome});
            this.dtgCategoria.Location = new System.Drawing.Point(9, 61);
            this.dtgCategoria.MultiSelect = false;
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.ReadOnly = true;
            this.dtgCategoria.RowHeadersVisible = false;
            this.dtgCategoria.RowHeadersWidth = 60;
            this.dtgCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCategoria.Size = new System.Drawing.Size(460, 260);
            this.dtgCategoria.TabIndex = 2;
            this.dtgCategoria.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Tipo Investimento:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCategoria.Enabled = false;
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(9, 29);
            this.txtNomeCategoria.MaxLength = 100;
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(460, 22);
            this.txtNomeCategoria.TabIndex = 0;
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
            // colPK_TipoInvestimento
            // 
            this.colPK_TipoInvestimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPK_TipoInvestimento.DataPropertyName = "PK_TipoInvestimento";
            this.colPK_TipoInvestimento.Frozen = true;
            this.colPK_TipoInvestimento.HeaderText = "PK_TipoInvestimento";
            this.colPK_TipoInvestimento.MinimumWidth = 120;
            this.colPK_TipoInvestimento.Name = "colPK_TipoInvestimento";
            this.colPK_TipoInvestimento.ReadOnly = true;
            this.colPK_TipoInvestimento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPK_TipoInvestimento.Width = 120;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "Nome";
            this.colNome.FillWeight = 118.7817F;
            this.colNome.HeaderText = "Tipo de Investimento";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ControleTipoInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tlpPrincipal);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "ControleTipoInvestimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Investimento";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.pnlBotoesCRUD.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNomeValido;
        private System.Windows.Forms.DataGridView dtgCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPK_TipoInvestimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
    }
}