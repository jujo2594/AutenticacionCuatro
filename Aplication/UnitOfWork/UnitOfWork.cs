using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AutenticacionContext _context;
        private ICiudad _ciudades;
        private IDepartamento _departamentos;
        private IDireccion _direcciones;
        private IGenero _generos;
        private IMatricula _matriculas;
        private IPais _paises;
        private IPersona _personas;
        private ISalon _salones;
        private ITipoPersona _tipoPersonas;
        public UnitOfWork(AutenticacionContext context)
        {
        _context = context;
        }

        public ICiudad Ciudades
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _ciudades;
            }
        }

        public IDepartamento Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _departamentos;
            }
        }

        public IDireccion Direcciones
        {
            get
            {
                if (_direcciones == null)
                {
                    _direcciones = new DireccionRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _direcciones;
            }
        }

        public IGenero Generos
        {
            get
            {
                if (_generos == null)
                {
                    _generos = new GeneroRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _generos;
            }
        }

        public IMatricula Matriculas
        {
            get
            {
                if (_matriculas == null)
                {
                    _matriculas = new MatriculaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _matriculas;
            }
        }

        public IPais Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _paises;
            }
        }

        public IPersona Personas
        {
            get
            {
                if (_personas == null)
                {
                    _personas = new PersonaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _personas;
            }
        }

        public ISalon Salones
        {
            get
            {
                if (_salones == null)
                {
                    _salones = new SalonRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _salones;
            }
        }

        public ITipoPersona TipoPersonas
        {
            get
            {
                if (_tipoPersonas == null)
                {
                    _tipoPersonas = new TipoPersonaRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _tipoPersonas;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}