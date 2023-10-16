using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewFithub.Controllers
{
	public class DataUserController : Controller
	{
		// GET: DataUserController
		public ActionResult Index()
		{
			return View();
		}

		// GET: DataUserController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: DataUserController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: DataUserController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
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

		// GET: DataUserController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: DataUserController/Edit/5
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

		// GET: DataUserController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: DataUserController/Delete/5
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
