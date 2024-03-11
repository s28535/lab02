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
        foreach (int num in arr)
        {
            sum += num;
        }

        double average = sum / arr.Length;

        return average;
    }
}