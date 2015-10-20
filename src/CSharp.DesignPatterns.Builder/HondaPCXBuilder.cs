namespace CSharp.DesignPatterns.Builder {
    public class HondaPCXBuilder : VehicleBuilder {
        #region Public Constructor

        public HondaPCXBuilder() {
            Vehicle = new Vehicle("Honda PCX");
        }

        #endregion

        #region Public Override Methods

        public override void BuildDoors() {
            Vehicle.QuantityOfDoors = 0;
        }

        public override void BuildEngine() {
            Vehicle.Engine = 150;
        }

        public override void BuildFrame() {
            Vehicle.Frame = "Scooter Frame";
        }

        public override void BuildWheels() {
            Vehicle.QuantityOfWheels = 2;
        }

        #endregion
    }
}