using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class DetalheInvestimentoRepository : Repository<DetalheInvestimento>, IDetalheInvestimentoRepository
    {
        public DetalheInvestimentoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
