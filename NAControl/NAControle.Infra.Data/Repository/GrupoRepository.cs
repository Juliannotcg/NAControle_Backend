using System;
using System.Collections.Generic;
using System.Text;

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