namespace DogAdoption
{
    public class DetailedDogDisplayStrategy : IDogDisplayStrategy
    {
        public void Display(IDog dog)
        {
            Console.WriteLine($"Dog Name: {dog.GetName()}");
            Console.WriteLine($"Description: {dog.GetDescription()}");
        }
    }
}
