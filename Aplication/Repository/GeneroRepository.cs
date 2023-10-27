using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class GeneroRepository : GenericRepository<Genero>, IGenero
    {
        private readonly AutenticacionContext _context;

        public GeneroRepository(AutenticacionContext context) : base(context)
        {
            _context = context;
        }
    }
}