using Polymorphism;
using Polymorphism.ExtensionsPractice;

// PizzaPractice pizza = new PizzaPractice();
// pizza.Pizzas();

CalculatorPolymorphism calculatorPolymorphism = new CalculatorPolymorphism();
calculatorPolymorphism.Calculation();
Console.WriteLine("Next season of Winter: " + Season.Winter.Next());
Console.WriteLine("Next season of Winter: " + Season.Summer.Next());
Console.WriteLine("Next season of Winter: " + Season.Fall.Next());
var list = new List<int> { 1, 2, 3, 4, 5, 6 };
var newList = list.TakeEverySecond();
Console.WriteLine(string.Join(",", newList));
public enum Season
{
    Spring,
    Summer,
    Fall,
    Winter
}