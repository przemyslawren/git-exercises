
namespace new_app;

internal static class ConsoleApp
{
    public static void Main(string[] args)
    {
        const string name = "Przemek";
        Console.WriteLine("Hello!");
        Console.WriteLine($"My name is {name}");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var arrContents = string.Join(", ", arr);
        Console.WriteLine(arrContents);
        Console.WriteLine("Average of the array above is: " + Average(arr));
        
        Console.WriteLine(arrContents);
        Console.WriteLine($"Max number in the array above is: {Max(arr)}");

        static double Average(int[] arr)
        {
            double sum = 0;
            for (var index = 0; index < arr.Length; index++)
            {
                sum += arr[index];
            }

            return sum / arr.Length;
        }

        static double Max(int[] arr)
        {
            int max = 0;
            foreach (var i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }
    }
}