namespace Polymorphism
{
    public class PizzaPractice
    {
        public void Pizzas()
        {
            // See https://aka.ms/new-console-template for more information
            var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
};

            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient.Name);
            }

        }
    }
    public class Ingredient
    {
        public virtual string Name { get; } = "Generic Ingredient";
    }


    //Example of inheritance - Cheddar class inherits from Ingredient class and the name 
    // Output - will be "Generic Ingredient"
    public class Cheddar : Ingredient
    {
        //  public override string Name => "Cheddar Cheese";
    }

    // Example of inheritance - Mozzarella class inherits from Ingredient class and overrides the name property
    // Output - will be "Mozzarella Cheese"
    public class Mozzarella : Ingredient
    {
        public override string Name => "Mozzarella Cheese";
    }
}
