using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Services
{
    public class SuperUsefullWebServiceWrapper
    {
        public int GoGetSomethingOnTheWeb()
        {
            return new Random( DateTime.UtcNow.Millisecond ).Next();
        }
    }
}
