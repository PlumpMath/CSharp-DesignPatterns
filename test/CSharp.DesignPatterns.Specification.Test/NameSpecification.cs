using CSharp.DesignPatterns.Specification.Impl;

namespace CSharp.DesignPatterns.Specification.Test {
    public class NameSpecification : CompositeSpecification<Vehicle> {
        private string _name;

        public NameSpecification(string name) {
            _name = name;
        }

        public override bool IsSatisfiedBy(Vehicle candidate) {
            return candidate.Name == _name;
        }
    }
}
