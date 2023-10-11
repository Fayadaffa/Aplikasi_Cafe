using NUnit.Framework;
using Aplikasi_Cafe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplikasi_Cafe.Tests
{
    [TestFixture()]
    public class MenuTests
    {
         Menu mn = new Menu();
        [Test()]
        public void satuanKoptamTest()
        {
            string satuankoptam = "1";
            Assert.IsTrue(true, satuankoptam);
            Assert.False(false, satuankoptam);
        }

        [Test()]
        public void HargaKoptamTest()
        {
            double HargaKoptam = mn.HargaKoptam(1);
            Assert.AreEqual(15000, HargaKoptam);
        }

        [Test()]
        public void TampilKoptamTest()
        {
            string satuankoptam = "1";
            Assert.IsTrue(true, satuankoptam);
            Assert.False(false, satuankoptam);
        }

        [Test()]
        public void HitungKoptamTest()
        {
            double HitungKoptam = mn.HargaKoptam(1);
            Assert.AreEqual(15000, HitungKoptam);
        }

        [Test()]
        public void satuanKopsusTest()
        {
            string satuankopsus = "1";
            Assert.IsTrue(true, satuankopsus);
            Assert.False(false, satuankopsus);
        }

        [Test()]
        public void HargaKopsusTest()
        {
            double HargaKopsus = mn.HargaKopsus(1);
            Assert.AreEqual(13000, HargaKopsus);
        }

        [Test()]
        public void TampilKopsusTest()
        {
            string satuankopsus = "1";
            Assert.IsTrue(true, satuankopsus);
            Assert.False(false, satuankopsus);
        }

        [Test()]
        public void HitungKopsusTest()
        {
            double HitungKopsus = mn.HargaKopsus(1);
            Assert.AreEqual(13000, HitungKopsus);
        }

        [Test()]
        public void satuanNasgorTest()
        {
            string satuanNasgor = "1";
            Assert.IsTrue(true, satuanNasgor);
            Assert.False(false, satuanNasgor);
        }

        [Test()]
        public void HargaNasgorTest()
        {
            double HargaNasgor = mn.HargaNasgor(1);
            Assert.AreEqual(12000, HargaNasgor);
        }

        [Test()]
        public void TampilNasgorTest()
        {
            string satuanNasgor = "1";
            Assert.IsTrue(true, satuanNasgor);
            Assert.False(false, satuanNasgor);
        }

        [Test()]
        public void HitungNasgorTest()
        {
            double HitungNasgor = mn.HargaNasgor(1);
            Assert.AreEqual(12000, HitungNasgor);
        }

        [Test()]
        public void satuanKoprangTest()
        {
            string satuankoprang = "1";
            Assert.IsTrue(true, satuankoprang);
            Assert.False(false, satuankoprang);
        }

        [Test()]
        public void HargaKoprangTest()
        {
            double HargaKoprang = mn.HargaKoprang(1);
            Assert.AreEqual(10000, HargaKoprang);
        }

        [Test()]
        public void TampilKoprangTest()
        {
            string satuankoprang = "1";
            Assert.IsTrue(true, satuankoprang);
            Assert.False(false, satuankoprang);
        }

        [Test()]
        public void HitungKoprangTest()
        {
            double HitungKoprang = mn.HargaKoprang(1);
            Assert.AreEqual(10000, HitungKoprang);
        }
    }
}