using System;
using System.IO;

namespace D_D_Character_Creator.Data.Common
{
    public interface IOGLElement<T>: IXML
    {
        bool ShowSource { get; set; }
        T Clone();
        string FileName { get; set; }
        void Write(Stream stream);
    }

    public interface IOGLElement : IXML
    {
        bool ShowSource { get; set; }
    }
}
