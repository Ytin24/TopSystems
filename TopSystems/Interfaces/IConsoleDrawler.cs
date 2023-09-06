using TopSystems.Model;

namespace TopSystems.interfaces
{
    public interface IConsoleDrawler
    {
        public Task DrawToConsole();
        public void Accept(Visitor visitor);
    }
}