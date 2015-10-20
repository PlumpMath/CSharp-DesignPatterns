using CSharp.DesignPatterns.Specification.Impl;

namespace CSharp.DesignPatterns.Specification.Test {
    public class WheelQuantitySpecification : CompositeSpecification<Vehicle> {
        private int _wheelsQuantity;

        public WheelQuantitySpecification(int wheelsQuantity) {
            _wheelsQuantity = wheelsQuantity;
        }

        public override bool IsSatisfiedBy(Vehicle candidate) {
            return candidate.WheelsQuantity >= _wheelsQuantity;
        }
    }
}