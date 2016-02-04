using System;
using EventMaker.Model;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace EventCatalogSingletonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSize()
        {
            EventCatalogSingleton EventTest = new EventCatalogSingleton();
            Assert.AreEqual(2, EventTest.Events.Count);
        }

        [TestMethod]
        public void TestAdd()
        {
            EventCatalogSingleton EventTest = new EventCatalogSingleton();
            Event Eventet = new Event(DateTime.Now, 1, "Beskrivelse", "Navn", "Sted");
            EventTest.Add(Eventet);

            Assert.AreEqual(true, EventTest.Events.Contains(Eventet));
        }

    }
}
