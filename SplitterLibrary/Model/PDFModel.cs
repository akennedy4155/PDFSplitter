using System;
using System.Collections.Generic;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace SplitterLibrary
{
    public class PDFModel
    {
        public String filename { get; set; }
        public String type { get; set; }
        public String date { get; set; }
        public String name { get; set; }

        public PdfDocument file { get; set; }

        public PDFModel(String name, String type, DateTime dateTime, PdfDocument fileinput)
        {
            this.name = name;
            this.type = type;
            this.date = dateTime.Month + "-" + dateTime.Day + "-" + dateTime.Year;
            if (type.Contains("Shift"))
            {
                filename = type + " " + date;
            }
            else
            {
                filename = name + " " + type + " " + date;
            }
            file = fileinput;
        }

        //TODO - organize code better, take some stuff out of the UI
        //TODO - clean up the interface
        //TODO - make standalone application
        //TODO - make page numbers
        //TODO - make starting screen with file selection section
        //TODO - combine section
        //TODO - Check section


        public void writePDF()
        {
            int num = 2;
            bool duplcate = false;
            //check for duplicate and rename if needed
            if (System.IO.File.Exists(GlobalConfig.outputPath + "\\" + filename + ".pdf"))
            {
                while(System.IO.File.Exists(GlobalConfig.outputPath+"\\"+filename + " " + num + ".pdf"))
                {
                    num++;
                }
                file.Save(GlobalConfig.outputPath + "\\" + filename + " " + num + ".pdf");
            } else
            {
                file.Save(GlobalConfig.outputPath + "\\" + filename + ".pdf");
            }

            
        }
    }
}
