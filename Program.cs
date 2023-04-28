using Maths;
using System.Diagnostics;

using number = System.Int64;

new A398().Run();

class A398 {
  readonly Primes primes = new();

  public void Run() {
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Stopwatch s = new(); s.Start();
    foreach (number p in primes.All) {
      number k = primes.Divisors(p - 1).Select(d => d + 1).Where(primes.IsPrime).Product();
      Console.WriteLine($"p={p} k={k}");
      if (k > 1e12) break;
    }
    s.Stop(); Console.WriteLine($"{s.ElapsedMilliseconds}ms elapsed");
  }
}