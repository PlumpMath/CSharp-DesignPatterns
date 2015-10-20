using System;

namespace CSharp.DesignPatterns.Specification.Impl {
    /// <summary>
    /// OR implementation of a specification.
    /// </summary>
    /// <typeparam name="T">Type of the object.</typeparam>
	public class OrSpecification<T> : CompositeSpecification<T>
        where T : class {
        #region Private Read-Only Fields

        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;

        #endregion

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="OrSpecification{T}"/>.
        /// </summary>
        /// <param name="left">Left side specification.</param>
        /// <param name="right">Right side specification.</param>
        public OrSpecification(ISpecification<T> left, ISpecification<T> right) {
            if (left == null) {
                throw new ArgumentNullException("left");
            }
            if (right == null) {
                throw new ArgumentNullException("right");
            }

            _left = left;
            _right = right;
        }

        #endregion

        #region Public Override Methods

        /// <inheritdoc />
        public override bool IsSatisfiedBy(T candidate) {
            return _left.IsSatisfiedBy(candidate) || _right.IsSatisfiedBy(candidate);
        }

        #endregion
    }
}