namespace factory.Models
{
    public class chickenBurger : IBurgerFactory
    {
        public string Bun => "Sesame Bun";

        public string Condiments => "Lettuce,tomatos,cucumbers,onions";

        public string Patty => "Roasted chicken";
    }
}
