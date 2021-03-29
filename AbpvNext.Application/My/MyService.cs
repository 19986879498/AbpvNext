using AbpvNext.Application.User.Dto;
using AbpvNext.Domain.UserInfo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.ObjectMapping;

namespace AbpvNext.Application.My
{
    public class MyService : ApplicationService, IMyService
    {
        public  Task<UserDto> GetUserDtoAsync()
        {
            Users u = new Users() { Name = "汤士林", UserID = 123, UserName = "h123", RoleId = 1 };
            Task<UserDto> userDto = Task<UserDto>.Run(()=>{ return this.ObjectMapper.Map<Users, UserDto>(u); });
            return  userDto;
        }

        public Users GetUsers()
        {
            return new Users() { Name = "张三", RoleId = 1, UserID = 123, UserName = "h123456" };
        }
    }
}
