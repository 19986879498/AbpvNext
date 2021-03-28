using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace AbpvNext.Domain.UserInfo
{
   public class Users:Entity<int>
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
    }
}
