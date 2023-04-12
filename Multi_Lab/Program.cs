namespace Multi_Lab
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var options = new ParallelOptions() { MaxDegreeOfParallelism = 5 };

      Parallel.For(1, 100000, options, (x) => {
        int c = 0;
        for (int i = 1; i <= x; i++)
        {
          if (x % i == 0) c++;
        }
        if (c == 2) Console.WriteLine(x);
      });
    }
  }
}