using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proverka;
using System;

namespace TDD.Proverka
{
    [TestClass]
    public class ProverkaTests
    {
        [TestMethod]
        public void FindShortestWord_арбузоваяSpaceслово_словоreturn()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual("слово", str.FindSHortestWord("Короткое слово"));
        }

        [TestMethod]
        public void AmountWords_этоSpaceтестSpaceдляSpaceподсчетаSpaceслов_5return()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual(5, str.AmountWords("это тест для подсчета слов"));
        }

        [TestMethod]
        public void AmountSymb_здесьSpace17Spaceсимволов_17return()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual(17, str.AmountSymb("здесь 17 символов"));
        }

        [TestMethod]
        public void FindNineSymb_переменнаяSpaceзначение_areturn()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual('а', str.FindNineSymb("переменная значение"));
        }

        [TestMethod]
        public void AmountNum_номерSpaceтелефонаSpace79998887766_11return()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual(11, str.AmountNum("номер телефона 79998887766"));
        }

        [TestMethod]
        public void MaxNumPodr_идетSpace12345Spaceпосле_5return()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual(5, str.MaxNumPodr("идет 12345 после"));
        }

        [TestMethod]
        public void Amounttut_тутSpaceтутSpaceтам_2return()
        {
            TDDProverka str = new TDDProverka();
            Assert.AreEqual(2, str.Amounttut("тут тут там", "ут"));
        }

    }
}
