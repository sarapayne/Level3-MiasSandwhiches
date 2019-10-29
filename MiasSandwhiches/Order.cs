using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwhiches
{
    [Serializable()]
    class Order
    {   //sets the variables and get sets for orders
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public List<Sandwich> OrderSandwhiches { get; set; }
    }
}
