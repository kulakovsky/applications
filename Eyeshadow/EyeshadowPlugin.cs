using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using System.Windows.Forms;

namespace Eyeshadow
{
    class EyeshadowPlugin : IPlugin
    {
        public void Include(Form1 form1)
        {
            form1.extraTypes.Add(typeof(EyeshadowClass));
            form1.comboBox1.Items.Add("Eyeshadow");
            form1.factory.Add(new FactoryEyeshadow());
            form1.setterLabels.Add(new EyeshadowClass());
        }
    }
}
