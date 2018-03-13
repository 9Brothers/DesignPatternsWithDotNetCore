namespace DesignPatterns.Shared.Patterns.Factory {
  public class NYCheesePizza : Pizza {
    public NYCheesePizza()
    {
      Name = "NY Style Sauce and Cheese Pizza";
      Dough = "This Crust Dough";
      Sauce = "Marinara Sauce";

      Toppings.Add("Grated Reggiano Cheese");
    }
  }
}