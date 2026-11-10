using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAdoption
{
    public class YorkshireTerrier : IDog
    {
        public string GetDescription()
        {
            return "The Yorkshire Terrier is a small dog breed known for its long, silky coat and feisty personality. They are intelligent, affectionate, and make great companions.";
        }
        public string GetName()
        {
            return "Yorkshire Terrier";
        }
    }
}
