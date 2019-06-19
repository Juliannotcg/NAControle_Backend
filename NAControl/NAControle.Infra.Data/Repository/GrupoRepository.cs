using NAControle.Domain.Models;
using NAControle.Infra.Data.Contexts;

namespace NAControle.Infra.Data.Repository
{
    public class GrupoRepository : Repository<Grupo>
    {
        public GrupoRepository(EntityContext context)
            : base(context)
        {

        }
    }
}