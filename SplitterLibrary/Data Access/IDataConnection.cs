using System;
using System.Collections.Generic;
using System.Text;

namespace SplitterLibrary
{
    /// <summary>
    /// contract to specify what methods properties and other items
    /// </summary>
    public interface IDataConnection
    {
        bool WritePDF(PDFModel model);
    }
}
