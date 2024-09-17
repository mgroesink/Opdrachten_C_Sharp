using Opdrachten_C_Sharp.Models.Block1;
using Opdrachten_C_Sharp.Models.Block2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_C_Sharp_Tests
{
    public partial class Block2Tests
    {
        [Fact]
        public void MediumAllToppingsPriceTest()
        {
            Pizza pizza = new Pizza { Size = Pizza.PizzaSize.Medium, Salami = true, Speck = true, Ham = true, Egg = true, Ananas = true, Olive = true, Chicken = true };
            double price = pizza.GetTotalPrice();
            Assert.Equal(10.25, price);
        }

        [Fact]
        public void LargeNoToppingsPriceTest()
        {
            Pizza pizza = new Pizza { Size = Pizza.PizzaSize.Large, Salami = false, Speck = false, Ham = false, Egg = false, Ananas = false, Olive = false, Chicken = false };
            double price = pizza.GetTotalPrice();
            Assert.Equal(7.5, price);
        }

        [Fact]
        public void SmallHawaiPriceTest()
        {
            Pizza pizza = new Pizza { Size = Pizza.PizzaSize.Small, Salami = false, Speck = false, Ham = true, Egg = false, Ananas = true, Olive = false, Chicken = true };
            double price = pizza.GetTotalPrice();
            Assert.Equal(7, price);
        }

    }
}
