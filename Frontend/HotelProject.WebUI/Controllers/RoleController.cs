using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Role;
using HotelProject.WebUI.ViewComponents.Default;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
	public class RoleController : Controller
	{
		private readonly RoleManager<AppRole> _roleManager;
		public RoleController(RoleManager<AppRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public IActionResult Index()
		{
			var values = _roleManager.Roles.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddRole()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> AddRole(AddRoleViewModel addRoleViewModel)
		{
			AppRole appRole = new AppRole()
			{
				Name = addRoleViewModel.RoleName

			};
			var result = await _roleManager.CreateAsync(appRole);
			if (result.Succeeded)
			{
				return RedirectToAction("Index");
			}
			return View();
		}


		[HttpGet]
		public IActionResult UpdateRole(int id)
		{
			var values =_roleManager.Roles.Where(x=>x.Id== id).FirstOrDefault();
			UpdateRoleViewModel roleViewModel = new UpdateRoleViewModel()
			{
				Id = values.Id,
				RoleName = values.Name
			};
			return View(roleViewModel);
		} 


		[HttpPost]
		public async Task< IActionResult> UpdateRole(UpdateRoleViewModel updateRoleView)
		{
			var values= _roleManager.Roles.Where(x=>x.Id ==updateRoleView.Id).FirstOrDefault();
			values.Name=updateRoleView.RoleName;
			await _roleManager.UpdateAsync(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task< IActionResult> DeleteRole(int id)
		{
			var values = _roleManager.Roles.Where(x => x.Id == id).FirstOrDefault();
			await _roleManager.DeleteAsync(values);
			return RedirectToAction("Index");
		}

	}
}
