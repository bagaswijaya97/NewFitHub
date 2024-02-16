using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewFithub.Models;
using System.Globalization;

namespace NewFithub.Controllers
{
	public class DataUserController : Controller
	{
		#region Initials
		List<DataUserViewModel> objDataUser = new List<DataUserViewModel>();

		#endregion

		// GET: DataUserController
		public ActionResult Index()
		{
			DateTime now = DateTime.Now;
			//string strBirthDate = now.ToString("dd MMM yyyy", new CultureInfo("id-ID"));
			string strBirthDate = "15 Sept 1997";
			List<DataUserViewModel> listOfUsers = new List<DataUserViewModel>
			{
				new DataUserViewModel
				{
					Username = "6281288201049",
					CardNumber = "1000150991997",
					FullName = "Bagas Wijaya",
					BirthDate = strBirthDate,
					Product = "Managed Care",
					CorporateName = "PT. FITAJA DIGITAL NUSANTARA"
				}
			    // Tambahkan objek DataUserViewModel lain di sini
			};

			objDataUser.AddRange(listOfUsers);

			return View(objDataUser);
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
