using System;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Class
{
    internal class Shipment
    {
        public string? TrackingCode { get; private set; }
        public string? Description { get; set; }
        
        private decimal weight;
        public decimal Weight
        {
            get => weight;
            set { if (value > 0) weight = value; }
        }
        
        private decimal deliveryFee;
        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set { if (value > 0) deliveryFee = value; }
        }

        #region Question 5 Class Relationships
        public DeliveryAddress Destination { get; set; }
        #endregion

        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5m);

        public Shipment(string? trackingCode, string? description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #region Overload UpdateWeight
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
                Weight = newWeight + extraPackingWeight;
        }
        #endregion

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
        }
    }
}
