using System;
using grepWinCustom.Model;

namespace grepWinCustom.Contracts
{
    public class SearchResultEventArgs : EventArgs
    {
        public SearchResult SearchResult { get; set; }
    }
}
