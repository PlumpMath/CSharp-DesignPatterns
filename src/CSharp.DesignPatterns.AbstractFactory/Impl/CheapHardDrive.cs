namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class CheapHardDrive : IHardDrive {
        #region IHardDrive Members

        public string GetInformation() {
            return "Data will take more time to store.";
        }

        #endregion
    }
}