namespace factory.Models
{
    public class fishBurger:IBurgerFactory
    {


        public string Bun => "Sesame Bun ";

        public string Condiments => "Tartar Sauce, Lettuce ";

        public string Patty => "Fish Patty";

    }
}
