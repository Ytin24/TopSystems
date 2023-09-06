using System.Xml.Linq;
using TopSystems.Figures;
using TopSystems.interfaces;

namespace TopSystems.Model {
    public abstract class Visitor {
        public abstract Task Visit(IConsoleDrawler figure);
    }
}