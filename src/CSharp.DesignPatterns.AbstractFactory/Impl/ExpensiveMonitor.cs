namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class ExpensiveMonitor : IMonitor {
        #region IHardDrive Members

        public string GetInformation() {
            return "Picture quality is high.";
        }

        #endregion
    }
}