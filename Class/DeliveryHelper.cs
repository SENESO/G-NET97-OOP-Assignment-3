using System;
using OOP_Assignment_3.Class;

namespace OOP_Assignment_3.Class
{
    #region Question 7 Create DeliveryHelper
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
    #endregion
}
