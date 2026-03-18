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
            numbers[i] = double.Parse(Console.ReadLine());
        }
    }
}

class StatisticsHelper
{
    public double[] List { get;}

    public StatisticsHelper(double[] list)
    {
        this.List = list;
    }

}