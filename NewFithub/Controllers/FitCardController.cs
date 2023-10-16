using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NewFithub.Controllers
{
	public class FitCardController : Controller
	{
		// GET: FitCardController
		public ActionResult Index()
		{
			return View();
		}

		// GET: FitCardController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: FitCardController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: FitCardController/Create
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

		// GET: FitCardController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: FitCardController/Edit/5
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

		// GET: FitCardController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: FitCardController/Delete/5
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
