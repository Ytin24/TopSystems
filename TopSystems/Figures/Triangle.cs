using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Деление на 2 необходимо лишь потому, что длина шрифта в 2 раза больше чем ширина
namespace TopSystems.Figures {
    internal class Triangle : Figure {
        public readonly int Height;
        public Triangle(int height) {
            Height = height / 2;
        }
        public override Task DrawToConsole() {

            for (int i = 0; i < Height; i++) {
                Console.SetCursorPosition(Height - i - 1, Console.CursorTop);
                Console.WriteLine(new string('*', i * 2 + 1));
            }
            Console.WriteLine();
            return Task.CompletedTask;
        }
    }
}
