using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Context
{
    public class HelloAppContext:DbContext
    {
        public HelloAppContext(DbContextOptions<HelloAppContext> options) : base(options) 
        {
            
        }

        public virtual DbSet<Entity.UserEntity> Users { get; set; }
    }
}
