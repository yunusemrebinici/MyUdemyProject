﻿using AutoMapper;
using HotelProject.DataAccessLayer.EntitiyFramework;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDtos;
using HotelProject.WebUI.Dtos.RegisterDtos;
using HotelProject.WebUI.Dtos.ServiceDtos;

namespace HotelProject.WebUI.Mapping
{
	public class AutoMapperConfig:Profile
	{

        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();   
            CreateMap<LoginUserDto,AppUser>().ReverseMap();   

        }
    }
}
