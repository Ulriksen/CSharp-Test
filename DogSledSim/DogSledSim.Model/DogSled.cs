using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class DogSled
    {
        IEnumerable<IDog> Dgs;

        /// <summary>
        /// Creates a dogsled and initialize the dog team
        /// </summary>
        /// <param name="a"></param>
        public DogSled(List<ISledDog> a)
        {
            Dgs = a;
        }

        /// <summary>
        /// Adds a new pair of dogs to the list
        /// </summary>
        /// <param name="pair"></param>
        public void AddPair(DogPair pair)
        {
            var l = new List<IDog>(Dgs);
            l.AddRange(pair.Dogs);
            Dgs = new List<IDog>(Dgs);
        }

        /// <summary>
        /// Start the sled, tell all the dogs in the dog team to start running.
        /// </summary>
        public void Start()
        {
            foreach (ISledDog d in Dgs)
            {
                d.Run();
            }
        }
    }
}
