using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ex3.Data;
using Ex3.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ex3.Pages
{
    public class FilterModel : PageModel
    {
        private readonly IRepository _repository;

        public FilterModel(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<(string ItemName, int TotalQuantity)>? BestItems { get; set; }
        public IEnumerable<Agent>? Agents { get; set; }
        [BindProperty]
        public int SelectedAgentId { get; set; }
        public IEnumerable<(string ItemName, int Quantity)>? ItemsByAgent { get; set; }

        public void OnGet()
        {
            BestItems = _repository.GetAllOrders()
                .SelectMany(o => o.OrderDetails)
                .GroupBy(od => od.Item.ItemName)
                .Select(g => (ItemName: g.Key ?? string.Empty, TotalQuantity: g.Sum(od => od.Quantity)))
                .OrderByDescending(x => x.TotalQuantity)
                .Take(5);
            Agents = _repository.GetAllAgents();
        }

        public IActionResult OnPost()
        {
            BestItems = _repository.GetAllOrders()
                .SelectMany(o => o.OrderDetails)
                .GroupBy(od => od.Item.ItemName)
                .Select(g => (ItemName: g.Key ?? string.Empty, TotalQuantity: g.Sum(od => od.Quantity)))
                .OrderByDescending(x => x.TotalQuantity)
                .Take(5);
            Agents = _repository.GetAllAgents();

            ItemsByAgent = _repository.GetAllOrders()
                .Where(o => o.AgentID == SelectedAgentId)
                .SelectMany(o => o.OrderDetails)
                .GroupBy(od => od.Item.ItemName)
                .Select(g => (ItemName: g.Key ?? string.Empty, Quantity: g.Sum(od => od.Quantity)));

            return Page();
        }
    }
}