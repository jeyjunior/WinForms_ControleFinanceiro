using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class AtivoFinanceiroRepository : Repository<AtivoFinanceiro>, IAtivoFinanceiroRepository
    {
        public AtivoFinanceiroRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
