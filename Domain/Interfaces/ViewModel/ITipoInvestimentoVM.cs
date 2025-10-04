using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Enumeradores;

namespace CF.Domain.Interfaces.ViewModel
{
    public interface ITipoInvestimentoVM
    {
        eTipoOperacao TipoOperacaoAtiva { get; }
        string DescricaoOperacao { get; }
        bool HabilitarTexto { get; }
        bool NaoEstaEditando { get; }
        bool EstaEditando { get; }
        TipoInvestimento ItemSelecionado { get; set; }
        string NomeEmEdicao { get; set; }
        string NomeEmExibicao { get; set; }
        BindingList<TipoInvestimento> ItemCollection { get; }

        bool NomeInvalido { get; }
        bool NomeValido { get; }

        void DefinirPadraoInicial();
        void Salvar();
        void ValidarNome();
        void HabilitarOperacao(eTipoOperacao tipoOperacao);
    }
}
