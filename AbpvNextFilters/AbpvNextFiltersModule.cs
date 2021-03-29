using AbpvNextFilters.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.Modularity;

namespace AbpvNextFilters
{
    [DependsOn(
        
        )]
    public class AbpvNextFiltersModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddControllersWithViews(opt=> {
                opt.Filters.Add<AbpvNextExceptionFilterAttribute>();
            }).AddNewtonsoftJson();
            context.Services.AddSingleton<AbpvNextExceptionFilterAttribute>();
            base.ConfigureServices(context);
        }
    }
}
