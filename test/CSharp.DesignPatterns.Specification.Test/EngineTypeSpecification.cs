using CSharp.DesignPatterns.Specification.Impl;

namespace CSharp.DesignPatterns.Specification.Test {
    public class EngineTypeSpecification : CompositeSpecification<Vehicle> {
        private EngineType _engineType;

        public EngineTypeSpecification(EngineType engineType) {
            _engineType = engineType;
        }

        public override bool IsSatisfiedBy(Vehicle candidate) {
            return candidate.EngineType == _engineType;
        }
    }
}