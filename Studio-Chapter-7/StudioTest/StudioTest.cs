using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudioNS;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace StudioTest
{
    [TestClass]
    public class CheckboxTest
    {
        Checkbox test;

        [TestInitialize]
        public void TeatData()
        {
            test = new Checkbox(Dictionnaries.cbQuestions, Dictionnaries.cbCorrects);
        }

        [TestMethod]
        public void Constructor_WorksProperly()
        {
            Assert.AreEqual("<p>[variableName]</p> ", test.Listings["Which of the following show proper data-binding syntax? Choose ALL that apply."][1]);
            Assert.AreEqual(5, test.Corrects[0][1]);
        }

        [TestMethod]
        public void ListEquality_WorksProperly()
        {
            Assert.IsTrue(test.ListEquality(new List<int> { 3, 2, 1 }, new List<int> { 1, 2, 3 }));
        }

        [TestMethod]
        public void PrintList_WorksProperly()
        {
            Assert.AreEqual("123", test.PrintList(new List<int> { 1, 2, 3 }));
        }

        [TestMethod]
        public void CorrectAnswersCB_WorksProperly()
        {
            Assert.AreEqual(2, test.CorrectAnswersCB(new List<List<int>> { new List<int>{ 1, 2, 3 }, new List<int>{ 4, 5} }, new List<List<int>> { new List<int>{ 2, 1, 3 }, new List<int>{ 4, 5 } }));
        }

        [TestMethod]
        public void ArrayContainElement_WorksProperly()
        {
            int[] testarr = new int[] { 1, 2, 3 };
            Assert.IsTrue(test.ArrayContainElement("23", testarr));
            Assert.IsFalse(test.ArrayContainElement("456", testarr));
        }
    }

    [TestClass]
    public class MultipleChoiceTest
    {
        MultipleChoice test;

        [TestInitialize]
        public void TeatData()
        {
            test = new MultipleChoice(Dictionnaries.mcQuestions, Dictionnaries.mcCorrects);
        }

        [TestMethod]
        public void Constructor_WorksProperly()
        {
            Assert.AreEqual("Only an event handler is needed", test.Listings["To include dynamic styles in a component:"][1]);
            Assert.AreEqual(4, test.Corrects[1]);
        }

        [TestMethod]
        public void CorrectAnswers_WorksProperly()
        {
            Assert.AreEqual(1, test.CorrectAnswers( new List<int> { 1, 1, 3}, new List<int> { 3, 1, 4}));
        }
    }

    [TestClass]
    public class TrueFalseTest
    {
        TrueFalse test;

        [TestInitialize]
        public void TeatData()
        {
            test = new TrueFalse(Dictionnaries.tfQuestions, Dictionnaries.tfCorrects);
        }

        [TestMethod]
        public void Constructor_WorksProperly()
        {
            Assert.AreEqual("false", test.Listings["We define a new HTML tag in "][1]);
            Assert.AreEqual(2, test.Corrects[3]);
        }

        [TestMethod]
        public void CorrectAnswers_WorksProperly()
        {
            Assert.AreEqual(2, test.CorrectAnswers(new List<int> { 1, 1, 3 }, new List<int> { 1, 1, 4 }));
        }
    }
}
 