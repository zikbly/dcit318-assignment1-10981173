using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            double ticketPrice;

            if (age >= 65 || age <= 12)
            {
                ticketPrice = 7.0;
            }
            else
            {
                ticketPrice = 10.0;
            }

            Console.WriteLine("Your Ticket price is " + "GHS" + ticketPrice);
        }
    }
}
