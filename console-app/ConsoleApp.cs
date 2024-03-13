
namespace new_app;

internal static class ConsoleApp
{
    public static void Main(string[] args)
    {
        const string name = "Przemek";
        Console.WriteLine("Hello!");
        Console.WriteLine($"My name is {name}");
        int[] arr = { 1, 2, 4, 6, 8, 10};
        var arrContents = string.Join(", ", arr);
        Console.WriteLine(arrContents);
        Console.WriteLine("Average of the array above is: " + Average(arr));

        static double Average(int[] arr)
        {
            double sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }
    }
}