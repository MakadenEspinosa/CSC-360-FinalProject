using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAdoption
{
    public class Dachshund : IDog
    {
        public string GetDescription()
        {
            return "The Dachshund is a small dog breed with a long body and short legs. They are known for their playful and curious nature, as well as their loyalty to their owners.";
        }
        public string GetName()
        {
            return "Dachshund";
        }
    }
}
