namespace Delegate
{
    internal class Program
    {

        //  Step-1 

        //delegate void GreetingDelegate(string str);
        //public delegate int CalculatorDelegate(int x, int y);

        //public delegate T CalculatorDelegate<T>(T x, T y);



        static void Main(string[] args)
        {

            //NumberDisplay numberDisplay = new NumberDisplay();

            //List<double> numbers = new List<double>() { 12.32,23.34,43.44,92.43};

            //NumberDisplay numberDisplay = new NumberDisplay();
            //List<double> numbers = new List<double>() { 12.32,23.34,43.44,92.43};
            //numberDisplay.DisplayNumbers(numbers, numberDisplay.FormatCurrency);
            //numberDisplay.DisplayNumbers(numbers, numberDisplay.FormatPercentage);

            // step-2  creating delegate
            //GreetingDelegate greet = DisplayWelcome;

            // Step-3 call Delegate

            //greet("Ranjeet");


            //greet += DisplayThankyou;

            //greet("jeet");

            /*GreetingDelegate greetingDelegate = DisplayThankyou;

            greetingDelegate("Amarjit"); */





            //  Console.WriteLine("Enter Login or Logout");

            //string choice =Convert.ToString(Console.ReadLine());

            //DisplayWelcome(choice);

            //Calculator calculator = new Calculator();
            //CalculatorDelegate<int> del1 = calculator.add;

            //CalculatorDelegate<int> del2 = calculator.addDouble;

            //CalculatorDelegate<string> del3 = calculator.Concate;

            //Console.WriteLine("Enter The arithmetic opretion");
            //char op = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("Enter The arithmetic oprend-1");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter The arithmetic oprend-2");
            //int y = Convert.ToInt32(Console.ReadLine());
            //CalculatorDelegate calcDel = null;


            //try {

            //    switch (op)
            //    {
            //        case '+':
            //            calcDel = calculator.add;
            //            break;
            //        case '-':
            //            calcDel = calculator.sub;
            //            break;
            //        case '*':
            //            calcDel = calculator.mul;
            //            break;
            //        case '/':
            //            calcDel = calculator.div;
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input");
            //            break;
            //    }

            //    Program p = new Program();

            //    DisplayResult(x,y,calcDel);

            //int result = calcDel(x, y);

            //Console.WriteLine("Result" + result);

            //    }

            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }




            //    Console.ReadLine();


            //}

            //public static void DisplayResult(int x, int y, CalculatorDelegate del)
            //{

            //    int result = del(x, y);

            //    Console.WriteLine("Result: " + result);

            //}


            //static void DisplayWelcome(string name)
            //{
            //    Console.WriteLine($"Hii {name} Welcome !");
            //}

            //static void DisplayThankyou(string name)
            //{
            //    Console.WriteLine($"Thankyou {name}");
            //}



        }
    }
}