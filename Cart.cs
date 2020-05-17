using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv7
{
    class Cart : IItem
    {
        private List<IItem> items;

        public Cart()
        {
            this.items = new List<IItem>();
        }

        public double Accept(IVisitor visitor)
        {
            double sum = 0;
            foreach(IItem item in items)
            {
                sum += visitor.Visit(item);
            }
            return sum;
        }

        public void AddToCart(IItem item)
        {
            items.Add(item);
        }
        public void RemoveFromCart(IItem item)
        {
            items.Remove(item);
        }

        
    }
}
