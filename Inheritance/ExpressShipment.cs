using System;
using OOP_Assignment_3.Class;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Inheritance
{
    internal class ExpressShipment : Shipment
    {
        public decimal ExtraFee { get; set; }

        #region Question 2 Constructor Chaining
        public ExpressShipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion

        #region Question 3 Override EstimatedCost
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m) + ExtraFee;
        #endregion

        #region Question 4 Override PrintShipment
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            base.PrintShipment();
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
        }
        #endregion
    }
}
