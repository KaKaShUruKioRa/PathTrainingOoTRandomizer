using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathTrainingOoTRandomizer.States
{
    public class States
    {
        public Stack<States> states;   

        public States() {
            
        this.states = new Stack<States>();
        }
    }
}
