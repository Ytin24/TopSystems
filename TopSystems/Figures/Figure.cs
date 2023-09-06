using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSystems.interfaces;
using TopSystems.Model;

namespace TopSystems.Figures
{
    public abstract class Figure : IConsoleDrawler{
        public abstract Task DrawToConsole();
        public void Accept(Visitor visitor) {
            visitor.Visit(this);
        }
    }
}
