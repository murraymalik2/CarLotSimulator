using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var lot = new CarLot();
            
            // DONE Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var malikIsCar = new Car();
            malikIsCar.Make = "Ford";
            malikIsCar.Model = "Focus";
            malikIsCar.Year = 2015;
            malikIsCar.EngineNoise = "vroom";
            malikIsCar.HonkNoise = "beep";
            malikIsCar.IsDrivable = true;

            lot.Cars.Add(malikIsCar);

            var stevesCar = new Car() 
            { 
            Year= 2019,
            Make = "Tesla",
            Model = "Cyber Truck",
            EngineNoise = "...",
            HonkNoise = "brmp",
            IsDrivable = false
            };
            lot.Cars.Add(stevesCar);

            //Using the constructor
            var brettsCar = new Car(2103, "Honda", "Civic", "vroom", "vruuuga", true);
            lot.Cars.Add(brettsCar);

            malikIsCar.MakeEngineNoise(malikIsCar.EngineNoise);
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);


            //*************BONUS*************//

            // DONE -Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars

            foreach (var car in lot.Cars)
            {
            Console.WriteLine($"Year:{car.Year} Make: {car.Make} Model: {car.Model}");
            }
            
        }
    }
}
