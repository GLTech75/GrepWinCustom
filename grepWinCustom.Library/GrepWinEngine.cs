using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using grepWinCustom.Contracts;
using grepWinCustom.Model;
using Opulos.Core.IO;
using Utilities;

namespace grepWinCustom.Library
{
    public class GrepWinEngine : IGrepWinEngine
    {
        private string _targerFolder;

        public delegate void ReportSearchProgressEventHandler(object sender, SearchResultEventArgs e);

        public event ReportSearchProgressEventHandler ReportSearchProgress;

        //private delegate void ProcessFileDelegate(string fileName, string searchText, string folderSearchPattern);

        //private List<SearchResult> _searchResults = new List<SearchResult>();

        public GrepWinEngine()
        {
        }

        public GrepWinEngine(string targerFolder)
        {
            _targerFolder = targerFolder;
        }

        public void Search(string searchText)
        {
            Search(searchText, string.Empty, DateRange.Unknown, null, null, false);
        }

        public void Search(string searchText, bool includeSubFolders)
        {
            Search(searchText, string.Empty, DateRange.Unknown, null, null, includeSubFolders);
        }

        public void Search(string searchText, string searchPattern)
        {
            Search(searchText, searchPattern, DateRange.Unknown, null, null, false);
        }

        public void Search(string searchText, string searchPattern, bool includeSubFolders)
        {
            Search(searchText, searchPattern, DateRange.Unknown, null, null, includeSubFolders);
        }

        public void Search(string searchText, string searchPattern, DateRange dateRange)
        {
            Search(searchText, searchPattern, dateRange, null, null, false);
        }

        public void Search(string searchText, string searchPattern, DateRange dateRange, bool includeSubFolders)
        {
            Search(searchText, searchPattern, dateRange, null, null, includeSubFolders);
        }

        public void Search(string searchText, string searchPattern, DateTime? startTime, DateTime? endTime)
        {
            Search(searchText, searchPattern, DateRange.Unknown, startTime, endTime, false);
        }

        public void Search(string searchText, string searchPattern, DateTime? startTime, DateTime? endTime, bool includeSubFolders)
        {
            Search(searchText, searchPattern, DateRange.Unknown, startTime, endTime, includeSubFolders);
        }

        private void Search(string searchText, string searchPattern, DateRange dateRange, DateTime? startTime, DateTime? endTime, bool includeSubfolders)
        {
            if (_targerFolder.Length == 0)
                throw new Exception("TargetFolder field cannot be empty. Call SetTargerFolder() first.");

            var criteria = new SearchCriteria
            {
                TargetFolder = _targerFolder,
                SearchText = searchText,
                SearchPattern = searchPattern,
                StartTime = startTime,
                EndTime = endTime,
                DateRangeToday = (dateRange == DateRange.Today),
                DateRangeLast4Hours = (dateRange == DateRange.Last4Hours),
                DateRangeLastHour = (dateRange == DateRange.LastHour),
                DateRangeJustNow = (dateRange == DateRange.JustNow),
                UseDateRange = dateRange != DateRange.Unknown || (startTime.HasValue && endTime.HasValue),
                IncludeSubfolders = includeSubfolders
            };
            ProcessSearch(criteria);
        }

        private void ProcessSearch(SearchCriteria criteria)
        {
            foreach (var fileInfo in GetAllFiles(criteria))
            {
                criteria.FullPath = fileInfo.FullName;
                var x = ProcessFile(criteria);
                if (!x.FileMatch)
                    continue;

                OnReportSearchProgress(x);
                SearchResults.Add(x);
            }
        }

        public List<FastFileInfo> GetAllFiles(SearchCriteria criteria)
        {
            //string[] fileEntries = null;
            IEnumerable<FastFileInfo> files = null;
            //var directory = new DirectoryInfo(criteria.TargetFolder);
            var searchPattern = criteria.SearchPattern.Equals(string.Empty) ? "*.*" : criteria.SearchPattern;
            var searchOption = criteria.IncludeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            if (criteria.UseDateRange)
            {
                var startTime = new DateTime();
                var endTime = DateTime.Now;

                if (criteria.DateRangeToday)
                {
                    startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }
                else if (criteria.DateRangeLast4Hours)
                {
                    startTime = DateTime.Now.AddHours(-4);
                }
                else if (criteria.DateRangeLastHour)
                {
                    startTime = DateTime.Now.AddHours(-1);
                }
                else if (criteria.DateRangeJustNow)
                {
                    startTime = DateTime.Now.AddMinutes(-2);
                }
                else // Use from and to date
                {
                    startTime = criteria.StartTime ?? DateTime.MinValue;
                    endTime = criteria.EndTime ?? DateTime.MinValue;
                }

                // Source: https://sourceforge.net/projects/fastfileinfo/

                //files = directory.GetFiles(searchPattern, searchOption)
                //    .Where(f => f.LastWriteTime >= startTime && f.LastWriteTime <= endTime);
                files = FastFileInfo.EnumerateFiles(criteria.TargetFolder, searchPattern, searchOption)
                    .Where(f => f.LastWriteTime >= startTime && f.LastWriteTime <= endTime);
            }
            else
            {
                //files = directory.GetFiles(searchPattern, searchOption);
                files = FastFileInfo.EnumerateFiles(criteria.TargetFolder, searchPattern, searchOption);
            }

            return files.ToList();
        }

        private static SearchResult ProcessFile(SearchCriteria request)
        {
            var fileData = File.ReadAllText(request.FullPath);

            var result = new SearchResult();

            if (Regex.Split(fileData, request.SearchText).Length == 1)
                return result;

            //if (request.StartTime.HasValue && request.EndTime.HasValue)
            //{
            //    var fileDateModified = GetFileModifiedDate(request.FullPath);
            //    if (fileDateModified < request.StartTime.Value || fileDateModified > request.EndTime.Value)
            //    {
            //        return result;
            //    }
            //}

            result = new SearchResult
            {
                FileMatch = true,
                DateModified = GetFileModifiedDate(request.FullPath),
                FullPath = request.FullPath,
                Matches = Regex.Split(fileData, request.SearchText).Length - 1,
                Size = GetFileSize(request.FullPath)
            };

            return result;
        }

        private static DateTime GetFileModifiedDate(string fileName)
        {
            return File.GetLastWriteTime(fileName);
        }

        private static string GetFileSize(string fileName)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(fileName).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            return $"{len:0.#0} {sizes[order]}";
        }

        public void SetTargerFolder(string targetFodler)
        {
            _targerFolder = targetFodler;
        }
        protected virtual void OnReportSearchProgress(SearchResult result)
        {
            ReportSearchProgress?.Invoke(this, new SearchResultEventArgs { SearchResult = result });
        }

        public List<SearchResult> SearchResults { get; set; } = new List<SearchResult>();
    }
}