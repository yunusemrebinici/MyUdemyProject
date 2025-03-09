﻿using AutoMapper;
using HotelProject.DtoLayer.RoomDtos;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
	public class AutoMapperConfig:Profile
	{
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>();
            CreateMap<Room, AddRoomDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
