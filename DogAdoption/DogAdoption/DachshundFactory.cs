using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAdoption
{
    public class DachshundFactory : DogFactory
    {
        public override IDog CreateDog()
        {
            return new Dachshund();
        }
    }
}
