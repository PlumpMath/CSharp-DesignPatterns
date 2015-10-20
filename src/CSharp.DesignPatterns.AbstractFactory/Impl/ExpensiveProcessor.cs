namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class ExpensiveProcessor : IProcessor {
        #region IHardDrive Members

        public string GetInformation() {
            return "Operation will perform quickly.";
        }

        #endregion
    }
}