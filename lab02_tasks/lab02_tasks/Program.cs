class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Git!");

        int a = 5;
        int b = 8;
        int c = a + b;
        Console.WriteLine(c);

        int[] arr = { 4, 5, 7, 8 };
        
        foreach(int num in arr)
            Console.WriteLine(num);
    }

    public static double average(int[] arr)
    {
        int sum = 0;
        foreach (int number in arr)
        {
            sum += number;
        }

        double average = sum / arr.Length;

        return average;
    }

    public static int max(int[] arr)
    {
        int max = 0;
        foreach (int num in arr)
            if (num > max)
                max = num;
        return max;
    }
}