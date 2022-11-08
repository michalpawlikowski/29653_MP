using System;

namespace aaaa
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
    public class Component : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitComponent(this);
        }
        public string ShowText()
        {
            return "Michał";
        }
    }
    public interface IVisitor
    {
        void VisitComponent(Component element);
    }
    class IVisitor1 : IVisitor
    {
        public void VisitComponent(Component element)
        {
            Console.WriteLine("Dzień dobry " + element.ShowText());
        }
    }
    class IVisitor2 : IVisitor
    {
        public void VisitComponent(Component element)
        {
            Console.WriteLine("Dobranoc " + element.ShowText());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Component c = new Component();
            IVisitor1 v1 = new IVisitor1();
            IVisitor2 v2 = new IVisitor2();
            v1.VisitComponent(c);
            Console.WriteLine();
            v2.VisitComponent(c);
        }
    }
}