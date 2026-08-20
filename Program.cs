using System;
using OOP_Assignment_3.Class;
using OOP_Assignment_3.Struct;
using OOP_Assignment_3.Inheritance;

namespace OOP_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 10 Main() Checklist
            Driver driver = new Driver(101, "Ahmed Mohamed", "0123456789");

            DeliveryCenter center = new DeliveryCenter("Central Hub");

            center.Driver = driver;

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Delivery Center");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine($"Driver : {center.Driver.FullName}");
            Console.WriteLine(new string('-', 40) + "\n");

            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Street 1", 10);
            StandardShipment stdShipment = new StandardShipment("SH001", "Laptop", 3m, 80m, addr1);

            DeliveryAddress addr2 = new DeliveryAddress("Giza", "Street 2", 20);
            ExpressShipment expShipment = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, addr2, 30m);

            DeliveryAddress addr3 = new DeliveryAddress("Alex", "Street 3", 30);
            InternationalShipment intShipment = new InternationalShipment("SH003", "Television", 8m, 120m, addr3, "Germany", 100m);

            center.AddShipment(stdShipment);
            center.AddShipment(expShipment);
            center.AddShipment(intShipment);

            center.PrintAllShipments();
            Console.WriteLine(new string('=', 40) + "\n");

            Console.WriteLine("Printing Using DeliveryHelper...\n");
            DeliveryHelper.PrintShipmentDetails(stdShipment);
            DeliveryHelper.PrintShipmentDetails(expShipment);
            DeliveryHelper.PrintShipmentDetails(intShipment);
            Console.WriteLine(new string('=', 40) + "\n");

            Console.WriteLine("Updating Weight...\n");
            Console.WriteLine($"Original Weight : {stdShipment.Weight} KG");
            stdShipment.UpdateWeight(5m);
            Console.WriteLine($"Updated Weight : {stdShipment.Weight} KG");
            stdShipment.UpdateWeight(5m, 0.5m);
            Console.WriteLine($"Updated Weight After Packing : {stdShipment.Weight} KG\n");
            Console.WriteLine(new string('=', 40) + "\n");

            Console.WriteLine("Printing Using Shipment[]...\n");
            Shipment[] mixedShipments = new Shipment[] { stdShipment, expShipment, intShipment };
            foreach (Shipment s in mixedShipments)
            {
                s.PrintShipment();
            }
            Console.WriteLine(new string('=', 40) + "\n");

            Console.WriteLine("Demonstrating Sealed Class and Method...\n");
            CompletedShipment completed = new CompletedShipment("SH004", "Book", 1m, 20m, addr1);
            completed.PrintShipment();

            PriorityInternationalShipment priority = new PriorityInternationalShipment("SH005", "Gold", 2m, 200m, addr3, "UAE", 50m);
            priority.GenerateCustomsReport();
            
            #endregion
        }
    }
}
