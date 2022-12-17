using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practical;

namespace UnitTests
{
    [TestClass]
    public class ParserTests
    {
        [TestMethod]
        [DataRow("31.12.2022")]
        [DataRow("01.01.1900")]
        [DataRow("20.10.2000")]
        [DataRow("31.12.2099")]
        [DataRow("01.01.1900")]
        public void DateTest(string input)
        {
            Assert.IsTrue(Parser.Date(input));
        }
        [TestMethod]
        [DataRow("32.01.2000")]
        [DataRow("00.01.1999")]
        [DataRow("01.00.2000")]
        [DataRow("01.00.1800")]
        [DataRow("01.01.20100")] // Скорее всего излишне, т.к. маска в поле ввода не позволит ввести >4 символов в году
        [DataRow("01.01.1899")]
        [DataRow("12,12.2002")]
        [DataRow("11.d1.2000")]
        public void InvalidDateTest(string input)
        {
            Assert.IsFalse(Parser.Date(input));
        }

        [TestMethod]
        [DataRow("Дней:01 Часов:11 Минут:15")]
        [DataRow("Дней:00 Часов:00 Минут:00")]
        [DataRow("Дней:99 Часов:99 Минут:99")]
        public void TimeTest(string input)
        {
            Assert.IsTrue(Parser.Time(input));
        }
        [TestMethod]
        [DataRow("Дней:101 Часов:11 Минут:15")]
        [DataRow("Дней:01 Чапов:11 Минут:15")]
        [DataRow("Дней:01 Часов:11 Минут:1 ")]
        [DataRow("Дней :01 Часов:11 Минут:15")]
        [DataRow("Дней:01 Часов:у Минут:15")]
        [DataRow("Дней:01Часов:11 Минут:15")]
        [DataRow("Дней:01 Часов:111 Минут:15")]
        [DataRow("Дней:01 Часов:11 Минут:115")]
        public void InvalidTimeTest(string input)
        {
            Assert.IsFalse(Parser.Time(input));
        }
        [TestMethod]
        [DataRow("200")]
        [DataRow("200.01")]
        [DataRow("200.20302")]
        [DataRow("200,1111")]
        [DataRow("200,0")]
        [DataRow("0")]
        public void CostTest(string input)
        {
            Assert.IsTrue(Parser.Cost(input));
        }

        [TestMethod]
        [DataRow("200 рублей")]
        [DataRow("200d")]
        [DataRow("20d0.20302")]
        [DataRow("200d")]
        [DataRow("")]
        public void InvalidCostTest(string input)
        {
            Assert.IsFalse(Parser.Cost(input));
        }

    }
}
