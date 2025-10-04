using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class TransacaoRepository : Repository<Transacao>, ITransacaoRepository
    {
        public TransacaoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IEnumerable<TipoTransacao> ObterListaTipoTransacao()
        {
            var tipoTransacaoCollection = new List<TipoTransacao>();

            tipoTransacaoCollection.Add(new TipoTransacao { PK_TipoTransacao = 1, Nome = "Entrada" });
            tipoTransacaoCollection.Add(new TipoTransacao { PK_TipoTransacao = 2, Nome = "Saída" });

            return tipoTransacaoCollection;
        }
    }
}
