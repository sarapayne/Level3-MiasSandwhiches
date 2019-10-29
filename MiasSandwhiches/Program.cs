using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiasSandwhiches
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Storage ProcessStorage;
        public static OrderProcess ProcessOrder;
        [STAThread]
        static void Main()
        {
            ProcessOrder = new OrderProcess();
            ProcessStorage = new Storage();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}

/*
 Entry point creates two objects: ProcessStorage and Process Order. These in turn trigger actions in their classes.
 The form Main is then started.

Ordering OverView
=================
1. Customer picks from displayed bread options (only instock items show). This is saved as a bread stock in the order process class
2. Customer picks from displayed spread options (only instock items show). This is saved as a spread stock in the order process class
3. Customer picks from displayed sauce options (only instock items show). This is saved as a sauce stock in the order process class
4. Customer Picks Multiple Fillings (only instock items show), these are combined into a fillings list and stored in the OrderProcess class
5. Customer picks from multiple salad items (only instock items show), these are added to a salad items list and stored in the OrderProcess class
6. Customer confirms sandwihch, at which point all above is combined into a sandwhich object, which is then added to a list or sandwiches
7. Sandwhich creation variables cleared
8. Customer makes more sandwhiches if required, above steps repate
9. At checkout the list of sandwhich objects is used to display costs and is all combined into an orders object with date, time, price.
10. Customer pays and prints  recipt if required
12. Order object is added to the orders list. 


Checkout Stage
==============
Displays a list of all ordered sandwiches along with individual prices and the total price
Offers the user a choice to pay or cancel the order
Payment is not handled in this app, ass this is a kiosk its likely to be a chip and pin card machine.
This will mean payments will be procprocessed externally and be beyond the scope of this app.
It assume all payment are approved at this stage.

 
Stock Control Overview
=======================
When an item is selected the stock value for this item is reduced by 1. A record of this is placed in the reserved stock list. 
If the customer completes the transaction the reserved list is cleard.
If they don't for any reasons the reserved list is used to reset the stock levels before its cleared. Including system crashes or power cuts
Only instock items are ever displayed to customers.
This method prevents out of stock sales, and with just a small change would still protect even in a multi user enviroment. 


Stock Objects & Stock Cagagories Overview
==========================================
Each stock item has 4 catagories. 
    Category0 is system defined as Bread, Spread, Sauce, Filling, Salad
    Category1,2 and 3 are user customizeabe. eg. Bread, Baguette, White, Soft Crust. 
A stock item doesn't need to use all the categories, any which are not needed are called "Unused".
These stock descriptions are held in a StockCatagories object defined by the StockCatagories class, 
each one stored in its own list. The category name comprises of all 4 category levels
A stock item inherits all  from StockCatagories and adds price, quantity and image.
Stock Objects can not be made unless a corresponding stock catagory object is created first. 

*/



