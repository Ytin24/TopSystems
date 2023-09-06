using TopSystems.Figures;
using TopSystems.Model;

namespace TopSystems {
    internal class Program {

        static async Task Main(string[] args) {
            var Figures = new FigureStructure();
            Figures.Add(new Rectangle(20, 10));
            Figures.Add(new Rectangle(10, 20));
            Figures.Add(new Rectangle(10));
            Figures.Add(new Triangle(10));
            Figures.Add(new Circle(5));
            Figures.Accept(new FigureVisitor());
        }
    }
}