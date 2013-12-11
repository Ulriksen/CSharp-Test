using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class Poodle : Dog
    {
        public override void Run()
        {
            Trace.TraceInformation("Poodle starting");
        }

        public override void Stop()
        {
            Trace.TraceInformation("Poodle stopping");
        }
    }
}
