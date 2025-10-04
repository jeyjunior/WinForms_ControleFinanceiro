namespace ControleFinanceiro
{
    partial class ControleFinanceiro
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
            this.btnCategoria = new System.Windows.Forms.Button();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pDireita = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTipoInvestimento = new System.Windows.Forms.Button();
            this.pCentral = new System.Windows.Forms.Panel();
            this.tlpPrincipal.SuspendLayout();
            this.pDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCategoria
            // 
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.Location = new System.Drawing.Point(0, 0);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(114, 37);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.Controls.Add(this.pDireita, 1, 0);
            this.tlpPrincipal.Controls.Add(this.pCentral, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPrincipal.Size = new System.Drawing.Size(798, 450);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // pDireita
            // 
            this.pDireita.Controls.Add(this.button7);
            this.pDireita.Controls.Add(this.button6);
            this.pDireita.Controls.Add(this.button5);
            this.pDireita.Controls.Add(this.button4);
            this.pDireita.Controls.Add(this.button3);
            this.pDireita.Controls.Add(this.btnTipoInvestimento);
            this.pDireita.Controls.Add(this.btnCategoria);
            this.pDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDireita.Location = new System.Drawing.Point(681, 3);
            this.pDireita.Name = "pDireita";
            this.pDireita.Size = new System.Drawing.Size(114, 424);
            this.pDireita.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 222);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 37);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 37);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 37);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 37);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 37);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnTipoInvestimento
            // 
            this.btnTipoInvestimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoInvestimento.Location = new System.Drawing.Point(0, 37);
            this.btnTipoInvestimento.Name = "btnTipoInvestimento";
            this.btnTipoInvestimento.Size = new System.Drawing.Size(114, 37);
            this.btnTipoInvestimento.TabIndex = 2;
            this.btnTipoInvestimento.Text = "Tipo Investimento";
            this.btnTipoInvestimento.UseVisualStyleBackColor = true;
            this.btnTipoInvestimento.Click += new System.EventHandler(this.btnTipoInvestimento_Click);
            // 
            // pCentral
            // 
            this.pCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCentral.Location = new System.Drawing.Point(3, 3);
            this.pCentral.Name = "pCentral";
            this.pCentral.Size = new System.Drawing.Size(672, 424);
            this.pCentral.TabIndex = 2;
            // 
            // ControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.tlpPrincipal);
            this.Name = "ControleFinanceiro";
            this.Text = "Controle Financeiro";
            this.tlpPrincipal.ResumeLayout(false);
            this.pDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pDireita;
        private System.Windows.Forms.Panel pCentral;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTipoInvestimento;
    }
}

