using System;
using System.Collections.Generic;
using grepWinCustom.Contracts;
using grepWinCustom.Library;
using grepWinCustom.Model;
using NUnit.Framework;
using Utilities;

namespace grepWinCustom.Tests
{
    [TestFixture]
    public class SearchTest
    {
        [Test]
        public void When_calling_search_with_test_folder_return_valid_file_data()
        {
            string targerFolder = TestHelper.GetTemplateDataPath("Test Files");

            var expected = new List<SearchResult>
            {
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\22be1002-871c-4ccc-a799-864c60f55e28_Response.xml"),
                    Size = "4.50 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 20, 55, 26),
                    FileMatch = true
                },
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\86d47d79-8be0-4c62-a663-87402b3ac726_Response.xml"),
                    Size = "4.50 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 21, 01, 36),
                    FileMatch = true
                },
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\e59bf54d-2b9a-4861-8db8-38b760f5413a_Response.xml"),
                    Size = "4.50 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 21, 02, 09),
                    FileMatch = true
                }
            };

            IGrepWinEngine gwe = new GrepWinEngine(targerFolder);
            gwe.Search("<GLA>", "*_Response.xml");
            var actual = gwe.SearchResults;

            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(expected[0].FileName, actual[0].FileName);
            Assert.AreEqual((expected[1].DateModified - DateTime.MinValue).Seconds, (actual[1].DateModified - DateTime.MinValue).Seconds);
            Assert.AreEqual(expected[2].Matches, actual[2].Matches);
        }

        [Test]
        public void When_calling_search_with_test_folder_return_valid_file_data_2()
        {
            string folderToSearch = TestHelper.GetTemplateDataPath("Test Files");

            var expected = new List<SearchResult>
            {
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\22be1002-871c-4ccc-a799-864c60f55e28_Request.xml"),
                    Size = "4.39 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 20, 58, 39),
                    FileMatch = true
                },
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\86d47d79-8be0-4c62-a663-87402b3ac726_Request.xml"),
                    Size = "4.39 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 13, 19, 04),
                    FileMatch = true
                },
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\e59bf54d-2b9a-4861-8db8-38b760f5413a_Request.xml"),
                    Size = "4.39 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 14, 25, 39),
                    FileMatch = true
                }
            };

            IGrepWinEngine gwe = new GrepWinEngine(folderToSearch);
            gwe.Search("<Value>275908</Value>", "*_Request.xml");
            var actual = gwe.SearchResults;

            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(expected[0].FileName, actual[0].FileName);
            Assert.AreEqual((expected[1].DateModified - DateTime.MinValue).Seconds, (actual[1].DateModified - DateTime.MinValue).Seconds);
            Assert.AreEqual(expected[2].Matches, actual[2].Matches);
        }

        [Test]
        public void When_calling_search_with_test_folder_return_valid_file_data_3()
        {
            string folderToSearch = TestHelper.GetTemplateDataPath("Test Files");

            IGrepWinEngine gwe = new GrepWinEngine(folderToSearch);
            gwe.Search("<Value>275908</Value>", "*_Response.xml");
            var actual = gwe.SearchResults;

            Assert.AreEqual(0, actual.Count);
        }

        [Test]
        public void When_calling_search_with_test_folder_return_valid_file_data_4()
        {
            string folderToSearch = TestHelper.GetTemplateDataPath("Test Files");

            IGrepWinEngine gwe = new GrepWinEngine(folderToSearch);
            gwe.Search("<Value>275908</Value>", "*_Request.xml", new DateTime(2017, 08, 14, 13, 0, 0), new DateTime(2017, 08, 14, 15, 0, 0));
            var actual = gwe.SearchResults;

            Assert.AreEqual(2, actual.Count);
        }

        [Test]
        public void When_calling_search_with_test_folder_return_valid_file_data_4_1()
        {
            string folderToSearch = TestHelper.GetTemplateDataPath("Test Files");

            IGrepWinEngine gwe = new GrepWinEngine(folderToSearch);
            gwe.Search("<Value>275908</Value>", "*_Request.xml", new DateTime(2017, 08, 14, 13, 0, 0), new DateTime(2017, 08, 14, 15, 0, 0), true);
            var actual = gwe.SearchResults;

            Assert.AreEqual(3, actual.Count);
        }

        [Test]
        public void When_calling_search_with_test_folder_return_valid_file_data_5()
        {
            string folderToSearch = TestHelper.GetTemplateDataPath("Test Files");

            var expected = new List<SearchResult>
            {
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\86d47d79-8be0-4c62-a663-87402b3ac726_Request.xml"),
                    Size = "4.39 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 13, 19, 04),
                    FileMatch = true
                },
                new SearchResult
                {
                    FullPath = TestHelper.GetTemplateDataPath(@"Test Files\e59bf54d-2b9a-4861-8db8-38b760f5413a_Request.xml"),
                    Size = "4.39 KB",
                    Matches = 1,
                    DateModified = new DateTime(2017, 08, 14, 14, 25, 39),
                    FileMatch = true
                }
            };

            IGrepWinEngine gwe = new GrepWinEngine(folderToSearch);
            gwe.Search("<Value>275908</Value>", "", new DateTime(2017, 08, 14, 13, 0, 0), new DateTime(2017, 08, 14, 15, 0, 0));
            var actual = gwe.SearchResults;

            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual(expected[0].FileName, actual[0].FileName);
            Assert.AreEqual((expected[1].DateModified - DateTime.MinValue).Seconds, (actual[1].DateModified - DateTime.MinValue).Seconds);
        }
    }
}
