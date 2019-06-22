using NAControle.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NAControle.Domain.Handlers
{
    public class CommandHandler
    {
        private readonly IUnitOfWork _uow;

        protected CommandHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        protected bool Commit()
        {
            if (_uow.Commit()) return true;

            return false;
        }
    }
}
