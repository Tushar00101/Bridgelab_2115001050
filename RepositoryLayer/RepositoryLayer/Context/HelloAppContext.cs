﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Context
{
    public class HelloAppContext : DbContext
    {
        public HelloAppContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<UserEntity> Users { get; set; }
    }
}
