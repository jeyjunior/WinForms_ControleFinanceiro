using Domain.Entity;
using Domain.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CF.Domain.Interfaces.ViewModel
{
    public interface ICategoriaVM
    {
        bool EstaEditando { get; }
        bool NaoEstaEditando { get; }
        eTipoOperacao TipoOperacaoAtiva { get;}
        void HabilitarOperacao(eTipoOperacao tipoOperacao);
        string DescricaoOperacao { get; }
        string NomeCategoriaSelecionada { get; }
        BindingList<Categoria> CategoriaCollection { get; }
        bool HabilitarBotoes { get; }
        bool HabilitarTexto { get;  }
        Categoria CategoriaSelecionada { get; set; }
        void Salvar(Categoria categoria);
        void DefinirPadraoInicial();
    }
}
