using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using HotelProject.WebUI.Dtos.AdminDashboardSocialMediaDtos;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
	public class _DashboardSocialMedia : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{

			#region linkedln



			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fcjfollini%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
				Headers =
	{
		{ "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				LinkedlnFollowersDto linkedlnFollowersDto = JsonConvert.DeserializeObject<LinkedlnFollowersDto>(body);
				ViewBag.LinkedinConnection = linkedlnFollowersDto.data.connection_count;
				ViewBag.LinledinFollowers = linkedlnFollowersDto.data.follower_count;
			}

			#endregion

			#region instagram

			
			var client1 = new HttpClient();
			var request1 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://instagram-best-experience.p.rapidapi.com/profile?username=nike"),
				Headers =
	{
		{ "x-rapidapi-key", "3c6d0fcd2bmshf14440917df7f17p16a024jsn1677367d9162" },
		{ "x-rapidapi-host", "instagram-best-experience.p.rapidapi.com" },
	},
			};
			using (var response1 = await client1.SendAsync(request1))
			{
				response1.EnsureSuccessStatusCode();
				var body1 = await response1.Content.ReadAsStringAsync();
				InstagramFollowersDto instagramFollowers=JsonConvert.DeserializeObject<InstagramFollowersDto>(body1);
				ViewBag.instagramFollow=instagramFollowers.following_count;
				ViewBag.instagramFollowers=instagramFollowers.follower_count;
			}
			#endregion
			return View();
		}
	}
}
