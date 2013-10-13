using DogSledSim.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Data
{
    public class DogSimContext : DbContext
    {
        public virtual IDbSet<DogSled> DogSleds { get; set; }

        static DogSimContext()
        {
            Database.SetInitializer(new DogSimContextInitializer());
        }

        public DogSimContext()
            : base(ConfigurationManager.ConnectionStrings["DogSimContext"].ConnectionString)
        {
        }
    }
}
