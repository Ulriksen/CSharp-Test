using DogSledSim.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Data
{
    public class DogSimContextInitializer : DropCreateDatabaseIfModelChanges<DogSimContext>
    {
        
        protected override void Seed(DogSimContext context)
        {
            var sled = new DogSled
            {
                Dgs = new List<Dog>
                {
                    new SiberianHusky {Name = "Sigge"},
                    new AlaskanHusky {Name = "Tafs"}
                }

            };
            context.DogSleds.Add(sled);

            context.SaveChanges();

        }
    }
}
