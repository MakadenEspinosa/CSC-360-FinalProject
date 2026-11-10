namespace DogAdoption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a dog factory for Dachshund
            DogFactory dachshundFactory = new DachshundFactory();
            IDog dachshund = dachshundFactory.CreateDog();
            Console.WriteLine($"Dog Name: {dachshund.GetName()}");
            Console.WriteLine($"Description: {dachshund.GetDescription()}");
            // Create a dog factory for Yorkshire Terrier
            DogFactory yorkieFactory = new YorkieFactory();
            IDog yorkie = yorkieFactory.CreateDog();
            Console.WriteLine($"Dog Name: {yorkie.GetName()}");
            Console.WriteLine($"Description: {yorkie.GetDescription()}");
        }
    }
}
