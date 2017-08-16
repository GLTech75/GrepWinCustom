using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using grepWinCustom.Model;

namespace grepWinCustom.Utilities
{
    public static class FileHelper
    {
        public static string[] GetAllFileEntries(SearchCriteria criteria)
        {
            string[] fileEntries = null;
            fileEntries = Directory.GetFiles(criteria.TargetFolder,
                criteria.SearchPattern.Equals(string.Empty) ? "*.*" : criteria.SearchPattern);

            return fileEntries;
        }
    }
}
