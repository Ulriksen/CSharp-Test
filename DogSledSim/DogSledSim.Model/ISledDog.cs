using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSledSim.Model
{
    public interface ISledDog : IDog
    {
        void KeepRunning();
    }
}
