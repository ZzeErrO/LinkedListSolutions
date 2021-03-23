using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemo;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenValue_WhenSearched_ThenReturnIsValid()
        {
            //AAA
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(76);
            //Act
            bool result = list.Search(30);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenValue_WhenInserted_ThenReturnIsValid()
        {
            //AAA
            //Arrange
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(76);
            //Act
            bool result = list.Insert(2,40);
            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
