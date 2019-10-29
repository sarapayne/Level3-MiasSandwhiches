using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwhiches
{
    [Serializable()]
    class Salad
    {
        //sets the variablss and get sets for salad items
        public decimal Price { get; set; }
        public List<Stock> SaladItems { get; set; }
    }
}
