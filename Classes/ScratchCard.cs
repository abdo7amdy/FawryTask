using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryTask.Classes
{
    public class ScratchCard : Product
    {
        public ScratchCard(string name, double price, int quantity)
            : base(name, price, quantity)
        {
        }

        public override bool IsExpired() => false;
    }

}
