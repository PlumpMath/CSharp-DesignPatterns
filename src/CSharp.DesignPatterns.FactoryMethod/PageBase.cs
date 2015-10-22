namespace CSharp.DesignPatterns.FactoryMethod {
    public abstract class PageBase {
        #region Public Override Methods

        public override string ToString() {
            return GetType().Name;
        }

        #endregion
    }
}