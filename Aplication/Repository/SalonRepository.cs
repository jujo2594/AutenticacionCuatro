using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class SalonRepository : GenericRepository<Salon>, ISalon
    {
        private readonly AutenticacionContext _context;

        public SalonRepository(AutenticacionContext context) : base(context)
        {
            _context = context;
        }
    }
}