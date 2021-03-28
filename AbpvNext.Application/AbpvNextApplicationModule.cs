using System;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace AbpvNext.Application
{
    [DependsOn(
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class AbpvNextApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(opt=> {
                opt.AddProfile<AbpvNextAutoMapperProfile>();
            });
            base.ConfigureServices(context);
        }
    }
}
