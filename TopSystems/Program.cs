using TopSystems.Figures;

namespace TopSystems {
    internal class Program {
        static async Task Main(string[] args) {
            await new Square(20, 10).DrawToConsole();
            await new Square(10, 20).DrawToConsole();
            await new Square(10).DrawToConsole();
            await new Triangle(10).DrawToConsole();
            await new Circle(5).DrawToConsole();
        }
    }
}