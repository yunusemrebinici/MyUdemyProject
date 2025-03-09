using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.DtoLayer.AboutDtos;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntitiyFramework
{
	public class EfAboutDal:GenericRepository<About>,IAboutDal
	{
        public EfAboutDal(Context context):base(context) 
        {
            
        }

        public void UpdateAboutWithDto(UpdateAboutDto updateAboutDto)
        {
            var context = new Context();
            var values = context.Abouts.Find(updateAboutDto.AboutID);
            values.Title1=updateAboutDto.Title1;
            values.Title2=updateAboutDto.Title2;
            values.Content=updateAboutDto.Content;
            context.SaveChanges();
        }
    }
}
