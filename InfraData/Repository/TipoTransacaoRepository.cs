using Domain.Entity;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraData.Repository
{
    public class TipoTransacaoRepository : Repository<TipoTransacao>, ITipoTransacaoRepository
    {
        public TipoTransacaoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
