using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;

namespace LipPencil
{
    class LipPencilPlugin : IPlugin
    {
        public void Include(Form1 form1)
        {
            form1.extraTypes.Add(typeof(LipPencilClass));
            form1.comboBox1.Items.Add("LipPencil");
            form1.factory.Add(new FactoryLipPencil());
            form1.setterLabels.Add(new LipPencilClass());
        }
    }
}
