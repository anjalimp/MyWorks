using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertBL;
namespace ConvertApp.Tests
{
    [TestClass]
    public class BLTests
    {
        [TestMethod]        
        public void ChangeNumberToWords_WithNullInput()
        {
            String expected = "Object reference not set to an instance of an object.";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.ChangeNumberToWords(null);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]       
        public void ChangeNumberToWords_WithCharacterInput()
        {
            String expected = "Input string was not in a correct format.";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.ChangeNumberToWords("abc");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]        
        public void ChangeNumberToWords_WithBlankInput()
        {
            String expected = "";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.ChangeNumberToWords("");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChangeNumberToWords_WithWholeNumberInput()
        {
            String expected = "One Hundred and Twenty Three";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.ChangeNumberToWords("123");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ChangeNumberToWords_WithDecimalNumberInput()
        {
            String expected = "One Hundred and Twenty Three point Four Five";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.ChangeNumberToWords("123.45");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]      
        public void ChangeNumberToWords_WithNegativeInput()
        {
            String expected = "Input string was not in a correct format.";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.ChangeNumberToWords("-12345");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TranslateDecimal_WithNullInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.TranslateDecimal(null);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TranslateDecimal_WithCharacterInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.TranslateDecimal("a");
        }
        [TestMethod]
        public void TranslateDecimal_WithBlankInput()
        {
            String expected = "";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.TranslateDecimal("");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TranslateDecimal_WithWholeNumberInput()
        {
            String expected = " Four Five";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.TranslateDecimal("45");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TranslateWholeNumber_WithNullInput()
        {          
            NumberToWord numbObj = new NumberToWord();
            numbObj.TranslateWholeNumber(null);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TranslateWholeNumber_WithCharacterInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.TranslateWholeNumber("abc");
        }
        [TestMethod]       
        public void TranslateWholeNumber_WithBlankInput()
        {
            String expected = "";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.TranslateWholeNumber("");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TranslateWholeNumber_WithWholeNumberInput()
        {
            String expected = "One Hundred and Twenty Three";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.TranslateWholeNumber("123");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TranslateWholeNumber_WithNegativeInput()
        {          
            NumberToWord numbObj = new NumberToWord();
            numbObj.TranslateWholeNumber("-12345");            
        }
        [TestMethod]        
        public void Tens_WithNullInput()
        {
            String expected = "";
            NumberToWord numbObj = new NumberToWord();
            String actual =  numbObj.Tens(null);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Tens_WithCharacterInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.Tens("ab");
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Tens_WithBlankInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.Tens("");
        }
        [TestMethod]
        public void Tens_WithWholeNumberInput()
        {
            String expected = "Twenty Three";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.Tens("23");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tens_WithTensInput()
        {
            String expected = "Ten";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.Tens("10");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]       
        public void Ones_WithNullInput()
        {
            String expected = "";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.Ones(null);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Ones_WithCharacterInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.Ones("a");
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Ones_WithBlankInput()
        {
            NumberToWord numbObj = new NumberToWord();
            numbObj.Ones("");
        }
        [TestMethod]
        public void Ones_WithWholeNumberInput()
        {
            String expected = "Two";
            NumberToWord numbObj = new NumberToWord();
            String actual = numbObj.Ones("2");
            Assert.AreEqual(expected, actual);
        }

    }
}
