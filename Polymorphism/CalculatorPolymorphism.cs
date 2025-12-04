namespace Polymorphism
{
    public class CalculatorPolymorphism
    {
        public void Calculation()
        {
            bool shallAddOnlyPositive = false;
            var numbers = new List<int> { 2, -1, 6, -10, 30, -5 };
            var calc = shallAddOnlyPositive ? new PositiveNumbersCalculation() :  new NumbersCalculation();
           Console.WriteLine(calc.Calculate(numbers));
        }
        public class NumbersCalculation
        {
            public int Calculate(List<int> numbers)
            {
                var sum = 0;
                foreach (var number in numbers) {
                    if(IsPositive(number))
                    sum += number;
                }
                return sum;
            }
            protected virtual bool IsPositive(int number) {
                return true;
            }
        }
        public class PositiveNumbersCalculation: NumbersCalculation {
            protected override bool IsPositive(int number) {
                return number > 0;
            }
        }
    }
}
