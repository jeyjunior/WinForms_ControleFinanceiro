using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class TipoEntidadeFinanceiraRepository : Repository<TipoEntidadeFinanceira>, ITipoEntidadeFinanceiraRepository
    {
        public TipoEntidadeFinanceiraRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
