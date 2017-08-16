using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using grepWinCustom.Model;

namespace grepWinCustom.Library
{
    public class SearchResultEventArgs : EventArgs
    {
        public SearchResult SearchResult { get; set; }
    }
}
