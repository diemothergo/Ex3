using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex3.Data;
using Ex3.Models;

namespace Ex3.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly IRepository _repository;

        public CreateModel(IRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Item Item { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _repository.AddItem(Item);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}