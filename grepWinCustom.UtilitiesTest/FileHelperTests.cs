using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace grepWinCustom.UtilitiesTest
{
    public class FileHelperTests
    {
        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_no_filters()
        {
            string targetFolder = TestHelper.GetTemplateDataPath("Test Files");

            var criteria = new SearchCriteria
            {
                TargetFolder = targetFolder,

            };

            GrepWinEngine gwe = new GrepWinEngine(targetFolder);

            gwe.GetAllFileEntries(criteria);
            var actual = gwe.SearchResults;

            Assert.AreEqual(12, actual.Count);
        }
    }
}
