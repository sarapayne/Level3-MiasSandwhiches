using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiasSandwhiches
{
    [Serializable()]
    class Stock : StockCategory
    {
        //this inherits everything from stock category and adds the items below along with get sets
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set; }
    }
}
