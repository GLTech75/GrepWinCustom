using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using grepWinCustom.Model;

namespace grepWinCustom.Contracts
{
    public interface IGrepWinEngine
    {
        void Search(string searchText);
        void Search(string searchText, bool incluseSubFolders);
        void Search(string searchText, string searchPattern);
        void Search(string searchText, string searchPattern, bool includeSubFolders);
        void Search(string searchText, string searchPattern, DateRange dateRange);
        void Search(string searchText, string searchPattern, DateRange dateRange, bool includeSubFolders);
        void Search(string searchText, string searchPattern, DateTime? startTime, DateTime? endTime);
        void Search(string searchText, string searchPattern, DateTime? startTime, DateTime? endTime, bool includeSubFolders);
        List<SearchResult> SearchResults { get; set; }
    }
}
