using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class SledDog : Dog
    {
        public virtual void KeepRunning()
        {
            Trace.TraceInformation("SledDog keeps running");
        }
    }
}
