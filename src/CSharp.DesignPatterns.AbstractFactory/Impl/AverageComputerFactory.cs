namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class AverageComputerFactory : IComputerFactory {
        #region IComputerFactory Members

        public IHardDrive GetHardDrive() {
            return new AverageHardDrive();
        }

        public IMonitor GetMonitor() {
            return new AverageMonitor();
        }

        public IProcessor GetProcessor() {
            return new ExpensiveProcessor();
        }

        #endregion
    }
}