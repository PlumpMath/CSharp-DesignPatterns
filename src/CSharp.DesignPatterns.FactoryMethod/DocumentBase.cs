using System.Collections.Generic;

namespace CSharp.DesignPatterns.FactoryMethod {
    public abstract class DocumentBase {
        #region Public Properties

        public IList<PageBase> Pages { get; } = new List<PageBase>();

        #endregion

        #region Protected Constructors

        protected DocumentBase() {
            CreatePages();
        }

        #endregion

        #region Public Abstract Methods

        public abstract void CreatePages();

        #endregion

        #region Public Override Methods

        public override string ToString() {
            return GetType().Name;
        }

        #endregion
    }
}