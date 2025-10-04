using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class AtivoFinanceiroRepository : Repository<AtivoFinanceiro>, IAtivoFinanceiroRepository
    {
        public AtivoFinanceiroRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
