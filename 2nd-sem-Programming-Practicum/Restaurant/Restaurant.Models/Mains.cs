namespace Restaurant.Models
{
    public class Mains : Food
    {
        public double _calories;
        public Mains(string name, double grams, decimal price)
            : base(name, grams, price)
        {
        }

        public double Calories
        {
            get => _calories;
            set
            {
                _calories = Grams;
            }
        }

        public double Grams { get; set; }
    }
}
