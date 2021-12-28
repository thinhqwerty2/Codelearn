using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using AForge.Math;
using System.IO;

namespace OOP
{
    public partial class Client
    {
        public int id { set; get; }
        public Client(int id)
        {
            this.id = id;
        }
        public static void Main()
        {
            #region vd1 facade
            // MicroWaveFacade1 microWave1 = new MicroWaveFacade1();
            // microWave1.setTime(10);
            // microWave1.setTemperature(100);
            // microWave1.start();

            // MicroWaveFacade2 microWave = new MicroWaveFacade2();
            // microWave.start(10, 100);
            #endregion
            #region vd2 facade
            Client client0 = new Client(0);
            Client client1 = new Client(1);
            Client client2 = new Client(2);

            MicroWaveFacade microWave = new MicroWaveFacade();
            MicroWaveFacade microWave1 = new MicroWaveFacade();
            MicroWaveFacade microWave2 = new MicroWaveFacade();

            microWave.start(3, 100, client0);
            microWave1.start(5, 100, client0);
            // microWave2.start(5, 99, client0);
            Console.ReadLine();

            microWave.start(2, 100, client1);
            microWave1.start(5, 50, client1);
            Console.ReadLine();

            // microWave.getInfo();
            // microWave1.getInfo();
            microWave2.getInfo();
            Console.ReadLine();

            // MicroWaveFacade.getInfoClient(client0);
            MicroWaveFacade.getInfoClient(client1);
            // MicroWaveFacade.getInfoClient(client2);
            #endregion

            #region vd1 interpreter
            // string s = "3000 cm to mm";
            // var client = new Client(new Context1());
            // Console.WriteLine($"{s} = {client.interpret(s)}");
            #endregion
            #region  vd2 interpreter
            // Context s = new Context("9 8 2 - + 9 * 8 -");
            // Console.WriteLine(Client.Parse(s.Text).interpret());
            // Console.ReadLine();
            #endregion
        }
        public static PFExpression Parse(string text)
        {
            Stack<PFExpression> stack = new Stack<PFExpression>();
            //parse the text
            string[] words = text.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                PFExpression left = null, right = null;
                switch (word)
                {
                    case "+":
                        right = stack.Pop();
                        left = stack.Pop();
                        stack.Push(new Add(left, right));
                        break;
                    case "-":
                        right = stack.Pop();
                        left = stack.Pop();
                        stack.Push(new Sub(left, right));
                        break;
                    case "*":
                        right = stack.Pop();
                        left = stack.Pop();
                        stack.Push(new Mult(left, right));
                        break;
                    case "/":
                        right = stack.Pop();
                        left = stack.Pop();
                        stack.Push(new Div(left, right));
                        break;
                    default:
                        int number = int.Parse(word);
                        stack.Push(new Number(number));
                        break;
                }
            }
            return stack.Pop();
        }
    }
}
