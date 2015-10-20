using CSharp.DesignPatterns.AbstractFactory.Impl;
using NUnit.Framework;

namespace CSharp.DesignPatterns.AbstractFactory.Test {
    [TestFixture]
    public class AbstractFactoryTest {
        [Test]
        public void CheapComputerFactory_Should_Build_Cheap_Computer_Configuration() {
            // arrange
            IComputerFactory factory = new CheapComputerFactory();

            // act
            var processor = factory.GetProcessor();
            var hardDrive = factory.GetHardDrive();
            var monitor = factory.GetMonitor();

            // assert
            Assert.IsInstanceOf<CheapProcessor>(processor);
            Assert.IsInstanceOf<CheapHardDrive>(hardDrive);
            Assert.IsInstanceOf<CheapMonitor>(monitor);
        }

        [Test]
        public void ExpensiveComputerFactory_Should_Build_Cheap_Computer_Configuration() {
            // arrange
            IComputerFactory factory = new ExpensiveComputerFactory();

            // act
            var processor = factory.GetProcessor();
            var hardDrive = factory.GetHardDrive();
            var monitor = factory.GetMonitor();

            // assert
            Assert.IsInstanceOf<ExpensiveProcessor>(processor);
            Assert.IsInstanceOf<ExpensiveHardDrive>(hardDrive);
            Assert.IsInstanceOf<ExpensiveMonitor>(monitor);
        }

        [Test]
        public void AverageComputerFactory_Should_Build_Cheap_Computer_Configuration() {
            // arrange
            IComputerFactory factory = new AverageComputerFactory();

            // act
            var processor = factory.GetProcessor();
            var hardDrive = factory.GetHardDrive();
            var monitor = factory.GetMonitor();

            // assert
            Assert.IsInstanceOf<ExpensiveProcessor>(processor);
            Assert.IsInstanceOf<AverageHardDrive>(hardDrive);
            Assert.IsInstanceOf<AverageMonitor>(monitor);
        }
    }
}