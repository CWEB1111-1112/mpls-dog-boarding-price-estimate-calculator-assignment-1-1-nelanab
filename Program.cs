using System;

namespace assignment_one
{
    class Estimate{
        public static void Main(string[] args)
        {
            // Getting Dog Owner Name
            string dog_owner;
            Console.Write("Please enter your name: ");
            dog_owner = Console.ReadLine();

            // Getting Dog's Name
            string dog_name;
            Console.Write("Please enter the dog's name: ");
            dog_name = Console.ReadLine();
            
            // Getting Dog's Weight
            string dog_weight;
            Console.Write("Please enter your dog's weight: ");
            dog_weight = Console.ReadLine();

            // Getting the Amount of Time the dog is staying
            string dog_nights_input;
            int dog_nights;
            Console.Write("Please enter the amount of day's your dog is staying: ");
            dog_nights_input = Console.ReadLine();
            dog_nights = Convert.ToInt32(dog_nights_input);

            // Getting service add on code
            string dog_code;
            Console.WriteLine("Additional Services Cost: No Add-On Code N: $75.00 per night | Bathing and Grooming Code A: $169.00 per night | Bathing Only Code C: $112.00 per night");
            Console.Write("Please enter the desired code (N, A, C): ");
            dog_code = Console.ReadLine();

            // Declaring total object
            double total;

            if (dog_code == "N") {
                total = 75.00 * dog_nights;
                Console.WriteLine("Your total estimate is: ${0}", total.ToString());
            }

            else if (dog_code == "A") {
                total = 169.00 * dog_nights;
                Console.WriteLine("You total estimate is: ${0}", total.ToString());
            }

            else if (dog_code == "C") {
                total = 112.00 * dog_nights;
                Console.WriteLine("You total estimate is: ${0}.00", total.ToString());
            }

            else if (dog_code != "C" || dog_code != "A" || dog_code != "N") {
                Console.WriteLine("Please enter one of the three codes above!");
            }
        }
    }
}
