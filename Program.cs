using System;

namespace StringInCSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Omar";
            string email = "OmarMaher100@gmail.com";

            string oldWay = string.Format("Old Way \n First name : {0} \n Email : {1}", firstName ,email);
            Console.WriteLine(oldWay);
            // New in C# 6
            string newWay = $"New Way in C# 6 \n First name : {firstName} \n Email : {email}";
            Console.WriteLine(newWay);

        }
    }
}
