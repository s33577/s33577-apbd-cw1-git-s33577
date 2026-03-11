// See https://aka.ms/new-console-template for more information

class Program {
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Select Array size:  ");
            Console.Write("Creatinggg conflict ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number:  ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }



            double avg = CalculateAverage(array);
            Console.WriteLine($"Average: {avg}");
            double max = CalculateMax(array);
            Console.WriteLine($"Max: {max}");
            double min = CalculateMin(array);
            Console.WriteLine($"Min: {min}");
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

    static double CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }
        
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }

    static double CalculateMin(int[] values)
    {

        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }
        int min = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }
        return min;
    }
}