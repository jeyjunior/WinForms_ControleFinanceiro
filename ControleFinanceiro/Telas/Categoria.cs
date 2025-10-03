using CF.Domain.Interfaces.ViewModel;
using CF.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.Telas
{
    public partial class Categoria : Form
    {
        private readonly ICategoriaVM _categoriaVM;

        public Categoria()
        {
            InitializeComponent();

            _categoriaVM = Bootstrap.ServiceProvider.GetRequiredService<ICategoriaVM>();

            txtNomeCategoria.DataBindings.Add("Text", _categoriaVM, nameof(_categoriaVM.Nome), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _categoriaVM.Nome = "1";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _categoriaVM.Nome = "2";
        }
    }
}
