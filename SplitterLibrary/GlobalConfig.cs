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

        public static String inputPath = "D:\\Github\\PDFSplitter\\input\\firstshiftlognamebugtest063018.pdf";
        public static String tempPath = "D:\\Github\\PDFSplitter\\temp";
        public static ParticipantListModel participantList = new ParticipantListModel(System.IO.Directory.GetCurrentDirectory() + "\\plist.txt");

        public static List<String> ParticipantList { get; set; } = 
            new List<String>(System.IO.File.ReadAllLines("D:\\Github\\PDFSplitter\\plist.txt"));


        public static void InitializeConnections(bool pdfFiles)
        {
            if (pdfFiles)
            {
                //TODO - set up the pdf connector properly
                PDFConnection pdf = new PDFConnection("D:\\Github\\PDFSplitter\\Not Uploaded");
                Connections.Add(pdf);
            }

            //other data connections could come down here in the future, for now we just want the connection
            //to the pdf file that is going out
        }
    }
}
