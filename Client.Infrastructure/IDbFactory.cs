using Client.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ClientEntities Init();
    }
}
