using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator.Data.Common
{
    public interface IXML: IMatchable
    {
        String Name { get; }
        String Source { get; }
        String ToXML();
        MemoryStream ToXMLStream();
    }
}
