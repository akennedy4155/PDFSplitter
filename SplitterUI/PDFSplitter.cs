using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SplitterLibrary;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;

namespace SplitterUI
{

    public partial class PDFSplitter : Form
    {
        PdfDocument currentPage;
        PdfDocument fullPDF = PdfReader.Open(GlobalConfig.inputPath, PdfDocumentOpenMode.Import);
        ParticipantListModel participantList = new ParticipantListModel(System.IO.Directory.GetCurrentDirectory() + "\\plist.txt");
        Bridge bridge = new Bridge();
        int currentPageNum = 0;
        Mode currentMode = Mode.Start;

        public PDFSplitter()
        {
            InitializeComponent();
            UpdateViewer();
            participantListBox.DataSource = participantList.ParticipantList;
            ChangeMode(currentMode);
        }

        private void actionButton_click(object sender, EventArgs e)
        {
            currentPageNum++;
            //ROUTE PROCESSING, only one route to one controller

            //SPEAK TO THE CONTROLLER, NEVER ACCESS THE DATABASE
            //currentPage++;
            // Validate fields
            if (FormValidated())
            {
                String type;
                if (groupNoteButton.Checked)
                {
                    type = "Group Note";
                } else if(checkInButton.Checked)
                {
                    type = "Check In";
                } else
                {
                    type = "Shift Log";
                    if (AMButton.Checked)
                    {
                        type += "AM";
                    } else
                    {
                        type += "PM";
                    }
                }
                PDFModel pdfm = new PDFModel(
                    participantListBox.GetItemText(participantListBox.SelectedItem),
                    type,
                    dateSelectCalendar.SelectionStart,
                    currentPage
                    );

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePDF(pdfm);
                }

                //update the viewer and the current pdf
                if ((currentPageNum + 1) > fullPDF.Pages.Count)
                {
                    Application.Exit();
                }
                else
                {
                    UpdateViewer();
                }
            } else
            {
                MessageBox.Show("Invalid Form. Check one of the radio buttons for form type.");
            }
            
        }

        enum Mode { Split, Check, Start };

        /// <summary>
        /// Put form into start mode
        /// </summary>
        /// <param name="enabled"></param>
        void ChangeMode (Mode mode)
        {
            //first disable all controls
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            //then enter switch statement that allows the proper controls to show up for that mode
            switch (mode)
            {
                case Mode.Split:
                    break;
                case Mode.Check:
                    break;
                case Mode.Start:
                    break;
            }

        }

        /// <summary>
        /// Put the form into split mode, the main mode of the application.
        /// </summary>
        /// <param name="enabled"></param>
        void EnableSplitMode(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
            }


        }

        /// <summary>
        /// Put the form into check mode
        /// </summary>
        /// <param name="enabled"></param>
        void EnableCheckMode(bool enabled)
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = enabled;
            }

            
        }

        /// <summary>
        /// Update the viewer with the current PDF page
        /// </summary>
        private void UpdateViewer()
        {
            currentPage = new PdfDocument();
            currentPage.AddPage(fullPDF.Pages[currentPageNum]);
            currentPage.Save(GlobalConfig.outputPath + "\\current.pdf");
            pdfViewer.src = GlobalConfig.outputPath + "\\current.pdf";  
        }

        /// <summary>
        /// Validate the main PDFSplitter form.
        /// </summary>
        /// <returns>Returns True if validated</returns>
        private bool FormValidated()
        {
            if (!(groupNoteButton.Checked || checkInButton.Checked || shiftLogButton.Checked))
            {
                return false;
            }
            if (shiftLogButton.Checked)
            {
                if(!(AMButton.Checked || PMButton.Checked))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Delete the temp pdf when the form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PDFSplitter_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(GlobalConfig.outputPath + "\\current.pdf");
        }

        /// <summary>
        /// Get the state of the buttons and pack into a dictionary
        /// </summary>
        /// <returns>Dictionary with bool values for the state of buttons</returns>
        private Dictionary<String, bool> PackageViewInfo()
        {
            Dictionary<String, bool> returnDict = new Dictionary<String, bool>();
            returnDict.Add("Group Note", groupNoteButton.Checked);
            returnDict.Add("Check In", checkInButton.Checked);
            returnDict.Add("Shift Log", shiftLogButton.Checked);
            returnDict.Add("AM", AMButton.Checked);
            returnDict.Add("PM", PMButton.Checked);
            return returnDict;
        }

        /// <summary>
        /// Combine all of the documents in the input folder that aren't named example into example.pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combineButton_Click(object sender, EventArgs e)
        {
            PdfDocument output = new PdfDocument();
            foreach(String path in Directory.GetFiles(GlobalConfig.inputPath))
            {
                //check if its not example

            }
        }

        private void pageRightButton_Click(object sender, EventArgs e)
        {

        }
    }
}
