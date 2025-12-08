using Microsoft.AspNetCore.Mvc;
using TaskManagement.Models.Entities.Person;

namespace TaskManagement.Areas.ContractManagement.Controllers
{
    [Area("ContractManagement")]

    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePerson() => View(new PersonViewModel());


        [HttpPost]
        public IActionResult CreatePerson(PersonViewModel model)
        {
            if (model.Name == "admin")
            {
                ModelState.AddModelError(nameof(model.Name), "The name 'admin' is reserved.");
            }

            // Check if end date exceeds start date by 7 days
            if (model.EndDateTime < model.StartDateTime)
            {
                ModelState.AddModelError(nameof(model.EndDateTime), "End date cannot be before start date.");
            }
            else if ((model.EndDateTime - model.StartDateTime).TotalDays > 7)
            {
                ModelState.AddModelError(nameof(model.EndDateTime), "The period between start and end cannot exceed 7 days.");
            }
            var formErrors = new List<string>();

            if (model.Job == "sss")
            {
                formErrors = new List<string>
                    {
                        "Start date cannot be after end date",
                        "You must fill all required fields"
                    };
            }

            if (!ModelState.IsValid ||formErrors.Count>0)
            {
                return Json(new
                {
                    success = false,
                    formErrors = formErrors,
                    errors = ModelState.ToDictionary(
                        k => k.Key,
                        v => v.Value.Errors.Select(e => e.ErrorMessage).ToList()
                    )
                });
            }

            return Json(new { success = true });
        }


        public IActionResult Success() => View();
    }
}
