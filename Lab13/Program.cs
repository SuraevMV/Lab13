using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Киров", 10, 50, 18.5);
            Console.WriteLine(building.Print());
            MultiBuilding multibuilding = new MultiBuilding("Москва", 15, 25, 35, 5);
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }             
    }
}
