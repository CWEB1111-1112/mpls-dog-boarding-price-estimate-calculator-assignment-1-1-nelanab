using System;

namespace assignment_one
{
    class Program{
        public static void Main(string[] args)
        {

            Estimate stay = new Estimate();
            // Getting Dog Owner Name
            Console.Write("Please enter your name: ");
            stay.dog_owner = Console.ReadLine();

            // Getting Dog's Name
            Console.Write("Please enter the dog's name: ");
            stay.dog_name = Console.ReadLine();
            
            // Getting Dog's Weight
            Console.Write("Please enter your dog's weight: ");
            stay.dog_weight = Console.ReadLine();

            // Getting the Amount of Time the dog is staying
            Console.Write("Please enter the amount of day's your dog is staying: ");
            stay.dog_nights_input = Console.ReadLine();
            stay.dog_nights = Convert.ToInt32(stay.dog_nights_input);

            // Getting service add on code
            Console.WriteLine("Additional Services Cost: No Add-On Code N: $75.00 per night | Bathing and Grooming Code A: $169.00 per night | Bathing Only Code C: $112.00 per night");
            Console.Write("Please enter the desired code (N, A, C): ");
            stay.dog_code = Console.ReadLine();


            if (stay.dog_code == "N") {
                stay.total = 75.00 * stay.dog_nights;
                Console.WriteLine("Your total estimate is: ${0}", stay.total.ToString());
            }

            else if (stay.dog_code == "A") {
                stay.total = 169.00 * stay.dog_nights;
                Console.WriteLine("You total estimate is: ${0}", stay.total.ToString());
            }

            else if (stay.dog_code == "C") {
                stay.total = 112.00 * stay.dog_nights;
                Console.WriteLine("You total estimate is: ${0}.00", stay.total.ToString());
            }

            else if (stay.dog_code != "C" || stay.dog_code != "A" || stay.dog_code != "N") {
                Console.WriteLine("Please enter one of the three codes above!");
            }
            
        }
    }

    class Estimate{

        public string dog_owner {get; set;}

        public string dog_name {get; set;}

        public string dog_weight {get; set;}

        public string dog_nights_input {get; set;}

        public int dog_nights {get; set;}

        public string dog_code {get; set;}

        public double total {get; set;} 
    }
}
