using System;
using System.Collections.Generic;
using System.Text;

namespace SplitterLibrary
{
    public class PDFConnection : IDataConnection
    {
        /// <summary>
        /// Saves a new PDF to the file system
        /// </summary>
        /// <param name="model">The PDF object</param>
        /// <returns>Successful? True or False</returns>
        public bool CreatePDF(PDFModel model)
        {
            //TODO - Save the PDF to the file system
            model.writePDF();
            return true; 
        }
    }
}
