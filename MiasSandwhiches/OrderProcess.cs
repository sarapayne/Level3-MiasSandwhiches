using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwhiches

{
    [Serializable()]
    class OrderProcess
        /*
         * Everything in this class can be considered a tempory storage while an order is being put together. 
         * Everthing in here gets combined into an order object later. 
         */

    { //set variables and related get set methods used in the creation of an order
        public Stock ChosenBread { get; set; }
        public Stock ChosenSpread { get; set; }
        public Stock ChosenSauce { get; set; }
        public Filling ChosenFilling { get; set; }
        public Salad ChosenSalad { get; set; }
        public List<Sandwich> ChosenSandwhiches { get; set; }
        public List<string> ReciptList { get; set; }


        public OrderProcess()
        { //called at system startup, this makes new objects ready for orders
            ChosenSandwhiches = new List<Sandwich>();
            ChosenBread = new Stock();
            ChosenSpread = new Stock();
            ChosenSauce = new Stock();
            ChosenFilling = new Filling();
            ChosenSalad = new Salad();
            ReciptList = new List<string>();
        }

        public void ClearTempSandwhichVars()
        { //sets all variables back to null ready for a new sandwhich order
            ChosenBread = null;
            ChosenSpread = null;
            ChosenSauce = null;
            ChosenFilling = null;
            ChosenSalad = null;
        }
    }
}
