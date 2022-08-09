using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;


namespace Section2Mocks1._16.Test
{
    [TestFixture]
    public class Class1
    {


        [Test]
        public void Mocking()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            ICalculator calc = mockCalc.Object;
            Assert.That(calc, Is.Not.Null);
        }

        [Test]
        public void Stub()
        {
            int x = 9, y = 19;
            Mock<ICalculator> mockCalc = new Mock<ICalculator>();
            mockCalc
                .Setup(c => c.add(It.IsAny<Int32>(), It.IsAny<Int32>()))
                .Returns(x + y);

            ICalculator calc = mockCalc.Object;
            Assert.That(calc.add(x, y), Is.EqualTo(x + y));
        }

        [Test]
        public void Fake()
        {
            int x = 9, y = 19;
            FakeCalculator calc = new FakeCalculator();
            Assert.That(calc.add(x, y), Is.GreaterThan(0));
        }

    }
}
