using System;

namespace OOP_Assignment_3.Class
{
    internal class DeliveryCenter
    {
        public string? CenterName { get; set; }

        #region Question 5 Class Relationships
        public Driver? Driver { get; set; }
        #endregion

        private Shipment[] shipments;
        private int currentCount;

        public int Count => currentCount;

        public DeliveryCenter(string? centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            currentCount = 0;
        }

        public Shipment this[int index]
        {
            get => (index >= 0 && index < currentCount) ? shipments[index] : default!;
            set { if (index >= 0 && index < currentCount) shipments[index] = value; }
        }

        public Shipment this[string? trackingCode]
        {
            get
            {
                if (trackingCode != null)
                {
                    for (int i = 0; i < currentCount; i++)
                    {
                        if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                            return shipments[i];
                    }
                }
                return default!;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (currentCount < shipments.Length)
            {
                shipments[currentCount] = shipment;
                currentCount++;
                return true;
            }
            return false;
        }

        public bool RemoveShipment(string? trackingCode)
        {
            if (trackingCode == null) return false;

            for (int i = 0; i < currentCount; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < currentCount - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }
                    shipments[currentCount - 1] = default!;
                    currentCount--;
                    return true;
                }
            }
            return false;
        }

        #region Question 6 Update DeliveryCenter
        public void PrintAllShipments()
        {
            for (int i = 0; i < currentCount; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].PrintShipment();
                    Console.WriteLine(new string('-', 30));
                }
            }
        }
        #endregion
    }
}
