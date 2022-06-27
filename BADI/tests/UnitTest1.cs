using BADI;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            //Testing my class hierarchy for some intended implementation and also SN assembly link with main program
            Feed grains = new Feed();
            LiveFeeder cricket = new LiveFeeder();
            cricket.Diet.Add(grains);

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}