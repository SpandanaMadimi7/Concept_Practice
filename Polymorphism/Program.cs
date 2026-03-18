using Polymorphism;
using Polymorphism.ExtensionsPractice;

// PizzaPractice pizza = new PizzaPractice();
// pizza.Pizzas();

CalculatorPolymorphism calculatorPolymorphism = new CalculatorPolymorphism();
calculatorPolymorphism.Calculation();
Console.WriteLine("Next season of Winter: " + Season.Winter.Next());
Console.WriteLine("Next season of Winter: " + Season.Summer.Next());
Console.WriteLine("Next season of Winter: " + Season.Fall.Next());
public enum Season
{
    Spring,
    Summer,
    Fall,
    Winter
}

