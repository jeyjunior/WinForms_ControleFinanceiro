using CF.Domain.Entity;
using CF.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CF.InfraData.Repository
{
    public class TipoTransacaoRepository : Repository<TipoTransacao>, ITipoTransacaoRepository
    {
        public TipoTransacaoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
