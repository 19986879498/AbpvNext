using System;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AbpvNext.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule)
        )]
    public class AbpvNextDomainModule:AbpModule
    {
    }
}
