using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
