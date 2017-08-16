using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grepWinCustom.Model
{
    public class SearchResult
    {
        public string FullPath { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public int Matches { get; set; } = 0;
        public string FileName => FullPath.Length > 0 ? Path.GetFileName(FullPath) : string.Empty;
        public string FilePath => FullPath.Length > 0 ? Path.GetDirectoryName(FullPath) : string.Empty;
        public DateTime DateModified { get; set; }
        public bool FileMatch { get; set; } = false;
    }
}
