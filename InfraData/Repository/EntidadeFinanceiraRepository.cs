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
    }
}
