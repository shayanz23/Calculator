using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System;
using Calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        //Tests basic addition
        [TestMethod]
        public void TestParseExpressionAddition()
        {
            CalculatorLogic ParseAddtionExpression = new CalculatorLogic("2+2");
            string AdditionResult = ParseAddtionExpression.Parse();
            Assert.AreEqual("4", AdditionResult);
        }

        //Tests basic subtraction
        [TestMethod]
        public void TestParseExpressionSubtraction()
        {
            CalculatorLogic ParseSubtractionExpression = new CalculatorLogic("2-2");
            string SubtractionResult = ParseSubtractionExpression.Parse();
            Assert.AreEqual("0", SubtractionResult);
        }

        //Tests to see if it returns a negative value 
        [TestMethod]
        public void TestParseExpressionNegativeSubtraction()
        {
            CalculatorLogic ParseNegativeSubtractionExpression = new CalculatorLogic("2-4");
            string NegativeSubtractionExpressionResult = ParseNegativeSubtractionExpression.Parse();
            Assert.AreEqual("-2", NegativeSubtractionExpressionResult);
        }

        //Tests multiplication
        [TestMethod]
        public void TestParseExpressionMultiplication()
        {
            CalculatorLogic ParseMultiplicationExpression = new CalculatorLogic("2*2");
            string MultiplicationExpressionResult = ParseMultiplicationExpression.Parse();
            Assert.AreEqual("4", MultiplicationExpressionResult);
        }

        //Tests multiplication by 0 
        [TestMethod]
        public void TestParseExpressionMultiplicationByZero()
        {
            CalculatorLogic ParseMultiplicationByZeroExpression = new CalculatorLogic("2*0");
            string MultiplicationByZeroResult = ParseMultiplicationByZeroExpression.Parse();
            Assert.AreEqual("0", MultiplicationByZeroResult);
        }

        //Tests basic divison
        [TestMethod]
        public void TestParseExpressionDivision()
        {
            CalculatorLogic ParseExpressionDivision = new CalculatorLogic("2/2");
            string DivsionResult = ParseExpressionDivision.Parse();
            Assert.AreEqual("1", DivsionResult);
        }

        //Tests divde by zero, should catch an exception
        [TestMethod]
        public void TestParseExpressionDivideByZero()
        {
            try
            {
                CalculatorLogic ParseDivideZero = new CalculatorLogic("2/0");
                string Result = ParseDivideZero.Parse();

            } catch (Exception)
            {

            }

        }
    
        //Tests isNum function, should return true 
        [TestMethod]
        public void TestIsNum()
        {
            CalculatorLogic IsNumber = new CalculatorLogic("1");
            bool result = IsNumber.isNum('1');
            Assert.AreEqual(true, result);

        }

        //Tests is num function based on wrong input, should return false
        [TestMethod]
        public void TestIsNumWrongInput()
        {
            CalculatorLogic ClTwo = new CalculatorLogic("A");
            bool SecondResult = ClTwo.isNum('A');
            Assert.AreEqual(false, SecondResult);
        }

        //Tests * operator, given * is an operator, should return true
        [TestMethod]
        public void TestIsOperator()
        {
            CalculatorLogic IsCorrectOperator = new CalculatorLogic("");
            bool result = IsCorrectOperator.isOperator('*');
            Assert.AreEqual(true, result);
        }

        //Tests operator function, given $ is not an operator for this calculator, should return false 
        [TestMethod]
        public void TestWrongOperator()
        {
            CalculatorLogic WrongOperator = new CalculatorLogic("");
            bool result = WrongOperator.isOperator('$');
            Assert.AreEqual(false, result);
        }


        //Tests special operator, given * is not a special operator, should return false 
        [TestMethod]
        public void TestNotSpecialOperator()
        {
            CalculatorLogic IsNotSpecialOperator = new CalculatorLogic("");
            bool result = IsNotSpecialOperator.isSpecialOperator('*');
            Assert.AreEqual(false, result);
        }


        //Tests special operator, given + is not a special operator, should return true
        [TestMethod]
        public void TestIsSpecialOperatorPlus()
        {
            CalculatorLogic IsSpecialOperator = new CalculatorLogic("");
            bool result = IsSpecialOperator.isSpecialOperator('+');
            Assert.AreEqual(true, result);
        }

        //Tests special operator, given - is not a special operator, should return true
        [TestMethod]
        public void TestIsSpecialOperatorMinus()
        {
            CalculatorLogic IsSpecialOperator = new CalculatorLogic("");
            bool result = IsSpecialOperator.isSpecialOperator('-');
            Assert.AreEqual(true, result);
        }
      
    }
}
