using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
