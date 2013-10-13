using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class AlaskanHusky : SledDog
    {
        public override void Run()
        {
            Trace.TraceInformation("Siberian husky starting");
        }
       
        public override void Stop()
        {
            Trace.TraceInformation("Siberian husky stopping");
        }
    }
}
