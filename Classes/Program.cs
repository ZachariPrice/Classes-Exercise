namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Tesla";   
            myCar.Model = "CyberTruck";
            myCar.Year = 2023;

            var Honda = new Car()
            {
                Make = "Honda",
                Model = "Sonata",
                Year = 2023
            };

            var chevy = new Car("Chevy", "Cruz", 2023);
           
            var carList = new List<Car>() { myCar, Honda, chevy };

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }





        }
    }
}
 