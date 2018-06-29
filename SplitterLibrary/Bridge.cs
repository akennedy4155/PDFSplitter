using System;
using System.Collections.Generic;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace SplitterLibrary
{
    public class Bridge
    {
        PdfDocument currentPage;
        PdfDocument fullPDF = PdfReader.Open(GlobalConfig.inputPath, PdfDocumentOpenMode.Import);
        ParticipantListModel participantList = new ParticipantListModel(System.IO.Directory.GetCurrentDirectory() + "\\plist.txt");

        int currentPageNum = 0;

        /// <summary>
        /// Bridge constructor that sets the current page to the first page of the document
        /// </summary>
        public Bridge()
        {
            currentPage = new PdfDocument();
            currentPage.AddPage(fullPDF.Pages[0]);
            currentPage.Save(GlobalConfig.outputPath + "\\current.pdf");
        }

        public void Split(Dictionary<String, bool> viewInfo)
        {
            String type;
            //sort and define the type of pdf that is being split off
            if(viewInfo["Group Note"])
            {
                type = "Group Note";
            } else if(viewInfo["Check In"])
            {
                type = "Check In";
            } else
            {
                type = "Shift Log";
                if (viewInfo["AM"])
                {
                    type += " AM";
                } else
                {
                    type += " PM";
                }
            }

            
        }
    }
}
