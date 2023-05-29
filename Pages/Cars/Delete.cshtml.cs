using CarRentwep.serveis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RentCar;

namespace CarRentwep.Pages.Cars
{
    public class DeleteModel : PageModel
    {
      
            /*
             * modtage dependency injection
             */
            private ICarRepositoryService _service;

            public DeleteModel(ICarRepositoryService service)
            {
                _service = service;
            }


            /*
             * Properties til viewet
             */

            public Car carr { get; set; }

            public void OnGet(int id)
            {
                carr = _service.GetById(id);
            }

            public IActionResult OnPostSlet(int id)
            {
                _service.Delete(id);
                return RedirectToPage("Index");
            }

            public IActionResult OnPostFortryd()
            {
                return RedirectToPage("Index");
            }
        }
     
        
    
}
