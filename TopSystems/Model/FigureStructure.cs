using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TopSystems.Figures;

namespace TopSystems.Model {
    public class FigureStructure {
        List<IFigure> Figures = new List<IFigure>();
        public void Add(IFigure element) {
            Figures.Add(element);
        }
        public void Remove(IFigure element) {
            Figures.Remove(element);
        }
        public void Accept(Visitor visitor) {
            foreach (IFigure figure in Figures)
                figure.Accept(visitor);
        }
    }
}
