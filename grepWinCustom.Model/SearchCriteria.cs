using System;
using System.IO;

namespace grepWinCustom.Model
{
    public class SearchCriteria
    {
        public string TargetFolder { get; set; } = string.Empty;
        public string SearchText { get; set; } = string.Empty;
        public string SearchPattern { get; set; } = string.Empty;
        public string FullPath { get; set; } = string.Empty;
        public string FileName => FullPath.Length > 0 ? Path.GetFileName(FullPath) : string.Empty;
        public string FilePath => FullPath.Length > 0 ? Path.GetDirectoryName(FullPath) : string.Empty;
        public bool UseDateRange { get; set; } = false;
        public bool DateRangeToday { get; set; } = false;
        public bool DateRangeLast4Hours { get; set; } = false;
        public bool DateRangeLastHour { get; set; } = false;
        public bool DateRangeJustNow { get; set; } = false;
        public bool IncludeSubfolders { get; set; } = false;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
