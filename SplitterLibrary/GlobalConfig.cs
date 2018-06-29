using System;
using System.Collections.Generic;
using System.Text;

namespace SplitterLibrary
{
    /// <summary>
    /// used to store global data that every thing can use
    /// </summary>
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static String inputPath = "C:\\Users\\akenn\\Desktop\\Redpoint\\Scans\\PDF\\input\\example.pdf";
        public static String outputPath = "C:\\Users\\akenn\\Desktop\\Redpoint\\Scans\\PDF\\Not Uploaded";

        public static void InitializeConnections(bool pdfFiles)
        {
            if (pdfFiles)
            {
                //TODO - set up the pdf connector properly
                PDFConnection pdf = new PDFConnection();
                Connections.Add(pdf);
            }

            //other data connections could come down here in the future, for now we just want the connection
            //to the pdf file that is going out
        }
    }
}
