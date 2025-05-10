using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex3.Data;

namespace Ex3.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IRepository _repository;

        public LoginModel(IRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public string? Email { get; set; }
        [BindProperty]
        public string? Password { get; set; }

        public IActionResult OnPost()
        {
            var user = _repository.GetUserByCredentials(Email, Password);
            if (user != null)
            {
                return RedirectToPage("/Index");
            }
            ModelState.AddModelError("", "Invalid credentials");
            return Page();
        }
    }
}