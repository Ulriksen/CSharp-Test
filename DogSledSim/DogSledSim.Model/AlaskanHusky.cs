using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class AlaskanHusky : ISledDog
    {
        public void Run()
        {
            Trace.TraceInformation("Siberian husky starting");
        }
        public void KeepRunning()
        {
        }
        public void Stop()
        {
            Trace.TraceInformation("Siberian husky stopping");
        }
        public virtual void Bark()
        {
            Trace.TraceInformation("Woof");
        }
    }
}
