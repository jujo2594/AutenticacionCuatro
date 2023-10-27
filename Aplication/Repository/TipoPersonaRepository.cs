using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersona
    {
        private readonly AutenticacionContext _context;

        public TipoPersonaRepository(AutenticacionContext context) : base(context)
        {
            _context = context;
        }
    }
}