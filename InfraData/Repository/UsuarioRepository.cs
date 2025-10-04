using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Entity;
using CF.Domain.Interfaces;

namespace CF.InfraData.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
