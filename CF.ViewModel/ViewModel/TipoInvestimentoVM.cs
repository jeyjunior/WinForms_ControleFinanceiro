using CF.Domain.Entity;
using CF.Domain.Enumeradores;
using CF.Domain.Interfaces;
using CF.Domain.Interfaces.ViewModel;
using CF.InfraData.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace CF.ViewModel.ViewModel
{
    public class TipoInvestimentoVM : ViewModelBase, ITipoInvestimentoVM
    {
        private readonly ITipoInvestimentoRepository _tipoInvestimentoRepository;

        public TipoInvestimentoVM()
        {
            _tipoInvestimentoRepository = Bootstrap.ServiceProvider.GetRequiredService<ITipoInvestimentoRepository>();

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

        private TipoInvestimento _itemSelecionado;
        public TipoInvestimento ItemSelecionado
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


        private BindingList<TipoInvestimento> _itemCollection;
        public BindingList<TipoInvestimento> ItemCollection
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
            TipoInvestimento tipoInvestimento;

            switch (TipoOperacaoAtiva)
            {
                case eTipoOperacao.Visualizar:
                    break;
                case eTipoOperacao.Adicionar:
                    tipoInvestimento = new TipoInvestimento { Nome = NomeEmEdicao };
                    ret = _tipoInvestimentoRepository.Adicionar(tipoInvestimento);

                    break;
                case eTipoOperacao.Editar:

                    tipoInvestimento = ItemSelecionado;
                    tipoInvestimento.Nome = NomeEmEdicao;
                    ret = _tipoInvestimentoRepository.Atualizar(tipoInvestimento);

                    break;
                case eTipoOperacao.Excluir:
                    ret = _tipoInvestimentoRepository.Deletar(ItemSelecionado.PK_TipoInvestimento);

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
                _itemCollection = new BindingList<TipoInvestimento>();

            if (_itemCollection.Count > 0)
                _itemCollection.Clear();

            var itens = _tipoInvestimentoRepository.ObterLista();
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