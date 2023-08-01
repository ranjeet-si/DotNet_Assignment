namespace CarObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car("Farar", "Red", 78);
            //Car c2 = new Car("BMW", "Black", 67);
            //Car c3 = new Car("newCar", "Blue");

            //Car c4 = new Car();

            //c4.CarName = "Tesla";

            //c3.Display();



            //c4.Display();
            //c2.Display(); 
            //Console.ReadKey();

            //c1.Speed(45);
            //c2.Speed(69);

            //c1.Display();
            //c2.Display();
            //Console.ReadKey();

            Employee e1 = new Employee();

            e1.Name = "Aamar";
            e1.Salary = 270000;

            e1.CalculatesSalary(15000, 450);
            e1.Display();

           
        }
    }
}