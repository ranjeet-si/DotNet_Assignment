namespace DataTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //byte gp1 = 8;
            //byte gp2 = 4;
            //byte gp3 = 3;

            //byte totalgp = (byte) (gp1 + gp2 + gp3);
            //double d1 = 34766476437883343466343424.5631963378311853215842320985;

            //float f1 = 34.5f;

            bool isEligible = false;


            //if (age >= 18)
            //{
            //    isEligible = true;

            //}
            //else
            //{
            //    isEligible = false;
            //}

            do {
                Console.WriteLine("***MENU****");
                Console.WriteLine("1.ADD Details");
                Console.WriteLine("2.UPDATE Details");
                Console.WriteLine("3.DELETE Details");
                Console.WriteLine("4.EXIT");

                Console.WriteLine("Enter Your choice");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add the details");
                        break;
                    case 2:
                        Console.WriteLine("Update the Details");
                        break;
                    case 3:
                        Console.WriteLine("Delete the details");
                        break;
                    case 4:
                        Console.WriteLine("ThankYou");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

                Console.WriteLine("Enter Your choice");
                int toContinue = Convert.ToChar(Console.ReadLine());


            } while( toContinue=='y' || toContinue == 'Y')
           


            Console.WriteLine();
            Console.WriteLine();
        }
    }
}