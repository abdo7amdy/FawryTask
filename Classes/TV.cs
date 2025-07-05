using FawryTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Classes
{
    public class TV : Product, IShippable
    {
        private double Weight;

        public TV(string name, double price, int quantity, double weight)
            : base(name, price, quantity)
        {
            Weight = weight;
        }

        public override bool IsExpired() => false;

        public double GetWeight() => Weight;
        public string GetName() => Name;
    }

}
