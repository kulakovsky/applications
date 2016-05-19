using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.FactoryAdd;
using Serialization.ClassMakeup;

namespace Highliter
{
    class FactoryHighliter : FactoryMakeup
    {
        public override MakeupClass FactoryAdd()
        {
            return new HighliterClass();
        }
    }
}
