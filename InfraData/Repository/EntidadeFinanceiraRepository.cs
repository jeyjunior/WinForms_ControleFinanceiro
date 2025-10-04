using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class EntidadeFinanceiraRepository : Repository<EntidadeFinanceira>, IEntidadeFinanceiraRepository
    {
        public EntidadeFinanceiraRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<TipoEntidadeFinanceira> ObterListaTipoEntidadeFinanceira()
        {
            var tipoEntidadeFinanceiraCollection = new List<TipoEntidadeFinanceira>();

            tipoEntidadeFinanceiraCollection.Add(new TipoEntidadeFinanceira { PK_TipoEntidadeFinanceira = 1, Nome = "Comum" });
            tipoEntidadeFinanceiraCollection.Add(new TipoEntidadeFinanceira { PK_TipoEntidadeFinanceira = 2, Nome = "Investimento" });

            return tipoEntidadeFinanceiraCollection;
        }
    }
}
