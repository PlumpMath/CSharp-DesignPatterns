namespace CSharp.DesignPatterns.Builder {
    public class HarleyDavidson883Builder : VehicleBuilder {
        #region Public Constructor

        public HarleyDavidson883Builder() {
            Vehicle = new Vehicle("Harley-Davidson 883");
        }

        #endregion

        #region Public Override Methods

        public override void BuildDoors() {
            Vehicle.QuantityOfDoors = 0;
        }

        public override void BuildEngine() {
            Vehicle.Engine = 800;
        }

        public override void BuildFrame() {
            Vehicle.Frame = "Motorcycle Frame";
        }

        public override void BuildWheels() {
            Vehicle.QuantityOfWheels = 2;
        }

        #endregion
    }
}