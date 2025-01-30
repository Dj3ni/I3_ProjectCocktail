using ASP_MVC.Mappers;
using ASP_MVC.Models.User;
using BLL.Entities;
using BLL.Services;
using Common.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC.Controllers
{

	public class UserController : Controller
	{
		// with a repo pattern
		private IUserRepository<BLL.Entities.User> _userService;
		public UserController(IUserRepository<User> userService)
		{
			_userService = userService;
		}

		// We build a constructor for our controller to be able to inject Service in the actions.(if no repo pattern) 
		//private UserService _userService;
		//public UserController(UserService userService)
		//{
		//	_userService = userService;
		//}

		//If no dependency injection
		//public UserController()
		//{
		//	_userService = new UserService();
		//}

		// GET: UserController

		public ActionResult Index()
		{
			try
			{
				IEnumerable<UserListItem> model = _userService.GetAll().Select(bll => bll.ToListItem());
				return View(model);
			}
			catch
			{
				return RedirectToAction("Error", "Home");
			}
			
		}

		// GET: UserController/Details/5
		public ActionResult Details(Guid id)
		{
			try
			{
				//We use the mapper method to converte BLL object to ASP object
				UserDetails model = _userService.Get(id).ToDetails();
				return View(model);
			}
			catch (Exception)
			{
				return RedirectToAction("Error", "Home");
			}
		}

		// GET: UserController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: UserController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(UserCreateForm form)
		{
			try
			{
				if (!form.Consent) ModelState.AddModelError(nameof(form.Consent), "Vous devez acceptez les termes et conditions pour continuer plus loin ");
				if (!ModelState.IsValid) throw new ArgumentException();
				//We need to convert the form into a BLL object
				Guid id = _userService.Insert(form.ToBLL());// we stock the id in the variable so we can use it for the redirect

				return RedirectToAction(nameof(Details), new {id});
			}
			catch
			{
				return View();
			}
		}

		// GET: UserController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: UserController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: UserController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: UserController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
