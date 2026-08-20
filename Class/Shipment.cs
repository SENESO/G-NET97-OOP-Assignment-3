using System;
using OOP_Assignment_3.Struct;

namespace OOP_Assignment_3.Class
{
    internal class Shipment
    {
        public string TrackingCode { get; }
        
        private string description;
        public string Description
        {
            get => description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Description cannot be empty.", nameof(value));
                description = value;
            }
        }
        
        private decimal weight;
        public decimal Weight
        {
            get => weight;
            set 
            { 
                if (value <= 0m) 
                    throw new ArgumentOutOfRangeException(nameof(value), "Weight must be greater than zero.");
                weight = value; 
            }
        }
        
        private decimal deliveryFee;
        public decimal DeliveryFee
        {
            get => deliveryFee;
            protected set 
            { 
                if (value <= 0m) 
                    throw new ArgumentOutOfRangeException(nameof(value), "Delivery fee must be greater than zero.");
                deliveryFee = value; 
            }
        }

        #region Question 5 Class Relationships
        public DeliveryAddress Destination { get; set; }
        #endregion

        public virtual decimal EstimatedCost => DeliveryFee + (Weight * 5m);

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                throw new ArgumentException("Tracking code is required.", nameof(trackingCode));
                
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #region Overload UpdateWeight
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight <= 0m)
                throw new ArgumentOutOfRangeException(nameof(newWeight), "New weight must be positive.");
                
            Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight <= 0m)
                throw new ArgumentOutOfRangeException(nameof(newWeight), "New weight must be positive.");
            if (extraPackingWeight < 0m)
                throw new ArgumentOutOfRangeException(nameof(extraPackingWeight), "Extra packing weight cannot be negative.");
                
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
