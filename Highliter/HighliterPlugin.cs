using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;

namespace Highliter
{
    class HighliterPlugin : IPlugin
    {
        public void Include(Form1 form1)
        {
            form1.extraTypes.Add(typeof(HighliterClass));
            form1.comboBox1.Items.Add("Highliter");
            form1.factory.Add(new FactoryHighliter());
            form1.setterLabels.Add(new HighliterClass());
        }
    }
}
