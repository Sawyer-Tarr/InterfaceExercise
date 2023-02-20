using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;

            Car car1= new Car { Color = "Red", Logo = "Bowtie", Make = "Chevy", Model = "Impala", NumberOfDoors = 4, Sunroof = true, Slogan = "Find New Roads", Year = 2019};
            Truck truck1 = new Truck { BedSize = "Short", CabSize = "Extended", Color = "Blue", Make = "Chevy", Model = "Silverado", Logo = "Bowtie", Slogan = "Find New Roads", Year = 2015};
            SUV suv1 = new SUV { Make = "Jeep", Model = "Grand Wagoneer", ThirdRowSeating= true, Color = "Black", Slogan = "Anywhere. Do Anything.", Logo = "Jeep", Year = 2023, Engine = "V8" };

            //Creatively display and organize their values

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(truck1);
            vehicles.Add(suv1);
            vehicles.Add(car1);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Vehicle Make: {item.Make}");
                Console.WriteLine($"Vehicle Model: {item.Model}");
                Console.WriteLine($"Vehicle Year: {item.Year}");
                Console.WriteLine($"Vehicle Slogan: {item.Slogan}");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
