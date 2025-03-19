using HotelProject.DataAccessLayer.EntitiyFramework;
using HotelProject.WebUI.Models.Setting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel=new UserEditViewModel();
            userEditViewModel.Name=values.Name;
            userEditViewModel.Surname=values.Surname;
            userEditViewModel.Email=values.Email;
            userEditViewModel.Username = values.UserName;
            return View(userEditViewModel);
        }

        [HttpPost]
        public IActionResult Index(string x)
        {
            return View();
        }
    }
}
