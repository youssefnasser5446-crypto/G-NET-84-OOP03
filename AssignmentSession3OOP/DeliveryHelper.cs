using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession3OOP
{
    static public class DeliveryHelper
    {
        static public void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
                Console.WriteLine(shipment.PrintShipment());
        }
    }
}
