using AbpvNext.Application.User.Dto;
using AbpvNext.Domain.UserInfo;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpvNext.Application
{
   public class AbpvNextAutoMapperProfile:Profile
    {
        public AbpvNextAutoMapperProfile()
        {
            CreateMap<Users, UserDto>();
        }
    }
}
