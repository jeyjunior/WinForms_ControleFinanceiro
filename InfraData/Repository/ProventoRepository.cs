using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class ProventoRepository : Repository<Provento>, IProventoRepository
    {
        public ProventoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
