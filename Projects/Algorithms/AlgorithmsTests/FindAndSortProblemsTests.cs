using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace AlgorithmsTests
{
    [TestClass]
    public class FindAndSortProblemsTests
    {
        #region Data

            FindAndSortProblems.Pupil[] pupils = new FindAndSortProblems.Pupil[]
            {
                new FindAndSortProblems.Pupil
                {
                    Name = "Alina",
                    Subjects = new FindAndSortProblems.Subject[]
                    {
                        new FindAndSortProblems.Subject { Name = "English", Grades= new uint[] { 9, 8 }, GeneralGrade = 0},
                        new FindAndSortProblems.Subject { Name = "Math", Grades= new uint[] { 7 }, GeneralGrade = 0},
                        new FindAndSortProblems.Subject { Name = "History", Grades= new uint[] {10, 9}, GeneralGrade = 0},
                    },
                    GeneralGrade = 0
                },
                new FindAndSortProblems.Pupil
                {
                    Name = "Vasile",
                    Subjects = new FindAndSortProblems.Subject[]
                    {
                        new FindAndSortProblems.Subject { Name = "English", Grades= new uint[] { 10, 8 }, GeneralGrade = 0},
                        new FindAndSortProblems.Subject { Name = "Math", Grades= new uint[] { 10 }, GeneralGrade = 0},
                        new FindAndSortProblems.Subject { Name = "History", Grades= new uint[] {10, 9, 8}, GeneralGrade = 0},
                    },
                    GeneralGrade = 0
                },
                new FindAndSortProblems.Pupil
                {
                    Name = "Gheorghe",
                    Subjects = new FindAndSortProblems.Subject[]
                    {
                        new FindAndSortProblems.Subject { Name = "English", Grades= new uint[] { 5, 5, 8 }, GeneralGrade = 0},
                        new FindAndSortProblems.Subject { Name = "Math", Grades= new uint[] { 10, 7 }, GeneralGrade = 0},
                        new FindAndSortProblems.Subject { Name = "History", Grades= new uint[] { 9 }, GeneralGrade = 0},
                    },
                    GeneralGrade = 0
                },
            };
        #endregion

        [TestMethod]
        public void SortLotteryNumbersTest()
        {
            uint[] loterryNumbers = new uint[] { 33, 3, 49, 16, 17, 44};
            uint[] expected = new uint[] { 3, 16, 17, 33, 44, 49 };
            var sorted = FindAndSortProblems.SortLotteryNumbers(loterryNumbers);
            CollectionAssert.AreEqual(expected, sorted);
        }

        [TestMethod]
        public void SortCasesTest()
        {
            int[] casesPriority = new int[] { 2, 1, 3, 1, 2, 1, 3, 2, 3, 3, 2, 1, 2, 1, 3, 1, 1, 2, 3, 2, 2 };
            int[] expected = new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3 };
            FindAndSortProblems.SortCases(casesPriority, 0, casesPriority.Length - 1, 2);
            CollectionAssert.AreEqual(expected, casesPriority);
        }

        [TestMethod]
        public void SortWordsTest()
        {
            string text = "Ana are zece mere, zece caise si are zece pere. Cate mere are Ana?";
            FindAndSortProblems.Word[] expected = 
            {
                new FindAndSortProblems.Word { Name = "zece", Occurence = 3 },
                new FindAndSortProblems.Word { Name = "are", Occurence = 3 },
                new FindAndSortProblems.Word { Name = "mere", Occurence = 2 },
                new FindAndSortProblems.Word { Name = "Ana", Occurence = 2 },
                new FindAndSortProblems.Word { Name = "Cate", Occurence = 1 },
                new FindAndSortProblems.Word { Name = "pere", Occurence = 1 },
                new FindAndSortProblems.Word { Name = "si", Occurence = 1 },
                new FindAndSortProblems.Word { Name = "caise", Occurence = 1 }
            };
            CollectionAssert.AreEqual(expected, FindAndSortProblems.SortWords(text));
        }        

        [TestMethod]
        public void SortCandidatesTest()
        {
            FindAndSortProblems.Candidate[] candidates =
            {
                new FindAndSortProblems.Candidate { Name = "Alexandru", Votes = 0 },
                new FindAndSortProblems.Candidate { Name = "Alina", Votes = 0 },
                new FindAndSortProblems.Candidate { Name = "Claudiu", Votes = 0 },
                new FindAndSortProblems.Candidate{ Name = "Gheorghe", Votes = 0 },
                new FindAndSortProblems.Candidate { Name = "Vasile", Votes = 0 }
            };
            FindAndSortProblems.Candidate[] firstPollingResults =
            {
                new FindAndSortProblems.Candidate { Name = "Alexandru", Votes = 20 },
                new FindAndSortProblems.Candidate { Name = "Gheorghe", Votes = 15 },
                new FindAndSortProblems.Candidate { Name = "Alina", Votes = 14 },
                new FindAndSortProblems.Candidate{ Name = "Claudiu", Votes = 10 },
                new FindAndSortProblems.Candidate { Name = "Vasile", Votes = 2 }
            };
            FindAndSortProblems.Candidate[] secondPollingResults =
            {
                new FindAndSortProblems.Candidate { Name = "Alina", Votes = 20 },
                new FindAndSortProblems.Candidate { Name = "Gheorghe", Votes = 13 },
                new FindAndSortProblems.Candidate { Name = "Alexandru", Votes = 10 },
                new FindAndSortProblems.Candidate{ Name = "Vasile", Votes = 10 },
                new FindAndSortProblems.Candidate { Name = "Claudiu", Votes = 5 }
            };
            FindAndSortProblems.Candidate[] thridPollingResults =
            {
                new FindAndSortProblems.Candidate { Name = "Vasile", Votes = 25 },
                new FindAndSortProblems.Candidate { Name = "Alexandru", Votes = 17 },
                new FindAndSortProblems.Candidate { Name = "Claudiu", Votes = 15 },
                new FindAndSortProblems.Candidate{ Name = "Alina", Votes = 11 },
                new FindAndSortProblems.Candidate { Name = "Gheorghe", Votes = 8 }
            };
            FindAndSortProblems.Candidate[] expected =
            {
                new FindAndSortProblems.Candidate { Name = "Alexandru", Votes = 47 },
                new FindAndSortProblems.Candidate { Name = "Alina", Votes = 45 },
                new FindAndSortProblems.Candidate { Name = "Vasile", Votes = 37 },
                new FindAndSortProblems.Candidate{ Name = "Gheorghe", Votes = 36 },
                new FindAndSortProblems.Candidate { Name = "Claudiu", Votes = 30 }
            };            

            FindAndSortProblems.SortCandidates(candidates, firstPollingResults);
            CollectionAssert.AreEqual(firstPollingResults, candidates);
            FindAndSortProblems.SortCandidates(candidates, secondPollingResults);
            FindAndSortProblems.SortCandidates(candidates, thridPollingResults);
            CollectionAssert.AreEqual(expected, candidates);
        }
        
        [TestMethod]
        public void SortPupilsByGeneralGradeTest()
        {            
            string[] expected = new string[] { "Vasile", "Alina", "Gheorghe" };
            CollectionAssert.AreEqual(expected, FindAndSortProblems.SortPupilsByGeneralGrade(pupils));
        }

        [TestMethod]
        public void GetPupilWithLowestGeneralGradeTest()
        {
            var result = FindAndSortProblems.SortPupilsByGeneralGrade(pupils);
            Assert.AreEqual("Gheorghe", result[result.Length - 1]);            
        }

        [TestMethod]
        public void GetPupilWithASpecificGeneralGradeTest()
        {
            var sortedPupils = FindAndSortProblems.SortPupilsByGeneralGrade(pupils);
            var pupil = FindAndSortProblems.BinarySearch(ref pupils, 8.333333f, 0, pupils.Length - 1);
            Assert.AreEqual("Alina", pupil.Name);
        }

        [TestMethod]
        public void GetPupilWithMostTenGradesTest()
        {
            Assert.AreEqual("Vasile", FindAndSortProblems.GetPupilWithGrades(pupils, 10f));
        }
    }
}
