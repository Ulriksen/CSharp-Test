using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class DogSled
    {
        public int Id { get; set; }

        private ICollection<Dog> _dgs;
        public virtual ICollection<Dog> Dgs
        {
            get { return _dgs ?? (_dgs = new HashSet<Dog>()); }
            set { _dgs = value; }
        }

        public DogSled()
        { 
        }

        /// <summary>
        /// Creates a dogsled and initialize the dog team
        /// </summary>
        /// <param name="a"></param>
        public DogSled(HashSet<Dog> a)
        {
            _dgs = a;
        }

        /// <summary>
        /// Adds a new pair of dogs to the list
        /// </summary>
        /// <param name="pair"></param>
        public void AddPair(DogPair pair)
        {
            var l = new List<Dog>(Dgs);
            l.AddRange(pair.Dogs);
            Dgs = new HashSet<Dog>(l);
        }

        /// <summary>
        /// Start the sled, tell all the dogs in the dog team to start running.
        /// </summary>
        public void Start()
        {
            foreach (SledDog d in Dgs)
            {
                d.Run();
            }
        }
    }
}
