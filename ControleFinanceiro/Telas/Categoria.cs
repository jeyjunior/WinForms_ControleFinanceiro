using CF.Domain.Interfaces.ViewModel;
using CF.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Domain.Entity;

namespace ControleFinanceiro.Telas
{
    public partial class Categoria : Form
    {
        private readonly ICategoriaVM _viewModel;

        public Categoria()
        {
            InitializeComponent();

            _viewModel = Bootstrap.ServiceProvider.GetRequiredService<ICategoriaVM>();

            ConfigurarBindings();
        }

        private void ConfigurarBindings()
        {
            btnAdicionar.DataBindings.Add("Visible", _viewModel, "NaoEstaEditando");
            btnEditar.DataBindings.Add("Visible", _viewModel, "NaoEstaEditando");
            btnExcluir.DataBindings.Add("Visible", _viewModel, "NaoEstaEditando");
            
            btnSalvar.DataBindings.Add("Visible", _viewModel, "EstaEditando");
            btnCancelar.DataBindings.Add("Visible", _viewModel, "EstaEditando");

            btnEditar.DataBindings.Add("Enabled", _viewModel, "HabilitarBotoes");
            btnExcluir.DataBindings.Add("Enabled", _viewModel, "HabilitarBotoes");

            lblCategoria.DataBindings.Add("Text", _viewModel, "DescricaoOperacao");
            txtNomeCategoria.DataBindings.Add("Text", _viewModel, "NomeCategoriaSelecionada");
            txtNomeCategoria.DataBindings.Add("Enabled", _viewModel, "HabilitarTexto");

            dgvCategorias.DataSource = _viewModel.CategoriaCollection;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(Domain.Enumeradores.eTipoOperacao.Adicionar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(Domain.Enumeradores.eTipoOperacao.Editar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(Domain.Enumeradores.eTipoOperacao.Excluir);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(Domain.Enumeradores.eTipoOperacao.Visualizar);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(Domain.Enumeradores.eTipoOperacao.Visualizar);
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dgvCategorias.SelectedRows[0];

                Domain.Entity.Categoria categoria = linhaSelecionada.DataBoundItem as Domain.Entity.Categoria;

                _viewModel.CategoriaSelecionada = categoria;
            }
            else
            {
                _viewModel.CategoriaSelecionada = null;
            }
        }
    }
}