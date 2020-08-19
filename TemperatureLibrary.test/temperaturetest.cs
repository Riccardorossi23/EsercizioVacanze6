using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureLibrary.test
{
    [TestClass]
    public class temperaturetest
    {
        [TestMethod]
        public void TestIsSottoZero1()
        {
            int numero = 8;
            bool aspettata = false;
            bool valore = Temperature.IsSottoZero(numero);
            Assert.AreEqual(aspettata, valore);
        }
        [TestMethod]
        public void TestIsSottoZero2()
        {
            int numero = -1;
            bool aspettata = true;
            bool valore = Temperature.IsSottoZero(numero);
            Assert.AreEqual(aspettata, valore);
        }

        [TestMethod]
        public void TestIsSottoZero3()
        {
            int numero = -4;
            bool aspettata = true;
            bool valore = Temperature.IsSottoZero(numero);
            Assert.AreEqual(aspettata, valore);
        }

        [TestMethod]
        public void TestIsSottoZero4()
        {
            int numero = 2;
            bool aspettata = false;
            bool valore = Temperature.IsSottoZero(numero);
            Assert.AreEqual(aspettata, valore);
        }

        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(-1, true)]
        public void DataTestIsSottoZeroDataRow(int numero, bool aspettato)
        {
            bool valore = Temperature.IsSottoZero(numero);
            Assert.AreEqual(aspettato, valore);
        }

        [TestMethod]
        public void TestContaSottoZero1()
        {
            int[] valore = new int[] { -2, 3, -4, 6 };
            int aspettato = 2;
            int risposta = Temperature.ContaSottoZero(valore);
            Assert.AreEqual(aspettato, risposta);
        }

        [TestMethod]
        public void TestContaSottoZero2()
        {
            int[] valore = new int[] { 1, -4, -6, 6, 2, -1 };
            int aspettato = 3;
            int risposta = Temperature.ContaSottoZero(valore);
            Assert.AreEqual(aspettato, risposta);
        }

        [TestMethod]
        public void TestContaSottoZero3()
        {
            int[] valore = new int[] { -2, -3, -4, -6 };
            int aspettato = 4;
            int risposta = Temperature.ContaSottoZero(valore);
            Assert.AreEqual(aspettato, risposta);
        }

        [DataTestMethod]
        [DataRow(new int[] { -2, -6, -4, 3, 2 }, 3)]
        [DataRow(new int[] { -1, -2, 3, 2 }, 2)]
        [DataRow(new int[] { -1, 2, 5, -5, -8, -3 }, 4)]
        public void testContaSottoZeroDatarow(int[] valore, int aspettato)
        {
            int risposta = Temperature.ContaSottoZero(valore);
            Assert.AreEqual(risposta, aspettato);
        }

        [TestMethod]
        public void TestMinime1()
        {
            int[] valore = new int[] { -1, 2, -4, -3 };
            int[] aspettato = new int[] { -1, -3, -4 };
            int[] risposta = Temperature.Minime(valore);
            CollectionAssert.AreEquivalent(aspettato, risposta);
        }
        [TestMethod]
        public void Testminime2()
        {
            int[] valore = new int[] { -2, -4, -6, 5, 8, -1 };
            int[] aspettato = new int[] { -2, -4, -6, -1 };
            int[] risposta = Temperature.Minime(valore);
            CollectionAssert.AreEquivalent(aspettato, risposta);
        }

        [DataTestMethod]
        [DataRow(new int[] { -4, -8, -5, 3 }, new int[] { -4, -8, -5 })]
        [DataRow(new int[] { -2, 1, -6, 3 }, new int[] { -2, -6, })]
        public void DataTestMinime(int[] valore, int[] aspettato)
        {
            int[] rispsosta = Temperature.Minime(valore);
            CollectionAssert.AreEquivalent(aspettato, rispsosta);
        }

    }
}





































































































































































