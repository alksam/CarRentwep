using CarRentwep.serveis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarRentwep.Pages.Admin
{
    public class Index1Model : PageModel
    {
        private IUserService _service;


        public bool IsAdmin
        {
            get
            {
                return _service.IsUserAdmin;
            }
        }

        public String Name => _service.UserName;



        public Index1Model()
        {

        }

        public IActionResult OnGet()
        {
            _service = SesssionHelper.GetUser(HttpContext);

            // tjek om user er logget in
            if (!_service.IsLoggedIn)
            {
                return RedirectToPage("Login");
            }

            return Page();
        }
    }
}
