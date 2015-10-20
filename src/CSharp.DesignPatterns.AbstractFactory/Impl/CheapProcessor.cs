namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class CheapProcessor : IProcessor {
        #region IHardDrive Members

        public string GetInformation() {
            return "Operation will perform slowly.";
        }

        #endregion
    }
}