using System;
using System.Runtime.ExceptionServices;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What type of vacation are you looking to go on: musical, tropical, adventurous? ");
            var vacationTypeInput = Console.ReadLine();
            
            Console.Write("How many people are in your group? ");
            var groupSizeInput = Console.ReadLine();
                
            var groupSize = int.Parse(groupSizeInput);




            string result = "Since you're a group of " + groupSize + " going on a(n) " + vacationTypeInput + " vacation, you should take a ";

            if (groupSize >= 1 && groupSize <= 2)
            {
                result += "first class flight to ";
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                result += "helicopter flight to ";
            }
            else if (groupSize >= 6)
            {
                result += "charter flight to ";
            }



            if (vacationTypeInput == "musical")
            {
                result += "New Orleans.";
            } 
            else if (vacationTypeInput == "tropical")
            {
                result += "a beach vacation in Mexico.";
            }
            else if (vacationTypeInput == "adventurous")
            {
                result += "whitewater rafting in the Grand Canyon.";
            }

            Console.WriteLine(result);
           

       
            
            








        }
    }
}
