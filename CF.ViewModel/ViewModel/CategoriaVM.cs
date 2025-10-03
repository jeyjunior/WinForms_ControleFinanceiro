using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using CF.Domain.Interfaces.ViewModel;
using Domain.Entity;
using Domain.Enumeradores;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CF.ViewModel.ViewModel
{
    public class CategoriaVM : ViewModelBase, ICategoriaVM
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaVM()
        {
            _categoriaRepository = Bootstrap.ServiceProvider.GetRequiredService<ICategoriaRepository>();

            ConfiguracaoInicial();
        }

        private void ConfiguracaoInicial()
        {
            var categorias = _categoriaRepository.ObterLista();
            foreach (var item in categorias)
                _categoriaCollection.Add(item);
            
            HabilitarOperacao(eTipoOperacao.Visualizar);
        }
        
        private eTipoOperacao _tipoOperacao;
        public eTipoOperacao TipoOperacaoAtiva
        {
            get => _tipoOperacao;
            set
            {
                _tipoOperacao = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(EstaEditando));
                OnPropertyChanged(nameof(NaoEstaEditando));
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
                OnPropertyChanged(nameof(NomeCategoriaSelecionada));
            }
        }
        public string NomeCategoriaSelecionada 
        {
            get 
            {
                if (CategoriaSelecionada == null)
                    return "";

                if (_tipoOperacao == eTipoOperacao.Adicionar)
                    return "";

                return CategoriaSelecionada.Nome;
            } 
        }

        private BindingList<Categoria> _categoriaCollection = new BindingList<Categoria>();
        public BindingList<Categoria> CategoriaCollection
        {
            get => _categoriaCollection;
        }
        
        public void HabilitarOperacao(eTipoOperacao tipoOperacao)
        {
            TipoOperacaoAtiva = tipoOperacao;

            _descricaoOperacao = "Categoria selecionada:";

            switch (TipoOperacaoAtiva)
            {
                case eTipoOperacao.Visualizar:
                    break;
                case eTipoOperacao.Adicionar:
                    _descricaoOperacao = "Adicionar nova categoria:";
                    break;
                case eTipoOperacao.Editar:
                    _descricaoOperacao = "Editar categoria selecionada:";
                    break;
                case eTipoOperacao.Excluir:
                    _descricaoOperacao = "Excluir categoria selecionada:";
                    break;
                case eTipoOperacao.Salvar:
                    break;
                case eTipoOperacao.Cancelar:
                    break;
                default: break;
            }

            OnPropertyChanged(nameof(CategoriaCollection));
            OnPropertyChanged(nameof(DescricaoOperacao));
            OnPropertyChanged(nameof(HabilitarBotoes));
            OnPropertyChanged(nameof(HabilitarTexto));
        }
    }
}