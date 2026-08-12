using AssignmentSession3OOP.inheritance;

namespace AssignmentSession3OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
              a)  What is the difference between Method Overloading and Method Overriding?

            ans => 1] Method overloading occurs at compile time, whereas method overriding occurs at runtime.
                   2] Method overloading same name but different parameter list, but overriding must same signature.

            b)  What is the difference between Static Binding and Dynamic Binding?

                 ans => Static binding is fast because it is executed at compile-time; 
            the reference determines which method is called. In contrast,
            dynamic binding is slower than static binding because the call occurs at runtime,
            and the object determines which method is called.  

             */

            #endregion

            #region Question02

            /*
             a)  What is the purpose of the sealed keyword when applied to a class?

            ans => A sealed class prevents other classes from inheriting from it

            b)  What is the difference between a sealed class and a sealed method?

            ans=> A `sealed` class prevents inheritance, effectively protecting the class itself. 
            However, a `sealed` method must be used in conjunction with the `override` keyword; 
            this means the method must be inherited and overridden before it can be marked as `sealed`,
            thereby protecting that specific method.

            c)  Can a sealed method be overridden? Why?

            ans => No, because the sealed keyword prevents further overriding of the method in derived classes

             */
            #endregion

            Driver driver = new Driver();
            DeliveryCenter delivery = new DeliveryCenter();
            driver.DriverId = 1;
            driver.FullName = "yousef";
            driver.PhoneNumber = "01101531445";
            delivery.Driver = driver;

            Console.WriteLine("Enter Delevery Center");
            string? deleveryName = Console.ReadLine();

            Shipment standard = new StandardShipment("SH001", "Laptop", 3, 80);
            Shipment Express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, 30);
            Shipment international = new InternationalShipment("SH003", "Televition", 8, 120, "Germany", 100);

            DeliveryCenter DC = new DeliveryCenter();
            Console.WriteLine(DC.AddShipment(standard) ? "Shipment Added Succssfully" : "Shipment Not Added");
            Console.WriteLine(DC.AddShipment(Express) ? "Shipment Added Succssfully" : "Shipment Not Added");
            Console.WriteLine(DC.AddShipment(international) ? "Shipment Added Succssfully" : "Shipment Not Added");

            Console.WriteLine("Standard Shipment\n");
            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("Express Shipment\n");
            DeliveryHelper.PrintShipmentDetails(Express);
            Console.WriteLine("International Shipment\n");
            DeliveryHelper.PrintShipmentDetails(international);

            Console.WriteLine("===========================================================");
            Console.WriteLine($"Printing Using DeliveryHelper...");
            Console.WriteLine("===========================================================");
            if (standard is not null)
                Console.WriteLine("Standard Shipment Printed Successfully.");
            if (Express is not null)
                Console.WriteLine("Express Shipment Printed Successfully.");
            if (international is not null)
                Console.WriteLine("International Shipment Printed Successfully.");


            Console.WriteLine("\n===========================================================");
            Console.WriteLine("Updating Weight ...\n");

            if (standard is not null)
            {
                Console.WriteLine($"Original Weight : {standard.Weight} KG");
                standard.UpdateWeight(5);
                Console.WriteLine($"Updated Weight : {standard.Weight} KG");

                standard.UpdateWeight(5, .5m);
                Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");
            }
            DC.PrintAllShipments();
            Console.Write("Enter Tracking code To Remove : ");
            string? trackCode = Console.ReadLine();


            bool isRmove;
            if (!string.IsNullOrWhiteSpace(trackCode) && trackCode != "")
            {
                isRmove = DC.RemoveShipment(trackCode);
            }
            else
            {
                Console.WriteLine("please enter Trace code");
                isRmove = false;
            }

            Console.WriteLine(isRmove ? "Removed Successfully" : "not Removed");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Remaining Shipment ");
            Console.WriteLine("===========================================================");



            Console.WriteLine("===========================================================");
            Console.WriteLine("Printing Using Shipment[]...");

            if (standard is not null && Express is not null && international is not null)
            {
                Shipment[] shipment = { standard, Express, international };
                foreach (Shipment ship in shipment)
                {
                    Console.WriteLine(ship.PrintShipment());
                }
            }
            // sealed class and method
            // sealed class canot be inheritance by other class
            // sealed method cannot be override by subclass
        }
    }
}
