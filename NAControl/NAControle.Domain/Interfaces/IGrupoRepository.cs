using NAControle.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Interfaces
{
    public interface IGrupoRepository: IRepository<Grupo>
    {
        List<Grupo> GetTodosGrupos();
    }
}
