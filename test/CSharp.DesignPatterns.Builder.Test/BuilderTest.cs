using NUnit.Framework;

namespace CSharp.DesignPatterns.Builder.Test {
    [TestFixture]
    public class BuilderTest {
        [Test]
        public void Can_Build_A_Car() {
            // arrange
            VehicleBuilder builder = new FordMustangBuilder();

            // act
            builder.BuildDoors();
            builder.BuildEngine();
            builder.BuildFrame();
            builder.BuildWheels();

            var vehicle = builder.GetVehicle();

            // assert
            Assert.IsNotNull(vehicle);
            Assert.AreEqual(2, vehicle.QuantityOfDoors);
            Assert.AreEqual(5000, vehicle.Engine);
            Assert.AreEqual("Car Frame", vehicle.Frame);
            Assert.AreEqual(4, vehicle.QuantityOfWheels);
        }

        [Test]
        public void Can_Build_A_Motorcycle() {
            // arrange
            VehicleBuilder builder = new HarleyDavidson883Builder();

            // act
            builder.BuildDoors();
            builder.BuildEngine();
            builder.BuildFrame();
            builder.BuildWheels();

            var vehicle = builder.GetVehicle();

            // assert
            Assert.IsNotNull(vehicle);
            Assert.AreEqual(0, vehicle.QuantityOfDoors);
            Assert.AreEqual(800, vehicle.Engine);
            Assert.AreEqual("Motorcycle Frame", vehicle.Frame);
            Assert.AreEqual(2, vehicle.QuantityOfWheels);
        }

        [Test]
        public void Can_Build_A_Scooter() {
            // arrange
            VehicleBuilder builder = new HondaPCXBuilder();

            // act
            builder.BuildDoors();
            builder.BuildEngine();
            builder.BuildFrame();
            builder.BuildWheels();

            var vehicle = builder.GetVehicle();

            // assert
            Assert.IsNotNull(vehicle);
            Assert.AreEqual(0, vehicle.QuantityOfDoors);
            Assert.AreEqual(150, vehicle.Engine);
            Assert.AreEqual("Scooter Frame", vehicle.Frame);
            Assert.AreEqual(2, vehicle.QuantityOfWheels);
        }
    }
}