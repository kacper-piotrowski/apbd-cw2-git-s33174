namespace PJATK_APBD02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, APBD Lab2!");
        double[] numbers = new double[5];
        Console.WriteLine("You will enter five numbers!");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}.Enter number: ", i+1);
            try
            {
                numbers[i] = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                numbers[i] = 0;
                Console.WriteLine("Wrong number format!");
            }
            
        }
        Console.WriteLine();
        StatisticsHelper sh = new StatisticsHelper(numbers);
        sh.FindMax();
        Console.WriteLine();
        
        int[] numbers2 = new int[5];
        Console.WriteLine("You will enter five numbers again!");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}.Enter number: ", i+1);
            try
            {
                numbers2[i] = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                numbers2[i] = 0;
                Console.WriteLine("Wrong number format!");
            }
        }
        Console.WriteLine();
        
        Console.WriteLine("Your numbers are:");
        Console.WriteLine(string.Join(", ", numbers2));
        
        CalculateAverage(numbers2);
        
        CalculateMax(numbers2);
        
        CalculateMin(numbers2);
    }

    static void CalculateAverage(int[] values)
    {
        Console.WriteLine($"Your average is: {values.Average()}");
    }

    static void CalculateMax(int[] values)
    {
        Console.WriteLine($"Your biggest number is: {values.Max()}");
    }

    static void CalculateMin(int[] values)
    {
        Console.WriteLine($"Your smallest number is: {values.Min()}");
    }
}

class StatisticsHelper
{
    public double[] List { get;}

    public StatisticsHelper(double[] list)
    {
        this.List = list;
    }
    
    public void FindMax()
    {
        Console.WriteLine($"Your biggest number is: {List.Max()}");
    }

}