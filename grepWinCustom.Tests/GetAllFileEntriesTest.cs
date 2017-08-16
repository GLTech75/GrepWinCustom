using System;
using grepWinCustom.Library;
using grepWinCustom.Model;
using NUnit.Framework;
using Utilities;

namespace grepWinCustom.Tests
{
    public class GetAllFileEntriesTest
    {
        private readonly string _targetFolder = TestHelper.GetTemplateDataPath("Test Files");

        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_no_filters()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(12, actual.Count);
        }

        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_specify_searchpattern_no_match()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                SearchPattern = "blah"
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(0, actual.Count);
        }

        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_searchpattern_match()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                SearchPattern = "c*_Request.xml"
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(2, actual.Count);
        }

        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_specify_searchpattern_startdate_and_enddate_no_match()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                UseDateRange = true,
                StartTime = new DateTime(2011, 09, 18),
                EndTime = new DateTime(2011, 11, 09)
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(0, actual.Count);
        }

        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_specify_searchpattern_startdate_and_enddate_match()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                UseDateRange = true,
                StartTime = new DateTime(2017, 08, 14, 13, 00, 00),
                EndTime = new DateTime(2017, 08, 14, 15, 00, 00)
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(4, actual.Count);
        }
        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_specify_searchpattern_startdate_and_enddate_match_include_subfolders()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                UseDateRange = true,
                StartTime = new DateTime(2017, 08, 14, 13, 00, 00),
                EndTime = new DateTime(2017, 08, 14, 15, 00, 00),
                IncludeSubfolders = true
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(5, actual.Count);
        }

        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_specify_searchpattern_date_range_just_now_match_include_subfolders()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                UseDateRange = true,
                DateRangeJustNow = true,
                IncludeSubfolders = true
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(0, actual.Count);
        }
        
        [Test]
        public void Call_GetAllFileEntries_valid_target_folder_specify_searchpattern_date_range_today_match_include_subfolders()
        {
            var criteria = new SearchCriteria
            {
                TargetFolder = _targetFolder,
                UseDateRange = true,
                DateRangeToday = true,
                IncludeSubfolders = true
            };

            GrepWinEngine gwe = new GrepWinEngine();
            var actual = gwe.GetAllFiles(criteria);

            Assert.AreEqual(2, actual.Count);
        }
    }
}
