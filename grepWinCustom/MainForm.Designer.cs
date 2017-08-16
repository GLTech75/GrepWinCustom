namespace grepWinCustom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiGetSearchFolder = new System.Windows.Forms.Button();
            this.uiTargetFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.uiSearchFor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uiLastHour = new System.Windows.Forms.CheckBox();
            this.uiJustNow = new System.Windows.Forms.CheckBox();
            this.uiLast4Hours = new System.Windows.Forms.CheckBox();
            this.uiToday = new System.Windows.Forms.CheckBox();
            this.uiEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiUseDateRange = new System.Windows.Forms.CheckBox();
            this.uiStartDate = new System.Windows.Forms.DateTimePicker();
            this.uiIncludeSubFolders = new System.Windows.Forms.CheckBox();
            this.uiSearchPattern = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uiResultsGrid = new System.Windows.Forms.ListView();
            this.uiStatus = new System.Windows.Forms.Label();
            this.uiSearch = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.uiSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGetSearchFolder
            // 
            this.uiGetSearchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGetSearchFolder.Location = new System.Drawing.Point(1083, 17);
            this.uiGetSearchFolder.Name = "uiGetSearchFolder";
            this.uiGetSearchFolder.Size = new System.Drawing.Size(33, 23);
            this.uiGetSearchFolder.TabIndex = 1;
            this.uiGetSearchFolder.Text = "...";
            this.uiGetSearchFolder.UseVisualStyleBackColor = true;
            // 
            // uiTargetFolder
            // 
            this.uiTargetFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTargetFolder.Location = new System.Drawing.Point(6, 19);
            this.uiTargetFolder.Name = "uiTargetFolder";
            this.uiTargetFolder.Size = new System.Drawing.Size(1071, 20);
            this.uiTargetFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uiGetSearchFolder);
            this.groupBox1.Controls.Add(this.uiTargetFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1122, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search in ...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.uiSearchFor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1122, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Search case-sensitive";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // uiSearchFor
            // 
            this.uiSearchFor.Location = new System.Drawing.Point(68, 45);
            this.uiSearchFor.Name = "uiSearchFor";
            this.uiSearchFor.Size = new System.Drawing.Size(1009, 20);
            this.uiSearchFor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search for";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Text search";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Regex search";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uiLastHour);
            this.groupBox3.Controls.Add(this.uiJustNow);
            this.groupBox3.Controls.Add(this.uiLast4Hours);
            this.groupBox3.Controls.Add(this.uiToday);
            this.groupBox3.Controls.Add(this.uiEndDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.uiUseDateRange);
            this.groupBox3.Controls.Add(this.uiStartDate);
            this.groupBox3.Controls.Add(this.uiIncludeSubFolders);
            this.groupBox3.Controls.Add(this.uiSearchPattern);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1122, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Limit search";
            // 
            // uiLastHour
            // 
            this.uiLastHour.AutoSize = true;
            this.uiLastHour.Location = new System.Drawing.Point(280, 22);
            this.uiLastHour.Name = "uiLastHour";
            this.uiLastHour.Size = new System.Drawing.Size(70, 17);
            this.uiLastHour.TabIndex = 7;
            this.uiLastHour.Text = "Last hour";
            this.uiLastHour.UseVisualStyleBackColor = true;
            this.uiLastHour.CheckedChanged += new System.EventHandler(this.uiLastHour_CheckedChanged);
            // 
            // uiJustNow
            // 
            this.uiJustNow.AutoSize = true;
            this.uiJustNow.Location = new System.Drawing.Point(356, 22);
            this.uiJustNow.Name = "uiJustNow";
            this.uiJustNow.Size = new System.Drawing.Size(68, 17);
            this.uiJustNow.TabIndex = 8;
            this.uiJustNow.Text = "Just now";
            this.uiJustNow.UseVisualStyleBackColor = true;
            this.uiJustNow.CheckedChanged += new System.EventHandler(this.uiJustNow_CheckedChanged);
            // 
            // uiLast4Hours
            // 
            this.uiLast4Hours.AutoSize = true;
            this.uiLast4Hours.Location = new System.Drawing.Point(190, 22);
            this.uiLast4Hours.Name = "uiLast4Hours";
            this.uiLast4Hours.Size = new System.Drawing.Size(84, 17);
            this.uiLast4Hours.TabIndex = 6;
            this.uiLast4Hours.Text = "Last 4 hours";
            this.uiLast4Hours.UseVisualStyleBackColor = true;
            this.uiLast4Hours.CheckedChanged += new System.EventHandler(this.uiLast4Hours_CheckedChanged);
            // 
            // uiToday
            // 
            this.uiToday.AutoSize = true;
            this.uiToday.Location = new System.Drawing.Point(128, 22);
            this.uiToday.Name = "uiToday";
            this.uiToday.Size = new System.Drawing.Size(56, 17);
            this.uiToday.TabIndex = 5;
            this.uiToday.Text = "Today";
            this.uiToday.UseVisualStyleBackColor = true;
            this.uiToday.CheckedChanged += new System.EventHandler(this.uiToday_CheckedChanged);
            // 
            // uiEndDate
            // 
            this.uiEndDate.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.uiEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.uiEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uiEndDate.Location = new System.Drawing.Point(192, 62);
            this.uiEndDate.Name = "uiEndDate";
            this.uiEndDate.ShowUpDown = true;
            this.uiEndDate.Size = new System.Drawing.Size(148, 20);
            this.uiEndDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "End date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start date:";
            // 
            // uiUseDateRange
            // 
            this.uiUseDateRange.AutoSize = true;
            this.uiUseDateRange.Location = new System.Drawing.Point(9, 22);
            this.uiUseDateRange.Name = "uiUseDateRange";
            this.uiUseDateRange.Size = new System.Drawing.Size(102, 17);
            this.uiUseDateRange.TabIndex = 0;
            this.uiUseDateRange.Text = "Use date range:";
            this.uiUseDateRange.UseVisualStyleBackColor = true;
            this.uiUseDateRange.CheckedChanged += new System.EventHandler(this.uiUseDateRange_CheckedChanged);
            // 
            // uiStartDate
            // 
            this.uiStartDate.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.uiStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.uiStartDate.Location = new System.Drawing.Point(9, 62);
            this.uiStartDate.Name = "uiStartDate";
            this.uiStartDate.ShowUpDown = true;
            this.uiStartDate.Size = new System.Drawing.Size(148, 20);
            this.uiStartDate.TabIndex = 2;
            // 
            // uiIncludeSubFolders
            // 
            this.uiIncludeSubFolders.AutoSize = true;
            this.uiIncludeSubFolders.Location = new System.Drawing.Point(684, 62);
            this.uiIncludeSubFolders.Name = "uiIncludeSubFolders";
            this.uiIncludeSubFolders.Size = new System.Drawing.Size(112, 17);
            this.uiIncludeSubFolders.TabIndex = 11;
            this.uiIncludeSubFolders.Text = "Include subfolders";
            this.uiIncludeSubFolders.UseVisualStyleBackColor = true;
            // 
            // uiSearchPattern
            // 
            this.uiSearchPattern.Location = new System.Drawing.Point(684, 22);
            this.uiSearchPattern.Name = "uiSearchPattern";
            this.uiSearchPattern.Size = new System.Drawing.Size(393, 20);
            this.uiSearchPattern.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File names match:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uiResultsGrid);
            this.groupBox4.Location = new System.Drawing.Point(12, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1122, 384);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Results";
            // 
            // uiResultsGrid
            // 
            this.uiResultsGrid.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.uiResultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiResultsGrid.FullRowSelect = true;
            this.uiResultsGrid.GridLines = true;
            this.uiResultsGrid.HideSelection = false;
            this.uiResultsGrid.HotTracking = true;
            this.uiResultsGrid.HoverSelection = true;
            this.uiResultsGrid.Location = new System.Drawing.Point(6, 19);
            this.uiResultsGrid.Name = "uiResultsGrid";
            this.uiResultsGrid.Size = new System.Drawing.Size(1110, 359);
            this.uiResultsGrid.TabIndex = 0;
            this.uiResultsGrid.UseCompatibleStateImageBehavior = false;
            this.uiResultsGrid.View = System.Windows.Forms.View.Tile;
            // 
            // uiStatus
            // 
            this.uiStatus.AutoSize = true;
            this.uiStatus.Location = new System.Drawing.Point(15, 705);
            this.uiStatus.Name = "uiStatus";
            this.uiStatus.Size = new System.Drawing.Size(35, 13);
            this.uiStatus.TabIndex = 1;
            this.uiStatus.Text = "label5";
            // 
            // uiSearch
            // 
            this.uiSearch.Location = new System.Drawing.Point(1028, 284);
            this.uiSearch.Name = "uiSearch";
            this.uiSearch.Size = new System.Drawing.Size(100, 23);
            this.uiSearch.TabIndex = 1;
            this.uiSearch.Text = "Search";
            this.uiSearch.UseVisualStyleBackColor = true;
            this.uiSearch.Click += new System.EventHandler(this.uiSearch_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(204, 284);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(818, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // uiSettings
            // 
            this.uiSettings.Enabled = false;
            this.uiSettings.Location = new System.Drawing.Point(98, 284);
            this.uiSettings.Name = "uiSettings";
            this.uiSettings.Size = new System.Drawing.Size(100, 23);
            this.uiSettings.TabIndex = 5;
            this.uiSettings.Text = "Settings";
            this.uiSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 727);
            this.Controls.Add(this.uiSettings);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.uiSearch);
            this.Controls.Add(this.uiStatus);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrepWinCustom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiGetSearchFolder;
        private System.Windows.Forms.TextBox uiTargetFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox uiSearchFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker uiEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox uiUseDateRange;
        private System.Windows.Forms.DateTimePicker uiStartDate;
        private System.Windows.Forms.CheckBox uiIncludeSubFolders;
        private System.Windows.Forms.TextBox uiSearchPattern;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox uiToday;
        private System.Windows.Forms.CheckBox uiLastHour;
        private System.Windows.Forms.CheckBox uiJustNow;
        private System.Windows.Forms.CheckBox uiLast4Hours;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label uiStatus;
        private System.Windows.Forms.Button uiSearch;
        private System.Windows.Forms.ListView uiResultsGrid;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button uiSettings;
    }
}

