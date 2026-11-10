using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAdoption
{
    public abstract class DogFactory
    {
        public abstract IDog CreateDog();
    }
}
