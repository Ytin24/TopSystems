using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSystems.Figures {
    internal class Circle : Figure {
        public readonly Lazy<double> Radius;
        public readonly double Diametr;
        public Circle(double diametr) {
            this.Diametr = diametr;
            this.Radius = new Lazy<double>(() => Diametr / 2);
        }
        public Circle(int diametr) : this(Convert.ToDouble(diametr)) { }
        public override Task DrawToConsole() {
            double r = Radius.Value;
            double r_in = r - 0.3;
            double r_out = r + 0.3;
            for (double y = r; y >= -r; --y) {
                for (double x = -r; x < r_out; x += 0.5) {
                    double value = x * x + y * y;
                    if (value >= r_in * r_in && value <= r_out * r_out) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            return Task.CompletedTask;
        }
    }
}
