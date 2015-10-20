using CSharp.DesignPatterns.Specification.Impl;

namespace CSharp.DesignPatterns.Specification.Test {
    public class ModelSpecification : CompositeSpecification<Vehicle> {
        private string _model;

        public ModelSpecification(string model) {
            _model = model;
        }

        public override bool IsSatisfiedBy(Vehicle candidate) {
            return candidate.Model == _model;
        }
    }
}
