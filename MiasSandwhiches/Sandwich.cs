using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwhiches
{
    [Serializable()]
    class Sandwich
    {
        //sets the variables and get sets for sandwich items
        public Stock Bread { get; set; }
        public Stock Spread { get; set; }
        public Stock Sauce { get; set; }
        public Filling Fillings { get; set; }
        public Salad SaladItems { get; set; }
        public decimal Price { get; set; }
    }
}
