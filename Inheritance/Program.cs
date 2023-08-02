namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //DayScholar d1 = new DayScholar(); ;

            //d1.Id = 102;
            //d1.Name = "Ranjeet";
            //d1.Department = "IT";
            //d1.BusRoute = 234;

            //d1.DisplayStudentDetails();

            //Hostellar h1 = new Hostellar();
            //h1.Id = 201;
            //h1.Name = "Amar";
            //h1.Department = "CS";
            //h1.HostelFee = 4500;

            //h1.DisplayStudentDetails();

            //Console.ReadKey();

            Console.WriteLine("Choose Student Type:\t  1-DayScholar \t 2-Hostellar");

            int option = Convert.ToInt32(Console.ReadLine());
            

            switch (option)
            {
                case 1:
                    {
                        DayScholar d1 = new DayScholar();
                        d1.Id = 102;
                        d1.Name = "Ranjeet";
                        d1.Department = "IT";
                        d1.BusRoute = 234;

                        d1.DisplayStudentDetails();

                    }
                    break;
                case 2:
                    {
                        Hostellar h1 = new Hostellar();
                        h1.Id = 201;
                        h1.Name = "Amar";
                        h1.Department = "CS";
                        h1.HostelFee = 4500;

                        h1.DisplayStudentDetails();

                    }
                    break;
            }
        }
    }
}