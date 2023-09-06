using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
//Деление на 2 необходимо лишь потому, что длина шрифта в 2 раза больше чем ширина
namespace TopSystems.Figures {
    public class Square : Figure {
        public readonly int Height;
        public readonly int Width;
        public Square(int width) {
            this.Width = width;
            this.Height = width / 2;
        }
        public Square(int height, int width) {
            this.Height = height / 2;
            this.Width = width;
        }
        public override Task DrawToConsole() {
            for (int i = 0; i < Height; i++) {
                for (int j = 0; j < Width; j++) {
                    Console.Write('*');
                }
                Console.WriteLine('*');
            }
            Console.WriteLine();

            return Task.CompletedTask;
        }
    }
}
