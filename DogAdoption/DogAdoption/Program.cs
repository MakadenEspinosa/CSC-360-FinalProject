namespace DogAdoption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose how to display dogs:");
            Console.WriteLine("1. Brief (name only)");
            Console.WriteLine("2. Detailed (name and description)");

            IDogDisplayStrategy strategy;
            while (true)
            {
                Console.Write("Enter 1 or 2: ");
                string? choice = Console.ReadLine();
                if (choice == null)
                {
                    Console.Error.WriteLine("No display choice was provided.");
                    Environment.ExitCode = 1;
                    return;
                }

                if (choice.Trim() == "1")
                {
                    strategy = new BriefDogDisplayStrategy();
                    break;
                }
                if (choice.Trim() == "2")
                {
                    strategy = new DetailedDogDisplayStrategy();
                    break;
                }

                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }

            DogDisplay display = new DogDisplay(strategy);

            // Create a dog factory for Dachshund
            DogFactory dachshundFactory = new DachshundFactory();
            IDog dachshund = dachshundFactory.CreateDog();
            display.Display(dachshund);
            // Create a dog factory for Yorkshire Terrier
            DogFactory yorkieFactory = new YorkieFactory();
            IDog yorkie = yorkieFactory.CreateDog();
            display.Display(yorkie);
        }
    }
}
