using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.ClassMakeup;
using Serialization.FactoryAdd;

namespace LipPencil
{
    class FactoryLipPencil : FactoryMakeup
    {
        public override MakeupClass FactoryAdd()
        {
            return new LipPencilClass();
        }
    }
}
