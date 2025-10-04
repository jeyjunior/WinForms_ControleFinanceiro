using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Enumeradores;

namespace CF.Domain.Interfaces.ViewModel
{
    public interface ITipoEntidadeFinanceiraVM
    {
        eTipoOperacao TipoOperacaoAtiva { get; }
        string DescricaoOperacao { get; }
        bool HabilitarTexto { get; }
        bool NaoEstaEditando { get; }
        bool EstaEditando { get; }
        TipoEntidadeFinanceira ItemSelecionado { get; set; }
        string NomeEmEdicao { get; set; }
        string NomeEmExibicao { get; set; }
        BindingList<TipoEntidadeFinanceira> ItemCollection { get; }

        bool NomeInvalido { get; }
        bool NomeValido { get; }

        void DefinirPadraoInicial();
        void Salvar();
        void ValidarNome();
        void HabilitarOperacao(eTipoOperacao tipoOperacao);
    }
}
