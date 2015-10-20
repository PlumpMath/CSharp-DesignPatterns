namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class CheapComputerFactory : IComputerFactory {
        #region IComputerFactory Members

        public IHardDrive GetHardDrive() {
            return new CheapHardDrive();
        }

        public IMonitor GetMonitor() {
            return new CheapMonitor();
        }

        public IProcessor GetProcessor() {
            return new CheapProcessor();
        }

        #endregion
    }
}