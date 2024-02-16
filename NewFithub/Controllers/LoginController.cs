using Microsoft.AspNetCore.Mvc;
using NewFithub.Models;

namespace NewFithub.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            // Ambil nilai ErrorMessage dari TempData
            string errorMessage = TempData["ErrorMessage"] as string;

            // Reset ErrorMessage untuk menghindari tampilan terus menerus
            TempData["ErrorMessage"] = null;

            // Kirim pesan ke view
            ViewBag.ErrorMessage = errorMessage;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string strEmail = model.Email;
                    string strPassword = model.Password;

                    if (IsValidUser(strEmail, strPassword))
                    {
                        ViewBag.SuccessMessage = "Berhasil Login!";
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "Email atau password salah.";
                    }
                }
                else
                {
                    TempData["ErrorMessage"] = "Data login tidak valid.";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately, log the exception, or display a generic error message.
                TempData["ErrorMessage"] = "Terjadi kesalahan saat proses login.";
                return RedirectToAction("Index");
            }
        }


        private bool IsValidUser(string email, string password)
        {
            // Gantilah ini dengan logika autentikasi yang sesuai dengan kebutuhan Anda.
            // Contoh sederhana: jika email dan password sesuai, maka dianggap berhasil.
            return (email == "bagas.wijaya@fitaja.id" && password == "BagasTampanSekali");
        }
    }
}
