using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GigHub.Core.DTOs;
using GigHub.Core.Models;

namespace GigHub.App_Start
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ApplicationUser, UserDTO>();
            Mapper.CreateMap<Gig, GigDTO>();
            Mapper.CreateMap<Notification, NotificationDTO>();
        }
    }
}