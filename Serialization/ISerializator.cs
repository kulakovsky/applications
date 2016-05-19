using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.ClassMakeup;
using System.IO;

namespace Serialization
{
    interface ISerializator
    {
        void Serialize(List<MakeupClass> makeupList, FileStream file);
        List<MakeupClass> Deserialize(FileStream file);
    }
}
