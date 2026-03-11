// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Select Array size:  ");

            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number:  ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }



            double avg = CalculateAverage(array);
            Console.WriteLine($"Average: {avg}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error happened: " + e.Message);
        }
        
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