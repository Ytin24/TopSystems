using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TopSystems.Figures;
using TopSystems.interfaces;

namespace TopSystems.Model {
    public class ConsoleDrawlerStructure {
        List<IConsoleDrawler> Figures = new List<IConsoleDrawler>();
        public void Add(IConsoleDrawler element) {
            Figures.Add(element);
        }
        public void Remove(IConsoleDrawler element) {
            Figures.Remove(element);
        }
        public void Accept(Visitor visitor) {
            foreach (IConsoleDrawler figure in Figures)
                figure.Accept(visitor);
        }
    }
}
