using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Lucas Iversen")]
    public class UnitTesterCalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        //Test Add with two ints
        [TestCase(5, 4, 9)]
        [TestCase(-2, 3, 1)]
        [TestCase(-4, -2, -6)]
        [TestCase(3, -3, 0)]

        public void Add_AddWithTwoNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        //Test Subtract with two ints
        [TestCase(5, 4, 1)]
        [TestCase(-2, 3, -5)]
        [TestCase(-4, -2, -2)]
        [TestCase(3, -3, 6)]

        public void Subtract_SubtractWithTwoNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }

        //Test Multiply with two ints
        [TestCase(5, 4, 20)]
        [TestCase(-2, 3, -6)]
        [TestCase(-4, -2, 8)]
        [TestCase(3, -3, -9)]

        public void Multiply_MultiplyWithTwoNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        //Test Power with two ints
        [TestCase(5, 4, 625)]
        [TestCase(-2, 3, -8)]
        [TestCase(1, -3, 1)]

        public void Power_PowerWithTwoNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(result));
        }

        //Test Divide with two ints
        [TestCase(6, 2, 3)]
        [TestCase(-6, 3, -2)]
        [TestCase(-2, -2, 1)]
        [TestCase(8, -2, -4)]

        public void Divide_DivideWithTwoNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }

        //Test Add with single int
        [TestCase(6, 8)]
        [TestCase(-4, -2)]

        public void Add_AddWithSingleNumber_ResultIsCorrect(int a, int result)
        {
            _uut.Add(1 + 1);
            Assert.That(_uut.Add(a), Is.EqualTo(result));
        }

        //Test Subtract with single int
        [TestCase(6, 4)]
        [TestCase(-4, -6)]

        public void Subtract_SubtractWithSingleNumber_ResultIsCorrect(int a, int result)
        {
            _uut.Add(1 + 1);
            Assert.That(_uut.Subtract(a), Is.EqualTo(result));
        }

        //Test Multiply with single int
        [TestCase(6, 12)]
        [TestCase(-4, -8)]

        public void Multiply_MultiplyWithSingleNumber_ResultIsCorrect(int a, int result)
        {
            _uut.Add(1 + 1);
            Assert.That(_uut.Multiply(a), Is.EqualTo(result));
        }

        //Test Power with single int
        [TestCase(3, 8)]
        [TestCase(4, 16)]

        public void Power_PowerWithSingleNumber_ResultIsCorrect(int a, int result)
        {
            _uut.Add(1 + 1);
            Assert.That(_uut.Power(a), Is.EqualTo(result));
        }

        //Test Divide with single int
        [TestCase(6, 2)]
        [TestCase(-4, -3)]

        public void Divide_DivideWithSingleNumber_ResultIsCorrect(int a, int result)
        {
            _uut.Add(10 + 2);
            Assert.That(_uut.Divide(a), Is.EqualTo(result));
        }

        //Test Devide by zero exception for two ints
        [TestCase(6, 0)]
        [TestCase(-6, 0)]
        [TestCase(0, 0)]

        public void Divide_DivideWithTwoNumbers_ExceptionThrown(int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(a, b));
        }

        //Test Devide by zero exception for single int
        [TestCase(0)]

        public void Divide_DivideWithTwoNumbers_ExceptionThrown(int a)
        {
            _uut.Add(2 + 5);
            Assert.Throws<DivideByZeroException>(() => _uut.Divide(a));
        }

        //Test New Accumulator
        [TestCase()]
        public void Test_New_Accumulator()
        {
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }

        //Test Accumulator after change
        [TestCase(1, 5, 6)]
        [TestCase(-3, 5, 2)]
        public void Test_Accumulator_After_Change(int a, int b, int result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        //Test Clear
        [TestCase()]
        public void Clear_ResultIsZero()
        {
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }

        //Test clear after change
        [TestCase(1, 5)]
        [TestCase(-3, 5)]
        public void Clear_IsResultZeroAfterAccumulate(int a, int b)
        {
            _uut.Add(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
    }
}
