using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using Domain.Interfaces;

namespace InfraData.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
