using NAControle.Domain.Interfaces;
using NAControle.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EntityContext _context;

        public UnitOfWork(EntityContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
