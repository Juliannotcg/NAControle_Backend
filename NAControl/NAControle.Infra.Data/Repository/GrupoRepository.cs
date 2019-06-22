using NAControle.Domain.Interfaces;
using NAControle.Domain.Models;
using NAControle.Infra.Data.Contexts;

namespace NAControle.Infra.Data.Repository
{
    public class GrupoRepository : Repository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(EntityContext context)
            : base(context)
        {

        }
    }
}