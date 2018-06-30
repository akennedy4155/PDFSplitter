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
            this.pdfViewer = new AxAcroPDFLib.AxAcroPDF();
            this.combineButton = new System.Windows.Forms.Button();
            this.checkModeCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.pageLeftButton = new System.Windows.Forms.Button();
            this.pageRightButton = new System.Windows.Forms.Button();
            this.panelTypeRadio = new System.Windows.Forms.Panel();
            this.timePanel = new System.Windows.Forms.Panel();
            this.PMButton = new System.Windows.Forms.RadioButton();
            this.AMButton = new System.Windows.Forms.RadioButton();
            this.shiftLogButton = new System.Windows.Forms.RadioButton();
            this.groupNoteButton = new System.Windows.Forms.RadioButton();
            this.checkInButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.participantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantListModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).BeginInit();
            this.panelTypeRadio.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // participantListBox
            // 
            this.participantListBox.DataSource = this.participantListBindingSource;
            this.participantListBox.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participantListBox.FormattingEnabled = true;
            this.participantListBox.ItemHeight = 17;
            this.participantListBox.Location = new System.Drawing.Point(526, 22);
            this.participantListBox.Margin = new System.Windows.Forms.Padding(1);
            this.participantListBox.Name = "participantListBox";
            this.participantListBox.Size = new System.Drawing.Size(306, 633);
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
            this.actionButton.Location = new System.Drawing.Point(978, 522);
            this.actionButton.Margin = new System.Windows.Forms.Padding(1);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(140, 50);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "Split";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_click);
            // 
            // dateSelectCalendar
            // 
            this.dateSelectCalendar.Location = new System.Drawing.Point(853, 256);
            this.dateSelectCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.dateSelectCalendar.MaxSelectionCount = 1;
            this.dateSelectCalendar.Name = "dateSelectCalendar";
            this.dateSelectCalendar.TabIndex = 5;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Enabled = true;
            this.pdfViewer.Location = new System.Drawing.Point(23, 22);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(1);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfViewer.OcxState")));
            this.pdfViewer.Size = new System.Drawing.Size(486, 633);
            this.pdfViewer.TabIndex = 8;
            // 
            // combineButton
            // 
            this.combineButton.Location = new System.Drawing.Point(836, 522);
            this.combineButton.Margin = new System.Windows.Forms.Padding(1);
            this.combineButton.Name = "combineButton";
            this.combineButton.Size = new System.Drawing.Size(140, 50);
            this.combineButton.TabIndex = 11;
            this.combineButton.Text = "Combine";
            this.combineButton.UseVisualStyleBackColor = true;
            // 
            // checkModeCheckBox
            // 
            this.checkModeCheckBox.AutoSize = true;
            this.checkModeCheckBox.Location = new System.Drawing.Point(964, 587);
            this.checkModeCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.checkModeCheckBox.Name = "checkModeCheckBox";
            this.checkModeCheckBox.Size = new System.Drawing.Size(165, 34);
            this.checkModeCheckBox.TabIndex = 12;
            this.checkModeCheckBox.Text = "Check Mode?";
            this.checkModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(836, 592);
            this.startButton.Margin = new System.Windows.Forms.Padding(1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 42);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // pageLeftButton
            // 
            this.pageLeftButton.Location = new System.Drawing.Point(880, 468);
            this.pageLeftButton.Margin = new System.Windows.Forms.Padding(1);
            this.pageLeftButton.Name = "pageLeftButton";
            this.pageLeftButton.Size = new System.Drawing.Size(95, 42);
            this.pageLeftButton.TabIndex = 14;
            this.pageLeftButton.Text = "<";
            this.pageLeftButton.UseVisualStyleBackColor = true;
            // 
            // pageRightButton
            // 
            this.pageRightButton.Location = new System.Drawing.Point(978, 468);
            this.pageRightButton.Margin = new System.Windows.Forms.Padding(1);
            this.pageRightButton.Name = "pageRightButton";
            this.pageRightButton.Size = new System.Drawing.Size(96, 42);
            this.pageRightButton.TabIndex = 15;
            this.pageRightButton.Text = ">";
            this.pageRightButton.UseVisualStyleBackColor = true;
            // 
            // panelTypeRadio
            // 
            this.panelTypeRadio.Controls.Add(this.timePanel);
            this.panelTypeRadio.Controls.Add(this.shiftLogButton);
            this.panelTypeRadio.Controls.Add(this.groupNoteButton);
            this.panelTypeRadio.Controls.Add(this.checkInButton);
            this.panelTypeRadio.Location = new System.Drawing.Point(853, 22);
            this.panelTypeRadio.Name = "panelTypeRadio";
            this.panelTypeRadio.Size = new System.Drawing.Size(227, 212);
            this.panelTypeRadio.TabIndex = 16;
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.PMButton);
            this.timePanel.Controls.Add(this.AMButton);
            this.timePanel.Location = new System.Drawing.Point(0, 114);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(200, 98);
            this.timePanel.TabIndex = 4;
            this.timePanel.EnabledChanged += new System.EventHandler(this.TimePanelEnabledChanged);
            // 
            // PMButton
            // 
            this.PMButton.AutoSize = true;
            this.PMButton.Location = new System.Drawing.Point(27, 43);
            this.PMButton.Name = "PMButton";
            this.PMButton.Size = new System.Drawing.Size(63, 34);
            this.PMButton.TabIndex = 1;
            this.PMButton.TabStop = true;
            this.PMButton.Text = "PM";
            this.PMButton.UseVisualStyleBackColor = true;
            this.PMButton.CheckedChanged += new System.EventHandler(this.TimePanelButtonCheckChanged);
            // 
            // AMButton
            // 
            this.AMButton.AutoSize = true;
            this.AMButton.Location = new System.Drawing.Point(27, 3);
            this.AMButton.Name = "AMButton";
            this.AMButton.Size = new System.Drawing.Size(65, 34);
            this.AMButton.TabIndex = 0;
            this.AMButton.TabStop = true;
            this.AMButton.Text = "AM";
            this.AMButton.UseVisualStyleBackColor = true;
            this.AMButton.CheckedChanged += new System.EventHandler(this.TimePanelButtonCheckChanged);
            // 
            // shiftLogButton
            // 
            this.shiftLogButton.AutoSize = true;
            this.shiftLogButton.Location = new System.Drawing.Point(0, 83);
            this.shiftLogButton.Name = "shiftLogButton";
            this.shiftLogButton.Size = new System.Drawing.Size(116, 34);
            this.shiftLogButton.TabIndex = 3;
            this.shiftLogButton.TabStop = true;
            this.shiftLogButton.Text = "Shift Log";
            this.shiftLogButton.UseVisualStyleBackColor = true;
            this.shiftLogButton.CheckedChanged += new System.EventHandler(this.MainPanelButtonsChanged);
            // 
            // groupNoteButton
            // 
            this.groupNoteButton.AutoSize = true;
            this.groupNoteButton.Location = new System.Drawing.Point(0, 43);
            this.groupNoteButton.Name = "groupNoteButton";
            this.groupNoteButton.Size = new System.Drawing.Size(146, 34);
            this.groupNoteButton.TabIndex = 2;
            this.groupNoteButton.TabStop = true;
            this.groupNoteButton.Text = "Group Note";
            this.groupNoteButton.UseVisualStyleBackColor = true;
            this.groupNoteButton.CheckedChanged += new System.EventHandler(this.MainPanelButtonsChanged);
            // 
            // checkInButton
            // 
            this.checkInButton.AutoSize = true;
            this.checkInButton.Location = new System.Drawing.Point(3, 3);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(114, 34);
            this.checkInButton.TabIndex = 1;
            this.checkInButton.TabStop = true;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.CheckedChanged += new System.EventHandler(this.MainPanelButtonsChanged);
            // 
            // PDFSplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 671);
            this.Controls.Add(this.panelTypeRadio);
            this.Controls.Add(this.pageRightButton);
            this.Controls.Add(this.pageLeftButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.checkModeCheckBox);
            this.Controls.Add(this.combineButton);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.dateSelectCalendar);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.participantListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PDFSplitter";
            this.Text = "PDF Splitter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PDFSplitter_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.participantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantListModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdfViewer)).EndInit();
            this.panelTypeRadio.ResumeLayout(false);
            this.panelTypeRadio.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox participantListBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.MonthCalendar dateSelectCalendar;
        private System.Windows.Forms.BindingSource participantListBindingSource;
        private System.Windows.Forms.BindingSource participantListModelBindingSource;
        private AxAcroPDFLib.AxAcroPDF pdfViewer;
        private System.Windows.Forms.Button combineButton;
        private System.Windows.Forms.CheckBox checkModeCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button pageLeftButton;
        private System.Windows.Forms.Button pageRightButton;
        private System.Windows.Forms.Panel panelTypeRadio;
        private System.Windows.Forms.RadioButton shiftLogButton;
        private System.Windows.Forms.RadioButton groupNoteButton;
        private System.Windows.Forms.RadioButton checkInButton;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.RadioButton PMButton;
        private System.Windows.Forms.RadioButton AMButton;
    }
}

