namespace CSharp.DesignPatterns.AbstractFactory.Impl {
    public class ExpensiveHardDrive : IHardDrive {
        #region IHardDrive Members

        public string GetInformation() {
            return "Data will take less time to store.";
        }

        #endregion
    }
}