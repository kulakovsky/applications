using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Serialization.ClassMakeup;

namespace Serialization
{
    class Serializator 
    {
        private XmlSerializer xmlSerializer = null;


        public void Serialize(List<MakeupClass> makeupList, FileStream file)
        {
            xmlSerializer.Serialize(file, makeupList);
        }

        public List<MakeupClass> Deserialize(FileStream file)
        {
            return (List<MakeupClass>)xmlSerializer.Deserialize(file);
        }
    }
}
