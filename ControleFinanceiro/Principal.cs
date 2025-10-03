using ControleFinanceiro.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class ControleFinanceiro : Form
    {
        #region Propriedades
        #endregion

        #region Interfaces
        #endregion

        #region Construtor
        public ControleFinanceiro()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.ShowDialog();
            }
            catch (Exception ex)
            {
                ExibirMensagem(ex.Message);
            }
        }
        #endregion
        #region Metodos
        private void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }
        #endregion
    }
}
