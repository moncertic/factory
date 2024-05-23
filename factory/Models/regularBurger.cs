namespace factory.Models
{
    public class regularBurger : IBurgerFactory
    {
        public string Bun => "Brioche Bun";

        public string Condiments => "Lettuce, Tomato, Onion";

        public string Patty => "Double Beef Patty";
    }



}
