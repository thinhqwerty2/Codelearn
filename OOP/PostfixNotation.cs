using System.Collections.Generic;
namespace OOP
{
    //Abstract Expression
    public abstract class PFExpression
    {
        public abstract double interpret();
    }
    //NonTerminal Expression
    public class Add : PFExpression
    {
        PFExpression left = null;
        PFExpression right = null;
        public Add(PFExpression left, PFExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public override double interpret()
        {
            return left.interpret() + right.interpret();
        }
    }
    public class Sub : PFExpression
    {
        PFExpression left = null;
        PFExpression right = null;
        public Sub(PFExpression left, PFExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public override double interpret()
        {
            return left.interpret() - right.interpret();
        }
    }
    public class Mult : PFExpression
    {
        PFExpression left = null;
        PFExpression right = null;
        public Mult(PFExpression left, PFExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public override double interpret()
        {
            return left.interpret() * right.interpret();
        }
    }
    public class Div : PFExpression
    {
        PFExpression left = null;
        PFExpression right = null;
        public Div(PFExpression left, PFExpression right)
        {
            this.left = left;
            if (right.interpret() == 0) throw new System.Exception("Divide by zero");
            else
                this.right = right;
        }
        public override double interpret()
        {
            return left.interpret() / right.interpret();
        }
    }
    //Terminal Expression
    public class Number : PFExpression
    {
        double value;
        public Number(double value)
        {
            this.value = value;
        }
        public override double interpret()
        {
            return value;
        }
    }
    //Context
    public class Context
    {
        string input;
        public Context(string s)
        {
            input = s;
        }
        public string Text
        {
            get
            {
                return input;
            }
        }

    }

}