using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }

        //najbolje ne koristiti ovaj this na constructorima
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            
           this.Name = name;
        }
        
    }
}