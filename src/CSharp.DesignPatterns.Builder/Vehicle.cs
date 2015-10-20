namespace CSharp.DesignPatterns.Builder {
    public class Vehicle {
        #region Public Constructors

        public Vehicle(string name) {
            Name = name;
        }

        #endregion

        #region Public Properties

        public string Name { get; }
        public string Frame { get; set; }
        public int Engine { get; set; }
        public int QuantityOfWheels { get; set; }
        public int QuantityOfDoors { get; set; }

        #endregion
    }
}