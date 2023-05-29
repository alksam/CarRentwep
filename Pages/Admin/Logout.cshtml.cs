using CarRentwep.serveis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentwep.Pages.Admin
{
    public class LogoutModel : PageModel
    {
        private IUserService _service;

        public LogoutModel()
        {

        }

        public IActionResult OnGet()
        {
            _service = SesssionHelper.GetUser(HttpContext);
            _service.UserLoggedOut();
            SesssionHelper.SetUser(_service, HttpContext);

            return RedirectToPage("Index");
        }
    }
}
