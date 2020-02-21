using Microsoft.VisualStudio.TestTools.UnitTesting;
using name_sorter.Utils;
using Name_Sorter.Tests.Helpers;
using System;
using System.Linq;

namespace Name_Sorter.Tests
{
    [TestClass]
    public class SortingTest
    {
        /// <summary>
        /// Test with input 1 form of name
        /// </summary>
        [TestMethod]
        public void SortNameWith1Form()
        {
            ISorting sorting = new Sorting(Constants.NAMEWITH1FORMINPUT);
            sorting.Sort();

            bool result = Constants.NAMEWITH1FORMOUTPUT.SequenceEqual(sorting.SortedNames);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test with input 2 form of name
        /// </summary>
        [TestMethod]
        public void SortNameWith2Form()
        {
            ISorting sorting = new Sorting(Constants.NAMEWITH2FORMINPUT);
            sorting.Sort();

            bool result = Constants.NAMEWITH2FORMOUTPUT.SequenceEqual(sorting.SortedNames);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test with input 3 form of name
        /// </summary>
        [TestMethod]
        public void SortNameWith3Form()
        {
            ISorting sorting = new Sorting(Constants.NAMEWITH3FORMINPUT);
            sorting.Sort();

            bool result = Constants.NAMEWITH3FORMOUTPUT.SequenceEqual(sorting.SortedNames);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test with input more than 4 form of name
        /// </summary>
        [TestMethod]
        public void SortNameWithMoreThan4Form()
        {
            ISorting sorting = new Sorting(Constants.NAMEWITHMORETHAN4FORMINPUT);
            sorting.Sort();

            bool result = Constants.NAMEWITHMORETHAN4FORMOUTPUT.SequenceEqual(sorting.SortedNames);

            Assert.IsTrue(result);
        }
    }
}
