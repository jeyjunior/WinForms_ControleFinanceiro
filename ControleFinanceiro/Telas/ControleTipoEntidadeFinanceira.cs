using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using CF.Domain.Interfaces.ViewModel;
using CF.ViewModel;
using CF.Domain.Entity;
using CF.Domain.Enumeradores;

namespace ControleFinanceiro.Telas
{
    public partial class ControleTipoEntidadeFinanceira : Form
    {
        private readonly ITipoEntidadeFinanceiraVM _viewModel;

        public ControleTipoEntidadeFinanceira()
        {
            InitializeComponent();

            _viewModel = Bootstrap.ServiceProvider.GetRequiredService<ITipoEntidadeFinanceiraVM>();

            ConfigurarBindings();
        }

        private void ConfigurarBindings()
        {
            dtgTipoEntidade.AutoGenerateColumns = false;

            btnAdicionar.DataBindings.Add("Visible", _viewModel, "NaoEstaEditando");
            btnEditar.DataBindings.Add("Visible", _viewModel, "NaoEstaEditando");
            btnExcluir.DataBindings.Add("Visible", _viewModel, "NaoEstaEditando");
            
            btnSalvar.DataBindings.Add("Visible", _viewModel, "EstaEditando");
            btnCancelar.DataBindings.Add("Visible", _viewModel, "EstaEditando");

            btnEditar.DataBindings.Add("Enabled", _viewModel, "HabilitarBotoes");
            btnExcluir.DataBindings.Add("Enabled", _viewModel, "HabilitarBotoes");

            lblTitulo.DataBindings.Add("Text", _viewModel, "DescricaoOperacao");
            
            dtgTipoEntidade.DataSource = _viewModel.ItemCollection;

            txtNomeTipoEntidade.DataBindings.Add("Text", _viewModel, "NomeEmExibicao", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomeTipoEntidade.DataBindings.Add("Enabled", _viewModel, "HabilitarTexto", false, DataSourceUpdateMode.OnPropertyChanged);

            lblNomeValido.DataBindings.Add("Visible", _viewModel, "NomeInvalido", true, DataSourceUpdateMode.OnPropertyChanged);
            btnSalvar.DataBindings.Add("Enabled", _viewModel, "NomeValido");

            _viewModel.DefinirPadraoInicial();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(CF.Domain.Enumeradores.eTipoOperacao.Adicionar);
            txtNomeTipoEntidade.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(eTipoOperacao.Editar);
            txtNomeTipoEntidade.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(CF.Domain.Enumeradores.eTipoOperacao.Excluir);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _viewModel.Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _viewModel.HabilitarOperacao(eTipoOperacao.Visualizar);
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgTipoEntidade.SelectedRows.Count > 0)
            {
                var linhaSelecionada = dtgTipoEntidade.SelectedRows[0];

                TipoEntidadeFinanceira tipoEntidadeFinanceira = linhaSelecionada.DataBoundItem as TipoEntidadeFinanceira;

                _viewModel.ItemSelecionado = tipoEntidadeFinanceira;
            }
            else
            {
                _viewModel.ItemSelecionado = null;
            }
        }
    }
}