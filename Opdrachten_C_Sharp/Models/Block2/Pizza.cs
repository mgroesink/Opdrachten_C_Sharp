namespace Opdrachten_C_Sharp.Models.Block2
{
    public class Pizza
    {
        #region Enums
        /// <summary>
        /// Enumeration for pizza sizes
        /// </summary>
        public enum PizzaSize
        {
            Small,
            Medium,
            Large
        } 
        #endregion

        #region Constants
        /// <summary>
        /// The small price
        /// </summary>
        private const double SmallPrice = 5;
        /// <summary>
        /// The medium price
        /// </summary>
        private const double MediumPrice = 6;
        /// <summary>
        /// The large price
        /// </summary>
        private const double LargePrice = 7.5;
        /// <summary>
        /// The salami price
        /// </summary>
        private const double SalamiPrice = 0.50;
        /// <summary>
        /// The speck price
        /// </summary>
        private const double SpeckPrice = 0.50;
        /// <summary>
        /// The ham price
        /// </summary>
        private const double HamPrice = 0.50;
        /// <summary>
        /// The egg price
        /// </summary>
        private const double EggPrice = 1.00;
        /// <summary>
        /// The ananas price
        /// </summary>
        private const double AnanasPrice = 1.00;
        /// <summary>
        /// The olive price
        /// </summary>
        private const double OlivePrice = 0.25;
        /// <summary>
        /// The chicken price
        /// </summary>
        private const double ChickenPrice = 0.50;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public PizzaSize Size { get; set; } = PizzaSize.Medium;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is salami.
        /// </summary>
        /// <value>
        ///   <c>true</c> if salami; otherwise, <c>false</c>.
        /// </value>
        public bool Salami { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is spek.
        /// </summary>
        /// <value>
        ///   <c>true</c> if spek; otherwise, <c>false</c>.
        /// </value>
        public bool Speck { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is ham.
        /// </summary>
        /// <value>
        ///   <c>true</c> if ham; otherwise, <c>false</c>.
        /// </value>
        public bool Ham { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is ei.
        /// </summary>
        /// <value>
        ///   <c>true</c> if ei; otherwise, <c>false</c>.
        /// </value>
        public bool Egg { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is ananas.
        /// </summary>
        /// <value>
        ///   <c>true</c> if ananas; otherwise, <c>false</c>.
        /// </value>
        public bool Ananas { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is olijf.
        /// </summary>
        /// <value>
        ///   <c>true</c> if olijf; otherwise, <c>false</c>.
        /// </value>
        public bool Olive { get; set; } = false;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Pizza"/> is kip.
        /// </summary>
        /// <value>
        ///   <c>true</c> if kip; otherwise, <c>false</c>.
        /// </value>
        public bool Chicken { get; set; } = false;
        #endregion

        #region Methods
        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <returns></returns>
        public double GetTotalPrice()
        {
            // Get the base price
            double price = 0;
            switch (Size)
            {
                case PizzaSize.Small:
                    price = SmallPrice;
                    break;
                case PizzaSize.Medium:
                    price = MediumPrice;
                    break;
                case PizzaSize.Large:
                    price = LargePrice;
                    break;
            }

            // Add the toppings
            if (Salami) price += 0.50;
            if (Speck) price += 0.50;
            if (Ham) price += 0.50;
            if (Egg) price += 1.00;
            if (Ananas) price += 1.00;
            if (Olive) price += 0.25;
            if (Chicken) price += 0.50;

            return price;
        } 
        #endregion
    }
}
