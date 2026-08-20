using System;

namespace OOP_Assignment_3.Class
{
    #region Question 5 Class Relationships
    internal class Driver
    {
        public int DriverId { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }

        public Driver(int driverId, string? fullName, string? phoneNumber)
        {
            DriverId = driverId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{FullName} (ID: {DriverId}) - Phone: {PhoneNumber}";
        }
    }
    #endregion
}
