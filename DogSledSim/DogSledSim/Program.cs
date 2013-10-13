using DogSledSim.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DogSimContext())
            {
                var sleds = db.DogSleds.ToList();
            }
        }
    }
}
