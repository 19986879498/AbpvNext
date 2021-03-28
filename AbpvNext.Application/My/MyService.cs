using AbpvNext.Domain.UserInfo;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace AbpvNext.Application.My
{
    public class MyService : ApplicationService, IMyService
    {
        public Users GetUsers()
        {
            return new Users() { Name = "张三", RoleId = 1, UserID = 123, UserName = "h123456" };
        }
    }
}
