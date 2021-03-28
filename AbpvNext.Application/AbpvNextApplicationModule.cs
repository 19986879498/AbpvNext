using System;
using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace AbpvNext.Application
{
    [DependsOn(
        typeof(AbpDddApplicationModule)
        )]
    public class AbpvNextApplicationModule:AbpModule
    {
    }
}
