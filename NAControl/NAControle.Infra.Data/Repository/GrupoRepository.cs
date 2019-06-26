using Microsoft.EntityFrameworkCore;
using NAControle.Domain.Interfaces;
using NAControle.Domain.Models;
using NAControle.Infra.Data.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace NAControle.Infra.Data.Repository
{
    public class GrupoRepository : Repository<Grupo>, IGrupoRepository
    {
        protected readonly EntityContext _context;
        public GrupoRepository(EntityContext context)
            : base(context)
        {
            _context = context;
        }

        public List<Grupo> GetTodosGrupos()
        {
            return _context.Grupo.Include(e => e.Endereco).ToList();
        }
    }
}