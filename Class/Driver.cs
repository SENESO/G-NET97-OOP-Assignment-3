using System;

namespace OOP_Assignment_3.Class
{
    #region Question 5 Class Relationships
    internal class Driver
    {
        public int DriverId { get; private set; }
        public string FullName { get; private set; }
        public string PhoneNumber { get; private set; }

        public Driver(int driverId, string fullName, string phoneNumber)
        {
            if (driverId <= 0)
                throw new ArgumentOutOfRangeException(nameof(driverId), "Driver ID must be positive.");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Full name is required.", nameof(fullName));
                
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number is required.", nameof(phoneNumber));

            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString() => $"{FullName} (ID: {DriverId}) - Phone: {PhoneNumber}";
    }
    #endregion
}
