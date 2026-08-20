using System;
using OOP_Assignment_3.Class;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Inheritance
{
    internal class StandardShipment : Shipment
    {
        #region Question 2 Constructor Chaining
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
        #endregion

        #region Question 3 Override EstimatedCost
        public override decimal EstimatedCost => base.EstimatedCost;
        #endregion

        #region Question 4 Override PrintShipment
        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            base.PrintShipment();
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP\n");
        }
        #endregion
    }
}
