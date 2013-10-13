using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class DogSled
    {
        List<IDog> Dgs;
        public DogSled(List<IDog> a)
        {
            Dgs = a;
        }

        public void Start()
        {
            foreach (ISledDog d in Dgs)
            {
                d.Run();
            }
        }
    }
}
