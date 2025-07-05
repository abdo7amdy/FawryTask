using FawryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Classes
{
    public class Cheese : Product, IExpirable, IShippable
    {
        private DateTime ExpiryDate;
        private double Weight;

        public Cheese(string name, double price, int quantity, DateTime expiryDate, double weight)
            : base(name, price, quantity)
        {
            ExpiryDate = expiryDate;
            Weight = weight;
        }

        public override bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }

        public double GetWeight() => Weight;
        public string GetName() => Name;
    }

}
