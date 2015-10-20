namespace CSharp.DesignPatterns.AbstractFactory {
    public interface IComputerFactory {
        #region Methods

        IHardDrive GetHardDrive();
        IProcessor GetProcessor();
        IMonitor GetMonitor();

        #endregion
    }
}