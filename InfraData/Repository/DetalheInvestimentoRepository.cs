using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class DetalheInvestimentoRepository : Repository<DetalheInvestimento>, IDetalheInvestimentoRepository
    {
        public DetalheInvestimentoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
