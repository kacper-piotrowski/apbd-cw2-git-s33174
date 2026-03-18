namespace PJATK_APBD02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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