using Asp.NetProjeKampi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetProjeKampi.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentValues = new List<UserComment>()
			{
				new UserComment
				{
					ID=1,
					Username="Barış"
				},
				new UserComment
				{
					ID=2,
					Username="Murat"
				},
				new UserComment
				{
					ID=3,
					Username="Gürkan"
				}

			};
			return View(commentValues);
		}
	} 
}
