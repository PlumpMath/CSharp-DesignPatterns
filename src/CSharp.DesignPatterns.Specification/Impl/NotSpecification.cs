using System;

namespace CSharp.DesignPatterns.Specification.Impl {
    /// <summary>
    /// NOT implementation of a specification.
    /// </summary>
    /// <typeparam name="T">Type of the object.</typeparam>
	public class NotSpecification<T> : CompositeSpecification<T>
        where T : class {
        #region Private Read-Only Fields

        private readonly ISpecification<T> _other;

        #endregion

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="NotSpecification{T}"/>.
        /// </summary>
        /// <param name="other">Specification to be negated.</param>
        public NotSpecification(ISpecification<T> other) {
            if (other == null) {
                throw new ArgumentNullException("other");
            }

            _other = other;
        }

        #endregion

        #region Public Override Methods

        /// <inheritdoc />
        public override bool IsSatisfiedBy(T candidate) {
            return !_other.IsSatisfiedBy(candidate);
        }

        #endregion
    }
}