using System;
using System.Collections.Generic;
using System.Text;

namespace SplitterLibrary
{
    public class PDFConnection : IDataConnection
    {
        private String outputPath;

        /// <summary>
        /// Constructor for the PDFConnection that sets the output path of the Connection
        /// </summary>
        /// <param name="path">Output path for the connection</param>
        public PDFConnection(String path)
        {
            outputPath = path;
        }

        /// <summary>
        /// Saves a new PDF to the file system
        /// </summary>
        /// <param name="model">The PDF object</param>
        /// <returns>Successful? True or False</returns>
        public bool WritePDF(PDFModel pdfm)
        {
            int num = 2;
            //check for duplicate and rename if needed
            if (System.IO.File.Exists(outputPath + "\\" + pdfm.filename + ".pdf"))
            {
                while (System.IO.File.Exists(outputPath + "\\" + pdfm.filename + " " + num + ".pdf"))
                {
                    num++;
                }
                pdfm.file.Save(outputPath + "\\" + pdfm.filename + " " + num + ".pdf");
            }
            else
            {
                pdfm.file.Save(outputPath + "\\" + pdfm.filename + ".pdf");
            }
            return true;
        }
    }
}
