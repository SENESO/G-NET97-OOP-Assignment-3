using System;
using OOP_Assignment_3.Class;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Inheritance
{
    #region Question 8 Sealed Class
    internal sealed class CompletedShipment : Shipment
    {
        #region Question 2 Constructor Chaining
        public CompletedShipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        #endregion

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            base.PrintShipment();
        }
    }
    #endregion
}
