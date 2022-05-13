using Gene2InfoNext.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gene2InfoNext.DataAccess.Contexts
{
    public class BaseContext:DbContext
    {
        public DbSet<Region> Regions { get; set; }
    }
}
