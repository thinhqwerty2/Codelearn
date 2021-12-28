using System.Collections.Generic;

namespace OOP
{
    public class Context1
    {
        public double toKm(double x)
        {
            return x / 1000;
        }
        public double toDm(double x)
        {
            return x / 10;
        }
        public double toMm(double x)
        {
            return x * 10;
        }
    }

    public interface IExpression
    {
        double interpret(Context1 context);
    }
    //Terminal
    public class Kilomet : IExpression
    {
        double x;

        public Kilomet(double x)
        {
            this.x = x;
        }

        public double interpret(Context1 context)
        {
            return context.toKm(x);
        }
    }
    public class Deximet : IExpression
    {
        double x;

        public Deximet(double x)
        {
            this.x = x;
        }

        public double interpret(Context1 context)
        {
            return context.toDm(x);
        }
    }
    public class Milimet : IExpression
    {
        double x;

        public Milimet(double x)
        {
            this.x = x;
        }

        public double interpret(Context1 context)
        {
            return context.toMm(x);
        }
    }

    public partial class Client
    {
        Context1 str;
        public Client(Context1 context)
        {
            str = context;
        }
        public double interpret(string s)
        {
            IExpression exp;
            List<string> l = new List<string>(s.Split(' '));
            switch (l[3])
            {
                case "km":
                    exp = new Kilomet(double.Parse(l[0]));
                    return exp.interpret(str);

                case "dm":
                    exp = new Deximet(double.Parse(l[0]));
                    return exp.interpret(str);

                case "mm":
                    exp = new Milimet(double.Parse(l[0]));
                    return exp.interpret(str);
                default:
                    throw new System.Exception("Ko hop le");
            }

        }
    }

}