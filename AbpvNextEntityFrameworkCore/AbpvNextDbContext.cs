﻿using AbpvNext.Domain.UserInfo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace AbpvNextEntityFrameworkCore
{
    [ConnectionStringName("Default")]
   public class AbpvNextDbContext:AbpDbContext<AbpvNextDbContext>
    {
        DbSet<Users> Users { get; set; }
        public AbpvNextDbContext(DbContextOptions<AbpvNextDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
