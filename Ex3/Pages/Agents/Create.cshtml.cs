using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex3.Data;
using Ex3.Models;

namespace Ex3.Pages.Agents
{
    public class CreateModel : PageModel
    {
        private readonly IRepository _repository;

        public CreateModel(IRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Agent Agent { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _repository.AddAgent(Agent);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}