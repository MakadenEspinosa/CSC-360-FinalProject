namespace DogAdoption
{
    public class DogDisplay
    {
        private readonly IDogDisplayStrategy strategy;

        public DogDisplay(IDogDisplayStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Display(IDog dog)
        {
            strategy.Display(dog);
        }
    }
}
