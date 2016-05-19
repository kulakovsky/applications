using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.ClassMakeup;
using System.Windows.Forms;

namespace Serialization.GetValues
{
    class MakeupHandler
    {
        public virtual void SetValue(MakeupClass makeup, TextBox tbProducer, TextBox tbColor, TextBox tbPrice)
        {
            //this.tbName.Text = makeup.Name;
            tbProducer.Text = makeup.Producer;
            tbColor.Text = makeup.Color;
            tbPrice.Text = Convert.ToString(makeup.Price);
        }  

    }
}
