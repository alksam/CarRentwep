using CarRentwep.serveis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CarRentwep.Pages.Admin
{
    public class LoginModel : PageModel
    {

        private IUserService _service;

        public LoginModel()
        {

        }




        [BindProperty]
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Der skal være et navn")]
        public string Name { get; set; }

        [BindProperty]
        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Password skal være mere end 6 tegn")]
        public string Password1 { get; set; }

        [BindProperty]
        [Required]
        [StringLength(25, MinimumLength = 6, ErrorMessage = "Password skal være mere end 6 tegn")]
        public string Password2 { get; set; }

        public void OnGet()
        {
            _service = SesssionHelper.GetUser(HttpContext);
        }

        public IActionResult OnPost()
        {
            _service = SesssionHelper.GetUser(HttpContext);

            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Password1 != Password2)
            {
                return Page();
            }

            if (Name == "admin" && Password1 == "secret")
            {
                _service.SetUserLoggedIn(Name, true);
            }
            else
            {
                _service.SetUserLoggedIn(Name, false);
            }


            SesssionHelper.SetUser(_service, HttpContext);
            return RedirectToPage("Index");
        }
    }
}

