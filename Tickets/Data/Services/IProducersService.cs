using Tickets.Data.Base;
using Tickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Data.Services
{
    public interface IProducersService:IEntityBaseRepository<Producer>
    {
    }
}
