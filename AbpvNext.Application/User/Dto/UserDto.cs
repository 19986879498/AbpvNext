using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpvNext.Application.User.Dto
{
   public class UserDto:EntityDto<int>
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
    }
}
