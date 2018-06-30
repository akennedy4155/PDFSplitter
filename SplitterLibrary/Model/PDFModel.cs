using System;
using PdfSharp.Pdf;

namespace SplitterLibrary
{
    public class PDFModel
    {
        //TODO - eventually going to add a time on here too for morning, evening night etc. and add ability to custom name files that don't fall under the category of the three file types supported.
        public String filename;
        public String type;
        public String date;
        public String name;

        public PdfDocument file;

        /// <summary>
        /// Constructor for the PDF file that has all properties of the file that are required to save to a file and name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">Type of the file that will be saved such as Group Note, Check in, Shift Log, etc.</param>
        /// <param name="dateTime">Date that the scan was written</param>
        /// <param name="fileinput">PDF File as a PDFDocument</param>
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
    }
}
