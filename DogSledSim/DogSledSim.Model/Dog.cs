using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual void Run()
        {
            Trace.TraceInformation("Dog starting");
        }
        public virtual void Stop()
        {
            Trace.TraceInformation("Dog stopping");
        }
        public virtual void Bark()
        {
            Trace.TraceInformation("Woof");
        }
    }
}
