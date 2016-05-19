using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serialization.ClassMakeup;

namespace Serialization.GetValues
{
    class BlushHandler : MakeupHandler
    {
        public override void SetValue(MakeupClass makeup, TextBox tbProducer, TextBox tbColor, TextBox tbPrice)
        {
            base.SetValue(makeup, tbProducer, tbColor, tbPrice);
        }     
    }
}
