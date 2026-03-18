namespace Polymorphism.ExtensionsPractice
{
    public static class ListExtensions
    {
        public static List<int> TakeEverySecond(this List<int> list)
        {
            return list.Where((x, index) => index % 2 == 0).ToList();
        }
    }
}
