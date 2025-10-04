using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using CF.Domain.Interfaces.ViewModel;
using CF.ViewModel;
using CF.Domain.Entity;
using CF.Domain.Enumeradores;

namespace ControleFinanceiro.Telas
{
    public partial class ControleCategoria : Form
    {
        private readonly ICategoriaVM _viewModel;

        public ControleCategoria()
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

            _viewModel.DefinirPadraoInicial();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(CF.Domain.Enumeradores.eTipoOperacao.Adicionar);
            txtNomeCategoria.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(eTipoOperacao.Editar);
            txtNomeCategoria.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(CF.Domain.Enumeradores.eTipoOperacao.Excluir);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                PK_Categoria = 0,
                Nome = txtNomeCategoria.Text,
                FK_Usuario = null
            };

            if (_viewModel.TipoOperacaoAtiva != eTipoOperacao.Adicionar)
                categoria.PK_Categoria = _viewModel.CategoriaSelecionada.PK_Categoria;

            _viewModel.Salvar(categoria);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(eTipoOperacao.Visualizar);
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dgvCategorias.SelectedRows[0];

                Categoria categoria = linhaSelecionada.DataBoundItem as Categoria;

                _viewModel.CategoriaSelecionada = categoria;
            }
            else
            {
                _viewModel.CategoriaSelecionada = null;
            }
        }
    }
}