using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP222testProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humans human1 = new Humans();

            human1.personName = "Hiran";
            human1.phoneNumber = 99999;
            human1.HumanDetails();
            human1.Talk();

            Console.WriteLine("Welcome");
            Console.WriteLine("addtion of two numbers");
            Console.WriteLine("Please enter the first number");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second Number");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            Calculator.Addition(firstNumb, secondNumb);
            Console.ReadLine();

        
        }
    }
}
