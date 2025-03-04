using AutoMapper;
using HotelProject.DataAccessLayer.EntitiyFramework;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDtos;
using HotelProject.WebUI.Dtos.BookingDtos;
using HotelProject.WebUI.Dtos.LoginDtos;
using HotelProject.WebUI.Dtos.RegisterDtos;
using HotelProject.WebUI.Dtos.ServiceDtos;
using HotelProject.WebUI.Dtos.StaffDtos;
using HotelProject.WebUI.Dtos.SubscribeDtos;

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
            
            CreateMap<ResultAboutDto,About>().ReverseMap();   
            CreateMap<UpdateAboutDto,About>().ReverseMap();   

            CreateMap<ResultStaffDto,Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto,Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto,Booking>().ReverseMap();

          

        }
    }
}
