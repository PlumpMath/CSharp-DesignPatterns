namespace CSharp.DesignPatterns.Builder {
    public abstract class VehicleBuilder {
        #region Protected Properties

        protected Vehicle Vehicle { get; set; }

        #endregion

        #region Public Methods

        public Vehicle GetVehicle() {
            return Vehicle;
        }

        #endregion

        #region Public Abstract Methods

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

        #endregion
    }
}