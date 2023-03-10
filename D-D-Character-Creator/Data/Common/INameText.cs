using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D_Character_Creator.Data.Common
{
    public interface IInfoText
    {
        string InfoTitle { get; }
        string InfoText { get; }
        string ToInfo(bool includeDescription = false);
    }
}
