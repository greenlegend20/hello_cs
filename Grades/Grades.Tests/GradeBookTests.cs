using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(30);

            GradeStats stats = book.ComputeStats();
            Assert.AreEqual(90, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(30);

            GradeStats stats = book.ComputeStats();
            Assert.AreEqual(30, stats.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(80);
            book.AddGrade(30);

            GradeStats stats = book.ComputeStats();
            Assert.AreEqual(66.66f, stats.AverageGrade, 0.01f );
        }
    }


}
