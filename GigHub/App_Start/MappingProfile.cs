using AutoMapper;
using GigHub.DTOs;
using GigHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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