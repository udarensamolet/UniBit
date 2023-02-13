namespace Restaurant.Models
{
    public class Beverage : Product
    {
        private double _calories;
        public Beverage(string name, double mililiters, decimal price)
            : base(name, price)
        {
            Milliliters = mililiters;
        }
        public double Milliliters { get; set; }
        public double Calories
        {
            get => _calories;
            set
            {
                _calories = Milliliters * 3;
            }
        }
    }
}
