namespace DogAdoption
{
    public class BriefDogDisplayStrategy : IDogDisplayStrategy
    {
        public void Display(IDog dog)
        {
            Console.WriteLine($"Dog Name: {dog.GetName()}");
        }
    }
}
