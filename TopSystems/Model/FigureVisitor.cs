using TopSystems.Figures;

namespace TopSystems.Model {
    public class FigureVisitor : Visitor {
        public override async Task Visit(IFigure figure) {
           await figure.DrawToConsole();
        }
    }
}