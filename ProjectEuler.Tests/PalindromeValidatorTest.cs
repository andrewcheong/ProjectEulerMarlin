using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.MiscQuestions;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class PalindromeValidatorTest
    {
        [TestMethod]
        public void TestWow()
        {
            // Arrange
            string value = "wow";
            PalindromeValidator target = new PalindromeValidator(value);
            object expected = "Yes";

            // Act
            object actual = target.RunSolution();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDud()
        {
            // Arrange
            string value = "dud";
            PalindromeValidator target = new PalindromeValidator(value);
            object expected = "Yes";

            // Act
            object actual = target.RunSolution();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAustralia()
        {
            // Arrange
            string value = "australia";
            PalindromeValidator target = new PalindromeValidator(value);
            object expected = "No";

            // Act
            object actual = target.RunSolution();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKayak()
        {
            // Arrange
            string value = "Kayak";
            PalindromeValidator target = new PalindromeValidator(value);
            object expected = "Yes";

            // Act
            object actual = target.RunSolution();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRotavator()
        {
            // Arrange
            string value = "Rotavator";
            PalindromeValidator target = new PalindromeValidator(value);
            object expected = "Yes";

            // Act
            object actual = target.RunSolution();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
