using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class EntidadeFinanceiraRepository : Repository<EntidadeFinanceira>, IEntidadeFinanceiraRepository
    {
        public EntidadeFinanceiraRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
