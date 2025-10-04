using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Enumeradores;

namespace CF.Domain.Interfaces.ViewModel
{
    public interface ICategoriaVM
    {
        eTipoOperacao TipoOperacaoAtiva { get; }
        string DescricaoOperacao { get; }
        bool HabilitarTexto { get; }
        bool NaoEstaEditando { get; }
        bool EstaEditando { get; }
        Categoria CategoriaSelecionada { get; set; }
        string NomeCategoriaEmEdicao { get; set; }
        string NomeCategoriaDisplay { get; set; }
        BindingList<Categoria> CategoriaCollection { get; }

        bool NomeInvalido { get; }
        bool NomeValido { get; }

        void DefinirPadraoInicial();
        void Salvar();
        void ValidarNome();
        void HabilitarOperacao(eTipoOperacao tipoOperacao);
    }
}
