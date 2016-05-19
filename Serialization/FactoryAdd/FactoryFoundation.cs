using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.ClassMakeup;

namespace Serialization.FactoryAdd
{
    class FactoryFoundation : FactoryMakeup
    {
        public override MakeupClass FactoryAdd()
        {
            return new FoundationClass();
        }
    }
}
