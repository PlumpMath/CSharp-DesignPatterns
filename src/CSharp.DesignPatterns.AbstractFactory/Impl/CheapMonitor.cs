namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class CheapMonitor : IMonitor {
        #region IHardDrive Members

        public string GetInformation() {
            return "Picture quality is poor.";
        }

        #endregion
    }
}