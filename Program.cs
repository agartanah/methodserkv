using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodserkv {
  internal class Program {


    // метод серединных квадратов
    static void Main(string[] args) {
      decimal x0 = 0.2152m;
      int countX = 100;
      decimal[] x = new decimal[countX];
      decimal[] x2 = new decimal[countX];

      x[0] = x0;
      x2[0] = x0 * x0;

      for (int index = 1; index < x.Length; ++index) {
        if (index == 90) {
          Console.WriteLine();
        }
        
        decimal number = (x0 * x0) * 100;
        decimal number2 = number - Math.Round(number - 0.5m, 0);
        x[index] = Math.Round(number2 - 0.00005m, 4, MidpointRounding.AwayFromZero);
        x0 = x[index];
        x2[index] = x0 * x0;
      }

      for (int index = 0; index < x.Length; ++index) {
        Console.WriteLine($"{index + 1}. " + x[index] + $" {x2[index]}");
      }
    }
  }
}
