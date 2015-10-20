using System;
using System.Linq.Expressions;

namespace CSharp.DesignPatterns.Specification {
    /// <summary>
    /// Define um contrato para especificações.
    /// </summary>
    /// <typeparam name="T">Tipo do objeto.</typeparam>
	public interface ISpecification<T>
        where T : class {
        #region Methods

        /// <summary>
        /// Verifica um objeto candidato a especificação.
        /// </summary>
        /// <param name="candidate">Instância do objeto candidato.</param>
        /// <returns><c>true</c> se o objeto candidato se encaixa na especificação, caso contrário <c>false</c>.</returns>
        bool IsSatisfiedBy(T candidate);
        /// <summary>
        /// Adiciona uma operação de AND a especificação.
        /// </summary>
        /// <param name="other">Outra instância de <see cref="ISpecification{T}"/> a ser concatenada.</param>
        /// <returns>Retorna a especificação atual.</returns>
		ISpecification<T> And(ISpecification<T> other);
        /// <summary>
        /// Adiciona uma operação de OR a especificação.
        /// </summary>
        /// <param name="other">Outra instância de <see cref="ISpecification{T}"/> a ser concatenada.</param>
        /// <returns>Retorna a especificação atual.</returns>
        ISpecification<T> Or(ISpecification<T> other);
        /// <summary>
        /// Negativa da especificação.
        /// </summary>
        /// <returns>Retorna a especificação atual.</returns>
		ISpecification<T> Not();

        #endregion
    }
}