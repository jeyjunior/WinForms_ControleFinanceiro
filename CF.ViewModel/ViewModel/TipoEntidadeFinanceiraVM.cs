using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using CF.Domain.Interfaces.ViewModel;
using CF.Domain.Entity;
using CF.Domain.Enumeradores;
using CF.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CF.ViewModel.ViewModel
{
    public class TipoEntidadeFinanceiraVM : ViewModelBase, ITipoEntidadeFinanceiraVM
    {
        private readonly ITipoEntidadeFinanceiraRepository _tipoEntidadeFinanceiraRepository;

        public TipoEntidadeFinanceiraVM()
        {
            _tipoEntidadeFinanceiraRepository = Bootstrap.ServiceProvider.GetRequiredService<ITipoEntidadeFinanceiraRepository>();

            DefinirPadraoInicial();
        }

        private eTipoOperacao _tipoOperacao;
        public eTipoOperacao TipoOperacaoAtiva
        {
            get => _tipoOperacao;
            private set
            {
                _tipoOperacao = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(EstaEditando));
                OnPropertyChanged(nameof(NaoEstaEditando));
                OnPropertyChanged(nameof(NomeEmExibicao));
            }
        }

        private string _descricaoOperacao;
        public string DescricaoOperacao { get => _descricaoOperacao; }

        public bool HabilitarBotoes
        {
            get
            {
                return ItemCollection.Count > 0;
            }
        }
        public bool HabilitarTexto
        {
            get => _tipoOperacao == eTipoOperacao.Editar || _tipoOperacao == eTipoOperacao.Adicionar;
        }

        public bool NaoEstaEditando { get => !EstaEditando; }
        public bool EstaEditando
        {
            get => _tipoOperacao != eTipoOperacao.Visualizar;
        }

        private TipoEntidadeFinanceira _itemSelecionado;
        public TipoEntidadeFinanceira ItemSelecionado
        {
            get => _itemSelecionado;
            set
            {
                _itemSelecionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NomeEmExibicao));
            }
        }

        private string _nomeEmEdicao;
        public string NomeEmEdicao
        {
            get => _nomeEmEdicao;
            set
            {
                _nomeEmEdicao = value;
                OnPropertyChanged();
                if (EstaEditando)
                {
                    OnPropertyChanged(nameof(NomeEmExibicao));
                    ValidarNome();
                }
            }
        }
        public string NomeEmExibicao
        {
            get
            {
                if (EstaEditando)
                    return NomeEmEdicao;

                return ItemSelecionado?.Nome ?? "";
            }
            set
            {
                if (EstaEditando)
                    NomeEmEdicao = value;
            }
        }


        private BindingList<TipoEntidadeFinanceira> _itemCollection;
        public BindingList<TipoEntidadeFinanceira> ItemCollection
        {
            get => _itemCollection;
        }


        private bool _nomeInvalido = false;
        public bool NomeInvalido { get => _nomeInvalido; }
        public bool NomeValido { get => !_nomeInvalido; }
        public void DefinirPadraoInicial()
        {
            AtualizarColecao();
            HabilitarOperacao(eTipoOperacao.Visualizar);
        }
        public void Salvar()
        {
            int ret = 0;
            TipoEntidadeFinanceira tipoEntidadeFinanceira;

            switch (TipoOperacaoAtiva)
            {
                case eTipoOperacao.Visualizar:
                    break;
                case eTipoOperacao.Adicionar:
                    tipoEntidadeFinanceira = new TipoEntidadeFinanceira { Nome = NomeEmEdicao };
                    ret = _tipoEntidadeFinanceiraRepository.Adicionar(tipoEntidadeFinanceira);

                    break;
                case eTipoOperacao.Editar:

                    tipoEntidadeFinanceira = ItemSelecionado;
                    tipoEntidadeFinanceira.Nome = NomeEmEdicao;
                    ret = _tipoEntidadeFinanceiraRepository.Atualizar(tipoEntidadeFinanceira);

                    break;
                case eTipoOperacao.Excluir:
                    ret = _tipoEntidadeFinanceiraRepository.Deletar(ItemSelecionado.PK_TipoEntidadeFinanceira);

                    break;
                case eTipoOperacao.Salvar:
                    break;
                case eTipoOperacao.Cancelar:
                    break;
                default:
                    break;
            }

            AtualizarColecao();
            HabilitarOperacao(eTipoOperacao.Visualizar);
        }
        private void AtualizarColecao()
        {
            if (_itemCollection == null)
                _itemCollection = new BindingList<TipoEntidadeFinanceira>();

            if (_itemCollection.Count > 0)
                _itemCollection.Clear();

            var itens = _tipoEntidadeFinanceiraRepository.ObterLista();
            foreach (var item in itens)
                _itemCollection.Add(item);
        }
        public void ValidarNome()
        {
            if (TipoOperacaoAtiva == eTipoOperacao.Adicionar || TipoOperacaoAtiva == eTipoOperacao.Editar)
            {
                if (string.IsNullOrWhiteSpace(NomeEmEdicao))
                    _nomeInvalido = true;
                else if (ItemCollection.Any(i => i.Nome.Trim().ToLower().Equals(NomeEmEdicao.Trim().ToLower())))
                    _nomeInvalido = true;
                else
                    _nomeInvalido = false;
            }
            else
            {
                _nomeInvalido = false;
            }

            OnPropertyChanged(nameof(NomeInvalido));
        }
        public void HabilitarOperacao(eTipoOperacao tipoOperacao)
        {
            TipoOperacaoAtiva = tipoOperacao;

            _descricaoOperacao = "Item selecionado:";
            _nomeInvalido = false;

            switch (TipoOperacaoAtiva)
            {
                case eTipoOperacao.Adicionar:
                    _descricaoOperacao = "Adicionar novo item:";
                    NomeEmEdicao = "";
                    break;
                case eTipoOperacao.Editar:
                    _descricaoOperacao = "Editar item selecionado:";
                    NomeEmEdicao = ItemSelecionado?.Nome;
                    break;
                case eTipoOperacao.Visualizar:
                case eTipoOperacao.Cancelar:
                    break;
            }

            OnPropertyChanged(nameof(DescricaoOperacao));
            OnPropertyChanged(nameof(HabilitarBotoes));
            OnPropertyChanged(nameof(HabilitarTexto));
        }
    }
}