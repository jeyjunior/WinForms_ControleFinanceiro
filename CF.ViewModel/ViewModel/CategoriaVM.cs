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
    public class CategoriaVM : ViewModelBase, ICategoriaVM
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaVM()
        {
            _categoriaRepository = Bootstrap.ServiceProvider.GetRequiredService<ICategoriaRepository>();

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
                OnPropertyChanged(nameof(NomeCategoriaDisplay));
            }
        }
        
        private string _descricaoOperacao;
        public string DescricaoOperacao { get => _descricaoOperacao; }
        
        public bool HabilitarBotoes 
        { 
            get
            {
                return CategoriaCollection.Count > 0;
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

        private Categoria _categoriaSelecionada;
        public Categoria CategoriaSelecionada
        {
            get => _categoriaSelecionada;
            set
            {
                _categoriaSelecionada = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NomeCategoriaDisplay));
            }
        }
        
        private string _nomeCategoriaEmEdicao;
        public string NomeCategoriaEmEdicao
        {
            get => _nomeCategoriaEmEdicao;
            set
            {
                _nomeCategoriaEmEdicao = value;
                OnPropertyChanged();
                if (EstaEditando)
                {
                    OnPropertyChanged(nameof(NomeCategoriaDisplay));
                    ValidarNome();
                }
            }
        }
        public string NomeCategoriaDisplay
        {
            get
            {
                if (EstaEditando)
                    return NomeCategoriaEmEdicao;
                
                return CategoriaSelecionada?.Nome ?? "";
            }
            set
            {
                if (EstaEditando)
                    NomeCategoriaEmEdicao = value;
            }
        }


        private BindingList<Categoria> _categoriaCollection;
        public BindingList<Categoria> CategoriaCollection
        {
            get => _categoriaCollection;
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
            Categoria categoriaParaSalvar;

            switch (TipoOperacaoAtiva)
            {
                case eTipoOperacao.Visualizar:
                    break;
                case eTipoOperacao.Adicionar:
                    categoriaParaSalvar = new Categoria { Nome = NomeCategoriaEmEdicao };
                    ret = _categoriaRepository.Adicionar(categoriaParaSalvar);

                    break;
                case eTipoOperacao.Editar:

                    categoriaParaSalvar = CategoriaSelecionada;
                    categoriaParaSalvar.Nome = NomeCategoriaEmEdicao;
                    ret = _categoriaRepository.Atualizar(categoriaParaSalvar);

                    break;
                case eTipoOperacao.Excluir:
                    ret = _categoriaRepository.Deletar(CategoriaSelecionada.PK_Categoria);

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
            if (_categoriaCollection == null)
                _categoriaCollection = new BindingList<Categoria>();

            if (_categoriaCollection.Count > 0)
                _categoriaCollection.Clear();

            var categorias = _categoriaRepository.ObterLista();
            foreach (var item in categorias)
                _categoriaCollection.Add(item);
        }
        public void ValidarNome() 
        {
            if (TipoOperacaoAtiva == eTipoOperacao.Adicionar || TipoOperacaoAtiva == eTipoOperacao.Editar)
            {
                if (string.IsNullOrWhiteSpace(NomeCategoriaEmEdicao))
                    _nomeInvalido = true;
                else if (CategoriaCollection.Any(i => i.Nome.Trim().ToLower().Equals(NomeCategoriaEmEdicao.Trim().ToLower())))
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

            _descricaoOperacao = "Categoria selecionada:";
            _nomeInvalido = false;

            switch (TipoOperacaoAtiva)
            {
                case eTipoOperacao.Adicionar:
                    _descricaoOperacao = "Adicionar nova categoria:";
                    NomeCategoriaEmEdicao = "";
                    break;
                case eTipoOperacao.Editar:
                    _descricaoOperacao = "Editar categoria selecionada:";
                    NomeCategoriaEmEdicao = CategoriaSelecionada?.Nome;
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