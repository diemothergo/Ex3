using System.Collections.Generic;
using Ex3.Models;

namespace Ex3.Data
{
    public interface IRepository
    {
        IEnumerable<Item> GetAllItems();
        void AddItem(Item item);
        IEnumerable<Agent> GetAllAgents();
        void AddAgent(Agent agent);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order order);
        User? GetUserByCredentials(string email, string password);
    }
}