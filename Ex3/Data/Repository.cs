using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Ex3.Models;

namespace Ex3.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAllItems() => _context.Items.ToList();
        public void AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public IEnumerable<Agent> GetAllAgents() => _context.Agents.ToList();
        public void AddAgent(Agent agent)
        {
            _context.Agents.Add(agent);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAllOrders() => _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Item).Include(o => o.Agent).ToList();
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public User? GetUserByCredentials(string email, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password && !u.Lock);
        }
    }
}