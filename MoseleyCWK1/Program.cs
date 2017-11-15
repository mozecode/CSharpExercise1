using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName, lastName, noOfWidgetsInput, tempFInput;

            int noOfWidgets;

            double tempF, costPerWidget, totalCost, degC;


            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your first name: ");

            firstName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}!", firstName, lastName);

            Console.WriteLine(""); //deliberately left blank




            Console.Write("How many widgets would you like to purchase? ");

            noOfWidgetsInput = Console.ReadLine();

            noOfWidgets = int.Parse(noOfWidgetsInput);

            costPerWidget = 1.57;

            totalCost = costPerWidget * noOfWidgets;

            Console.Write("Your cost is {0:C}", totalCost);



            Console.WriteLine("");  //deliberately left blank
            Console.WriteLine("");  //deliberately left blank

            Console.Write("Enter a temperature in degrees Fahrenheit: ");
            tempFInput= Console.ReadLine();

            tempF = double.Parse(tempFInput);

            degC = (tempF - 32) * 5 / 9;

            Console.Write("The temperature is {0:F} degrees Celsius", degC);






            Console.ReadKey();

        }
    }
}
