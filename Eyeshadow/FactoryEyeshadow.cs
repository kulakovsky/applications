using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using Serialization.ClassMakeup;
using Serialization.FactoryAdd;

namespace Eyeshadow
{
    class FactoryEyeshadow : FactoryMakeup
    {
        public override MakeupClass FactoryAdd()
        {
            return new EyeshadowClass();
        }
    }
}
