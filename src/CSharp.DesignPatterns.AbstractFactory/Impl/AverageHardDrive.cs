namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class AverageHardDrive : IHardDrive {
        #region IHardDrive Members

        public string GetInformation() {
            return "Data will take medium time to store.";
        }

        #endregion
    }
}