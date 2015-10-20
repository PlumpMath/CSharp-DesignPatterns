namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class ExpensiveComputerFactory : IComputerFactory {
        #region IComputerFactory Members

        public IHardDrive GetHardDrive() {
            return new ExpensiveHardDrive();
        }

        public IMonitor GetMonitor() {
            return new ExpensiveMonitor();
        }

        public IProcessor GetProcessor() {
            return new ExpensiveProcessor();
        }

        #endregion
    }
}