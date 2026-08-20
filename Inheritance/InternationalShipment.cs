using System;
using OOP_Assignment_3.Class;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Inheritance
{
    internal class InternationalShipment : Shipment
    {
        public string? DestinationCountry { get; set; }
        public decimal CustomsFee { get; set; }

        #region Question 2 Constructor Chaining
        public InternationalShipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string? destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        #endregion

        #region Question 3 Override EstimatedCost
        public override decimal EstimatedCost => DeliveryFee + (Weight * 5m) + CustomsFee;
        #endregion

        #region Question 4 Override PrintShipment
        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            base.PrintShipment();
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee   : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
        }
        #endregion

        #region Question 9 Sealed Method
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Generating customs report for {TrackingCode} to {DestinationCountry}...");
        }
        #endregion
    }
}
