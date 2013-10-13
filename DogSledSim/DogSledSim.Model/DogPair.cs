using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class DogPair : Tuple<IDog, IDog>
    {
        public DogPair(IDog l, IDog r) : base(l, r)
        {
        }

        public IEnumerable<IDog> Dogs { get { return new[] { Item1, Item2 }; } } 
    }
}
