using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession3OOP.inheritance
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee) : base(_trackingCode, _description, _weight, _deliveryFee)
        {

        }
        public override string PrintShipment()
        {
            return $" trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee} ";
        }

    }
}

