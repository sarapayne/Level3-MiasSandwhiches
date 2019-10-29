using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;

namespace MiasSandwhiches
{
    [Serializable()]
    class StockCategory
    {
        //sets the variables and get sets for the stock category objects
        public string Name { get; set; }
        public string Catagory0 { get; set; }
        public string Catagory1 { get; set; }
        public string Catagory2 { get; set; }
        public string Catagory3 { get; set; }
    }
}
