using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewFithub.Controllers
{
	public class DataMenuController : Controller
	{
		// GET: DataMenuController
		public ActionResult Index()
		{
			return View();
		}

		// GET: DataMenuController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: DataMenuController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: DataMenuController/Create
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

		// GET: DataMenuController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: DataMenuController/Edit/5
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

		// GET: DataMenuController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: DataMenuController/Delete/5
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
