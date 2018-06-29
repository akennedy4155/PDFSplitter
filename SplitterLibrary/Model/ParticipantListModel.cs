using System;
using System.Collections.Generic;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace SplitterLibrary
{
    public class ParticipantListModel
    {
        /// <summary>
        /// List of participants in the form of a list of strings.
        /// Populate the list from a text file.
        /// </summary>
        public List<String> ParticipantList { get; set; } = new List<String>();

        public ParticipantListModel(String filepath)
        {
            ParticipantList = new List<String>(System.IO.File.ReadAllLines(filepath));
        }
    }
}
