using AbpvNext.Domain.UserInfo;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace AbpvNext.Application.My
{
   public interface IMyService:IApplicationService
    {
        public Users GetUsers();
    }
}
