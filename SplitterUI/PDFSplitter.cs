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
using SplitterLibrary.State.Splitter;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;

namespace SplitterUI
{

    public partial class PDFSplitter : Form
    {
        PdfDocument currentPage;
        PdfDocument fullPDF = PdfReader.Open(GlobalConfig.inputPath, PdfDocumentOpenMode.Import);
        
        int currentPageNum = 0;

        SplitterState state = new SplitterStart();

        String currentSelectedType = "";
        String currentSelectedTime = "";

        public PDFSplitter()
        {
            InitializeComponent();
            UpdateViewer();
            participantListBox.DataSource = GlobalConfig.participantList.ParticipantList;
            pdfViewer.src = GlobalConfig.tempPath + "\\current.pdf";
        }

        private void ActionButton_click(object sender, EventArgs e)
        {  
            currentPageNum++;

            // Validate fields
            if (FormValidated())
            {
                //write the pdf to the data connections
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.WritePDF(new PDFModel(
                                    participantListBox.GetItemText(participantListBox.SelectedItem),
                                    currentSelectedType + " " + currentSelectedTime,
                                    dateSelectCalendar.SelectionStart,
                                    currentPage
                                    )
                                );
                }

                //if reached the end of the document then exit
                //TODO - figure out what logic goes instead of just closing the document now that there's more states
                if ((currentPageNum + 1) > fullPDF.Pages.Count)
                    Application.Exit();
                else
                    UpdateViewer();
            }

            //if form validation fails
            else
                MessageBox.Show("Invalid Form. Check one of the radio buttons for form type.");
            
        }

        /// <summary>
        /// Update the viewer with the current PDF page
        /// </summary>
        private void UpdateViewer()
        {
            currentPage = new PdfDocument();
            currentPage.AddPage(fullPDF.Pages[currentPageNum]);
            currentPage.Save(GlobalConfig.tempPath + "\\current.pdf");
            pdfViewer.src = GlobalConfig.tempPath + "\\current.pdf";  
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
            File.Delete(GlobalConfig.tempPath + "\\current.pdf");
        }

        /// <summary>
        /// Set the current selected type when a change is made in the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPanelButtonsChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton rb)
            {
                currentSelectedType = rb.Text;
                if (rb.Text == "Check In" || rb.Text == "Group Note")
                    timePanel.Enabled = false;
                else
                    timePanel.Enabled = true;
            }
                
        }

        /// <summary>
        /// Set the current selected time when a change is made in the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimePanelButtonCheckChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                Console.WriteLine("logged");
                Console.WriteLine(rb.Text);
                currentSelectedTime = rb.Text;
            }
                
                
        }

        /// <summary>
        /// Makes changes to the appearance and checked status of the buttons belonging to the panel that was disabled that sent this event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimePanelEnabledChanged(object sender, EventArgs e)
        {
            if(sender is Panel p && !p.Enabled)
            {
                foreach (Control b in p.Controls)
                {
                    if (b is RadioButton rb)
                        rb.Checked = false;
                }
                currentSelectedTime = null;
            }
        }

    }
}
