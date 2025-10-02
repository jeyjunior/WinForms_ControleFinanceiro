using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class TipoEntidadeFinanceiraRepository : Repository<TipoEntidadeFinanceira>, ITipoEntidadeFinanceiraRepository
    {
        public TipoEntidadeFinanceiraRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
