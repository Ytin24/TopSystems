using System.Xml.Linq;
using TopSystems.Figures;

namespace TopSystems.Model {
    public abstract class Visitor {
        public abstract Task Visit(IFigure figure);
    }
}