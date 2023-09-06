using TopSystems.Figures;
using TopSystems.interfaces;

namespace TopSystems.Model {
    public class ConsoleDrawlerVisitor : Visitor {
        public override async Task Visit(IConsoleDrawler Drawler) {
           await figure.DrawToConsole();
        }
    }
}