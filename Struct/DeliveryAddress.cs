using System;

namespace OOP_Assignment_3.Struct
{
    #region Question 5 Class Relationships
    internal struct DeliveryAddress
    {
        public string City { get; }
        public string Street { get; }
        public int BuildingNumber { get; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required.", nameof(city));
            
            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street is required.", nameof(street));
                
            if (buildingNumber <= 0)
                throw new ArgumentOutOfRangeException(nameof(buildingNumber), "Building number must be positive.");

            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress() => $"{BuildingNumber} {Street}, {City}";
    }
    #endregion
}
