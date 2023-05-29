using CarRentwep.serveis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RentCar;

namespace CarRentwep.Pages.Cars
{
    public class IndexModel : PageModel
    {/*
      * modtage depenency injection 
      */
        private ICarRepositoryService _service;
        public IndexModel(ICarRepositoryService service)
        {
            _service = service;
        }

        public List<Car> carr { get; set; }

        
    public void OnGet()
        {
            carr= _service.GetAll();
        }
    }
}
