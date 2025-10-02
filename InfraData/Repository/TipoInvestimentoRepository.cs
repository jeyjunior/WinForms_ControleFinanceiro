using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class TipoInvestimentoRepository : Repository<TipoInvestimento>, ITipoInvestimentoRepository
    {
        public TipoInvestimentoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
