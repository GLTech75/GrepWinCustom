using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using grepWinCustom.Library;
using grepWinCustom.Model;

namespace grepWinCustom
{
    public partial class MainForm : Form
    {
        private bool useDateRange = false;

        private bool useToday = false;
        private bool useLast4Hours = false;
        private bool useLastHour = false;
        private bool useJustNow = false;

        private BackgroundWorker bgw = new BackgroundWorker();

        private GrepWinEngine engine = null;

        private int totalFilesSearched = 0;
        private int totalFilesSkipped = 0;
        private int totalFileMatched = 0;

        private AppSettings appSettings;

        public MainForm()
        {
            InitializeComponent();

            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.WorkerSupportsCancellation = true;
            bgw.WorkerReportsProgress = true;

            appSettings = new AppSettings();
            uiTargetFolder.Text = appSettings.TargetFolder; //@"C:\Users\snymanp\Documents\visual studio 2015\Projects\grepWinCustom\grepWinCustom.Tests\Test Files";
            //uiSearchFor.Text = @"<Value>275908</Value>";
            //uiSearchPattern.Text = @"*_Request.xml";

            uiResultsGrid.Columns.Add("Name", 350);
            uiResultsGrid.Columns.Add("Size", 80);
            uiResultsGrid.Columns.Add("Matches", 80);
            uiResultsGrid.Columns.Add("Path", 450);
            uiResultsGrid.Columns.Add("Date Modified", 150);

            //uiResultsGrid.Items.Add(new ListViewItem(new string[] { "Alpha", "Some details" }));
            //uiResultsGrid.Items.Add(new ListViewItem(new string[] { "Bravo", "More details" }));
            uiResultsGrid.View = View.Details;


            UpdateFormStatus();
        }

        private void uiUseDateRange_CheckedChanged(object sender, EventArgs e)
        {
            useDateRange = !useDateRange;
            if (!useDateRange)
            {
                //useToday = false;
                uiToday.Checked = false;
                uiLast4Hours.Checked = false;
                uiLastHour.Checked = false;
                uiJustNow.Checked = false;
            }

            UpdateFormStatus();
        }

        private void UpdateFormStatus()
        {
            uiStartDate.Enabled = useDateRange;
            uiEndDate.Enabled = useDateRange;

            uiToday.Enabled = useDateRange;
            uiLast4Hours.Enabled = useDateRange;
            uiLastHour.Enabled = useDateRange;
            uiJustNow.Enabled = useDateRange;

            uiStartDate.Value = DateTime.Today;
            uiEndDate.Value = DateTime.Today;
            if (useToday)
            {
                uiStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
                uiEndDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 23, 59, 59);
            }
        }

        private void uiToday_CheckedChanged(object sender, EventArgs e)
        {
            useToday = !useToday;
            UpdateFormStatus();
        }

        private void uiLast4Hours_CheckedChanged(object sender, EventArgs e)
        {
            useLast4Hours = !useLast4Hours;
            UpdateFormStatus();
        }

        private void uiLastHour_CheckedChanged(object sender, EventArgs e)
        {
            useLastHour = !useLastHour;
            UpdateFormStatus();
        }

        private void uiJustNow_CheckedChanged(object sender, EventArgs e)
        {
            useJustNow = !useJustNow;
            UpdateFormStatus();
        }

        private void uiSearch_Click(object sender, EventArgs e)
        {
            totalFilesSearched = 0;
            totalFilesSkipped = 0;
            totalFileMatched = 0;

            uiResultsGrid.Items.Clear();

            var parameters = new SearchCriteria
            {
                TargetFolder = uiTargetFolder.Text,
                UseDateRange = uiUseDateRange.Checked,
                DateRangeToday = uiToday.Checked,
                DateRangeLast4Hours = uiLast4Hours.Checked,
                DateRangeLastHour = uiLastHour.Checked,
                DateRangeJustNow = uiJustNow.Checked,
                SearchPattern = uiSearchPattern.Text,
                SearchText = uiSearchFor.Text,
                StartTime = uiUseDateRange.Checked ? uiStartDate.Value : (DateTime?)null,
                EndTime = uiUseDateRange.Checked ? uiEndDate.Value : (DateTime?)null,
                IncludeSubfolders = uiIncludeSubFolders.Checked
            };

            progressBar1.Visible = true;

            bgw.RunWorkerAsync(parameters);

            //bgw.RunWorkerAsync(new
            //{
            //    targetFolder = uiTargetFolder.Text,
            //    dateRange,
            //    useDateRange = uiUseDateRange.Checked,
            //    searchPattern = uiSearchPattern.Text,
            //    startdate = uiUseDateRange.Checked ? uiStartDate.Value : (DateTime?)null,
            //    endDate = uiUseDateRange.Checked ? uiEndDate.Value : (DateTime?)null,
            //    includeSubFolders = uiIncludeSubFolders.Checked

            //});
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var searchResult = (SearchResult)e.UserState;

            totalFilesSearched++;

            if (searchResult.FileMatch)
            {
                AddSearchResultToGrid(searchResult);

                totalFileMatched++;
            }

            uiStatus.Text = $@"Searched {totalFilesSearched} files, skipped - files. Found - matches in {totalFileMatched} files.";
        }

        private void AddSearchResultToGrid(SearchResult searchResult)
        {
            uiResultsGrid.Items.Add(new ListViewItem(new string[]
            {
                searchResult.FileName,
                searchResult.Size,
                searchResult.Matches.ToString(),
                searchResult.FilePath,
                searchResult.DateModified.ToString("yyyy/MM/dd hh:mm:ss tt")
            }));
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            uiResultsGrid.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            uiResultsGrid.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            uiResultsGrid.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            uiResultsGrid.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            //uiResultsGrid.Columns[4].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

            progressBar1.Visible = false;

        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            var parameters = (SearchCriteria)e.Argument;

            var dateRange = DateRange.Unknown;
            if (parameters.DateRangeToday) { dateRange = DateRange.Today; }
            if (parameters.DateRangeLast4Hours) { dateRange = DateRange.Last4Hours; }
            if (parameters.DateRangeLastHour) { dateRange = DateRange.LastHour; }
            if (parameters.DateRangeJustNow) { dateRange = DateRange.JustNow; }

            engine = new GrepWinEngine(parameters.TargetFolder);
            engine.ReportSearchProgress += Engine_ReportSearchProgress;

            if (parameters.UseDateRange && !parameters.DateRangeToday && !parameters.DateRangeLast4Hours && !parameters.DateRangeLastHour && !parameters.DateRangeJustNow)
            {
                engine.Search(parameters.SearchText, parameters.SearchPattern, parameters.StartTime, parameters.EndTime, parameters.IncludeSubfolders);
            }
            else
            {
                engine.Search(parameters.SearchText, parameters.SearchPattern, dateRange, parameters.IncludeSubfolders);
            }
        }

        private void Engine_ReportSearchProgress(object sender, SearchResultEventArgs e)
        {
            bgw.ReportProgress(0, e.SearchResult);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appSettings.Save();
        }
    }
}
