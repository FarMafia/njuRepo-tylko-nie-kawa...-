using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using RozliczeniePracownikow;
using NUnit;


namespace UnitTestProject1
{
    //[Nunit.Framework.TestFixture]
    public class UnitTest1
    {
        [TestMethod]
        public void kosztPrzejazduSamochod()
        {
            var kontekst = new RozliczeniePracownikow.Rozliczenia();
            var aktualna = kontekst.kosztPrzejazduSamochod(900, 5.5F, 5.3F, 54.0F);
            var oczekiwana = 316.35;

            Assert.AreEqual<double>(oczekiwana, aktualna);
        }

        [TestMethod]
        public void chorobowe()
        {
            var kontekst = new RozliczeniePracownikow.Rozliczenia();
            var aktualna = kontekst.chorobowe(10, 3650.0F);
            var oczekiwana = 973.30M;

            Assert.AreEqual<decimal>(oczekiwana, aktualna);
        }

    }
}
