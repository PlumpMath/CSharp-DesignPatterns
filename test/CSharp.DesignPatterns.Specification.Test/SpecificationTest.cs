using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharp.DesignPatterns.Specification.Test {
    [TestFixture]
    public class SpecificationTest {
        private IEnumerable<Vehicle> GetVehicles() {
            return new[] {
                new Vehicle { EngineType = EngineType.V4, Model = "Fiat", Name = "147", WheelsQuantity = 4 },
                new Vehicle { EngineType = EngineType.V8, Model = "Ford", Name = "Mustang", WheelsQuantity = 4 },
                new Vehicle { EngineType = EngineType.V4, Model = "BMW", Name = "Isetta", WheelsQuantity = 4 },
                new Vehicle { EngineType = EngineType.V4, Model = "Elektromaschinenbau Fulda GmbH", Name = "Fuldamobil", WheelsQuantity = 3 },
                new Vehicle { EngineType = EngineType.V10, Model = "Kenworth", Name = "W900", WheelsQuantity = 10 }
            };
        }

        [Test]
        public void SimpleSpecificationShouldFilter() {
            // arrange
            var vehicles = GetVehicles();
            var spec = new ModelSpecification("Fiat").And(new WheelQuantitySpecification(4));

            // act
            var selected = vehicles.Where(spec.IsSatisfiedBy);

            // assert
            Assert.AreEqual(1, selected.Count());
            Assert.AreEqual("Fiat", selected.Single().Model);
            Assert.AreEqual(4, selected.Single().WheelsQuantity);
        }
    }
}