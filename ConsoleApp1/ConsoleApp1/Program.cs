// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(String[] args)
    {
        Console.WriteLine("APBD task 2" + " Andrew Kotowiecki");
        
    }
    static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
        {
            throw new Exception("Empty array");
        }

        if (values == null)
        {
            throw new Exception("Null array");
        }
        
        long sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return (double)sum / values.Length;
    }
    
}