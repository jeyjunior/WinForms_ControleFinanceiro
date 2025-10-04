using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class TipoInvestimentoRepository : Repository<TipoInvestimento>, ITipoInvestimentoRepository
    {
        public TipoInvestimentoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
