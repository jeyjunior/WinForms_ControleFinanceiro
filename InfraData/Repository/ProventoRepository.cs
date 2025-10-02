using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class ProventoRepository : Repository<Provento>, IProventoRepository
    {
        public ProventoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
