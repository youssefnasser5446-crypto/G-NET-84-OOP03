using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession3OOP.inheritance
{
    public class ExpressShipment : Shipment
    {
        decimal extraFee;
        public ExpressShipment(string? _trackingCode, string _description, decimal _weight, decimal _deliveryFee, decimal _extraFee) : base(_trackingCode, _description, _weight, _deliveryFee)
        {
            ExtraFee = _extraFee;


        }

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + Weight * 5 + ExtraFee;
            }
        }
        public override string PrintShipment()
        {
            return $" trackingCode : {TrackingCode}\n " +
                $"description  : {Description} \n " +
                $" weight : {Weight}\n    deliveryFee : {DeliveryFee}  \n ExtraFee : {ExtraFee} \n " +
                        $" Estimated cost : {EstimatedCost} ";
        }

    }
}
