using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpvNextEntityFrameworkCore
{
    [DependsOn(
        typeof(AbpEntityFrameworkCoreModule)
        )]
   public class AbpvNextEntityFrameworkCoreModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpvNextDbContext>();
            Configure<AbpDbContextOptions>(opt=> {
                opt.UseSqlServer();
            });
            base.ConfigureServices(context);
        }
    }
}
