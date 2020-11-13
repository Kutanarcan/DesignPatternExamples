using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    class StoreOrder : OrderProcessTemplate
    {
        protected override void Delivery()
        {
            Console.WriteLine("Item delivered to in delivery counter.");
        }

        protected override void Payment()
        {
            Console.WriteLine("Pays at counter through cash/POS");
        }

        protected override void SelectItem()
        {
            Console.WriteLine("Customer chooses the item from shelf.");
        }
    }
}
