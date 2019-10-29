using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwhiches
{
    [Serializable()]
    class Filling
    {   //sets variables and get set for fillings
        public decimal Price { get; set; }
        public List<Stock> Fillings { get; set; }
    }
}
