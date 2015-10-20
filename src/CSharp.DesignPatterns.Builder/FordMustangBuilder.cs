namespace CSharp.DesignPatterns.Builder {
    public class FordMustangBuilder : VehicleBuilder {
        #region Public Constructor

        public FordMustangBuilder() {
            Vehicle = new Vehicle("Ford Mustang");
        }

        #endregion

        #region Public Override Methods

        public override void BuildDoors() {
            Vehicle.QuantityOfDoors = 2;
        }

        public override void BuildEngine() {
            Vehicle.Engine = 5000;
        }

        public override void BuildFrame() {
            Vehicle.Frame = "Car Frame";
        }

        public override void BuildWheels() {
            Vehicle.QuantityOfWheels = 4;
        }

        #endregion
    }
}
