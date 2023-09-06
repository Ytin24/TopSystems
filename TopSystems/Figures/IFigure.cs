using TopSystems.interfaces;
using TopSystems.Model;

namespace TopSystems.Figures {
    public interface IFigure : IConsoleDrawler{
        public void Accept(Visitor visitor);
    }
}