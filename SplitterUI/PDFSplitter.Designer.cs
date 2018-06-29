namespace SplitterUI
{
    partial class PDFSplitter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFSplitter));
            this.participantListBox = new System.Windows.Forms.ListBox();
            this.participantListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantListModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionButton = new System.Windows.Forms.Button();
            this.dateSelectCalendar = new System.Windows.Forms.MonthCalendar();
            this.checkInButton = new System.Windows.Forms.RadioButton();
            this.groupNoteButton = new System.Windows.Forms.RadioButton();
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.shiftLogButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PMButton = new System.Windows.Forms.RadioButton();
            this.AMButton = new System.Windows.Forms.RadioButton();
            this.combineButton = new System.Windows.Forms.Button();
            this.checkModeCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.pageLeftButton = new System.Windows.Forms.Button();
            this.pageRightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.participantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // participantListBox
            // 
            this.participantListBox.DataSource = this.participantListBindingSource;
            this.participantListBox.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantListBox.FormattingEnabled = true;
            this.participantListBox.ItemHeight = 41;
            this.participantListBox.Location = new System.Drawing.Point(1184, 49);
            this.participantListBox.Name = "participantListBox";
            this.participantListBox.Size = new System.Drawing.Size(684, 1439);
            this.participantListBox.TabIndex = 1;
            // 
            // participantListBindingSource
            // 
            this.participantListBindingSource.DataMember = "ParticipantList";
            this.participantListBindingSource.DataSource = this.participantListModelBindingSource;
            // 
            // participantListModelBindingSource
            // 
            this.participantListModelBindingSource.DataSource = typeof(SplitterLibrary.ParticipantListModel);
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(2201, 1175);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(315, 112);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "Split";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_click);
            // 
            // dateSelectCalendar
            // 
            this.dateSelectCalendar.Location = new System.Drawing.Point(1920, 577);
            this.dateSelectCalendar.Margin = new System.Windows.Forms.Padding(8);
            this.dateSelectCalendar.MaxSelectionCount = 1;
            this.dateSelectCalendar.Name = "dateSelectCalendar";
            this.dateSelectCalendar.TabIndex = 5;
            // 
            // checkInButton
            // 
            this.checkInButton.AutoSize = true;
            this.checkInButton.Location = new System.Drawing.Point(2019, 90);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(240, 69);
            this.checkInButton.TabIndex = 6;
            this.checkInButton.TabStop = true;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            // 
            // groupNoteButton
            // 
            this.groupNoteButton.AutoSize = true;
            this.groupNoteButton.Location = new System.Drawing.Point(2019, 180);
            this.groupNoteButton.Name = "groupNoteButton";
            this.groupNoteButton.Size = new System.Drawing.Size(310, 69);
            this.groupNoteButton.TabIndex = 7;
            this.groupNoteButton.TabStop = true;
            this.groupNoteButton.Text = "Group Note";
            this.groupNoteButton.UseVisualStyleBackColor = true;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(53, 49);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(1099, 1445);
            this.pdfViewer.TabIndex = 8;
            // 
            // shiftLogButton
            // 
            this.shiftLogButton.AutoSize = true;
            this.shiftLogButton.Location = new System.Drawing.Point(2019, 275);
            this.shiftLogButton.Name = "shiftLogButton";
            this.shiftLogButton.Size = new System.Drawing.Size(247, 69);
            this.shiftLogButton.TabIndex = 9;
            this.shiftLogButton.TabStop = true;
            this.shiftLogButton.Text = "Shift Log";
            this.shiftLogButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PMButton);
            this.groupBox1.Controls.Add(this.AMButton);
            this.groupBox1.Location = new System.Drawing.Point(2019, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // PMButton
            // 
            this.PMButton.AutoSize = true;
            this.PMButton.Location = new System.Drawing.Point(6, 135);
            this.PMButton.Name = "PMButton";
            this.PMButton.Size = new System.Drawing.Size(129, 69);
            this.PMButton.TabIndex = 1;
            this.PMButton.TabStop = true;
            this.PMButton.Text = "PM";
            this.PMButton.UseVisualStyleBackColor = true;
            // 
            // AMButton
            // 
            this.AMButton.AutoSize = true;
            this.AMButton.Location = new System.Drawing.Point(6, 49);
            this.AMButton.Name = "AMButton";
            this.AMButton.Size = new System.Drawing.Size(133, 69);
            this.AMButton.TabIndex = 0;
            this.AMButton.TabStop = true;
            this.AMButton.Text = "AM";
            this.AMButton.UseVisualStyleBackColor = true;
            // 
            // combineButton
            // 
            this.combineButton.Location = new System.Drawing.Point(1881, 1175);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(315, 112);
            this.combineButton.TabIndex = 11;
            this.combineButton.Text = "Combine";
            this.combineButton.UseVisualStyleBackColor = true;
            this.combineButton.Click += new System.EventHandler(this.combineButton_Click);
            // 
            // checkModeCheckBox
            // 
            this.checkModeCheckBox.AutoSize = true;
            this.checkModeCheckBox.Location = new System.Drawing.Point(2168, 1321);
            this.checkModeCheckBox.Name = "checkModeCheckBox";
            this.checkModeCheckBox.Size = new System.Drawing.Size(347, 69);
            this.checkModeCheckBox.TabIndex = 12;
            this.checkModeCheckBox.Text = "Check Mode?";
            this.checkModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1881, 1331);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(273, 95);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // pageLeftButton
            // 
            this.pageLeftButton.Location = new System.Drawing.Point(1981, 1052);
            this.pageLeftButton.Name = "pageLeftButton";
            this.pageLeftButton.Size = new System.Drawing.Size(214, 95);
            this.pageLeftButton.TabIndex = 14;
            this.pageLeftButton.Text = "<";
            this.pageLeftButton.UseVisualStyleBackColor = true;
            // 
            // pageRightButton
            // 
            this.pageRightButton.Location = new System.Drawing.Point(2201, 1052);
            this.pageRightButton.Name = "pageRightButton";
            this.pageRightButton.Size = new System.Drawing.Size(217, 95);
            this.pageRightButton.TabIndex = 15;
            this.pageRightButton.Text = ">";
            this.pageRightButton.UseVisualStyleBackColor = true;
            this.pageRightButton.Click += new System.EventHandler(this.pageRightButton_Click);
            // 
            // PDFSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2527, 1514);
            this.Controls.Add(this.pageRightButton);
            this.Controls.Add(this.pageLeftButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.checkModeCheckBox);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.shiftLogButton);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.groupNoteButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.dateSelectCalendar);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.participantListBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "PDFSplitter";
            this.Text = "PDF Splitter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PDFSplitter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.participantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox participantListBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.MonthCalendar dateSelectCalendar;
        private System.Windows.Forms.BindingSource participantListBindingSource;
        private System.Windows.Forms.BindingSource participantListModelBindingSource;
        private System.Windows.Forms.RadioButton checkInButton;
        private System.Windows.Forms.RadioButton groupNoteButton;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.RadioButton shiftLogButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PMButton;
        private System.Windows.Forms.RadioButton AMButton;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.CheckBox checkModeCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pageLeftButton;
        private System.Windows.Forms.Button pageRightButton;
    }
}

