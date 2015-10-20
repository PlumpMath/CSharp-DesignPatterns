namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class AverageMonitor : IMonitor {
        #region IHardDrive Members

        public string GetInformation() {
            return "Picture quality is average.";
        }

        #endregion
    }
}