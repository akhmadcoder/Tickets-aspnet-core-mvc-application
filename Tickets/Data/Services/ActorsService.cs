using Microsoft.EntityFrameworkCore;
using Tickets.Data.Base;
using Tickets.Models;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context){}
    }
}
