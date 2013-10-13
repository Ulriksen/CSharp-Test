using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class Poodle : IDog
    {
        public void Run()
        {
            Trace.TraceInformation("Poodle starting");
        }

        public void Stop()
        {
            Trace.TraceInformation("Poodle stopping");
        }

        public virtual void Bark()
        {
            Trace.TraceInformation("Woof");
        }
    }
}
