using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rhino;
using RozliczeniePracownikow;
using NUnit;

namespace TestMock
{
    [NUnit.Framework.TestFixture]
    class Program
    {
        static void Main(string[] args)
        {

        }

        [NUnit.Framework.Test]
        public void testKosztPrzejazduSamochod()
        {
            //var mocks = new Rhino.Mocks.MockRepository();

            //var rozliczeniaMock = mocks.StrictMock<RozliczeniePracownikow.Rozliczenia>();//tworzymy test w rozliczeniu pracownika //przeciazamy klase Rozliczenia w celu testowania danych
            //Rhino.Mocks.Expect.Call(rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F)).Return(100.00); //sfałszownaie wyniku metody dla podanych parametrów
            //mocks.ReplayAll(); //wdrożenie mocków

            //Console.WriteLine(rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F));//przy jakiejkolwiek zmianie ten mock nie zadziała. Powyzszy kod bysmy dali podczas testowania w projekcie testujacym/
            //Console.ReadLine();
            //powyższe jest dla RHINO

            //odtąd jest NUNIT
            var mocks = new Rhino.Mocks.MockRepository();
            var rozliczeniaMock = mocks.StrictMock<RozliczeniePracownikow.Rozliczenia>();//tworzymy test w rozliczeniu pracownika //przeciazamy klase Rozliczenia w celu testowania danych
            Rhino.Mocks.Expect.Call(rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F)).Return(100.00); //sfałszownaie wyniku metody dla podanych parametrów
            mocks.ReplayAll(); //wdrożenie mocków

            NUnit.Framework.Assert.AreEqual(100, rozliczeniaMock.kosztPrzejazduSamochod(1000, 10F, 5F, 50F));
           
        }
    }
}

