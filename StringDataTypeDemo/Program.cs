namespace StringDataTypeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Hello";
            //string s2 = "Hello";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            //string s3 = new string("Thanks");
            //Console.WriteLine(s3);

            //char[] letters = { 'h', 'a', 'i' };

            //string s4 = new string(letters);
            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s1.Equals(s3));
            //Console.WriteLine(s1 == s2);
            //Console.WriteLine(s1 == s3);

            Console.WriteLine("Enter Your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter The Grade:");
            char grade = Convert.ToChar( Console.ReadLine());
            Console.WriteLine(" Name: {0} \n Age : {1} \t grade :{2} ",name,age,grade);

            string filePath = @"D:\DotNet";

        }
    }
}