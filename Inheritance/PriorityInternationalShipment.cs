using System;
using OOP_Assignment_3.Class;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Inheritance
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        #region Question 2 Constructor Chaining
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
        }
        #endregion

        #region Question 9 Sealed Method
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"[PRIORITY] Generating priority customs report for {TrackingCode} to {DestinationCountry}...");
        }
        #endregion
    }
}
