using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using NUnit.Framework;
using ParcelDelivery.DataLayer.Util;

namespace ParcelDelivery.Test.Util
{
    public class ReadFromFileTest
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Test ReadParcelXml Method in different inputs.
        /// </summary>
        [Test]
        public void ReadParcelXmlTest()
        {
            string truePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"..\\..\\..\\Files\\ContainerSample.xml");
            string wrongPath= Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"..\\..\\..\\Files\\ContainerSample1.xml");

            var result = ReadFromFile.ReadParcelXml("");
            Assert.AreEqual(null, result);

            result = ReadFromFile.ReadParcelXml(truePath);
            Assert.AreEqual(4, result.Count());

            var ex = Assert.Throws<Exception>(() => ReadFromFile.ReadParcelXml(wrongPath));
            Assert.That(ex.Message, Is.EqualTo("Something go wrong while reading file!"));

        }
    }
}
