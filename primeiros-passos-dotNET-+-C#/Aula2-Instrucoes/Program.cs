using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 3, c = 4;
            const int d = 5;
            a = 1;
            Console.WriteLine(a + b + c + d + ", é o total da soma das variáveis.");
            Console.WriteLine($"{a + b + c + d}"); //Teste de como funciona o Console.WriteLine()
        }

        static void InstrucaoIf(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum Argumento.");
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("Um Argumento.");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos.");
            }
        }
        static void InstrucaoSwitch(string[] args)
        {
            int argumentos = args.Length;
            switch(argumentos)
            {
                case 0:
                Console.WriteLine("Nenhum Argumento.");
                break;

                case 1:
                Console.WriteLine("Apenas um argumento.");
                break;

                default:
                Console.WriteLine($"{argumentos} argumentos.");
                break;
            }
        }
        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while(i < args.Length)
            {
                Console.WriteLine($"O argumento da posicao {i} é {args[i]}.");
                i++;
            }
        }
        static void InstrucaoDo(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"O argumento da posicao {i} é {args[i]}.");
            }while(i < args.Length);
            i++;

            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));
        }
        static void InstrucaoFor(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"O argumento da posicao {i} é {args[i]}.");
            }   
        }
        static void InstrucaoForEach(string[] args)
        {
           foreach(string s in args)
           {
               Console.WriteLine(s);
           } 
        }
        static void InstrucaoBreak(string[] args)
        {
            while(true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }
        static void InstrucaoContinue(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                if(args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }
        static void InstrucaoReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine(Somar(1,2));
            Console.WriteLine(Somar(1,6));
            Console.WriteLine(Somar(1,304));
            return;
        }
        static void InstrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Opa opa opa, aí está querendo dividir por zero amigone");
                return a / b;
            }

            try
            {
                if (args.Length != 2)
                    throw new InvalidOperationException("Opa opa opa, é apena uma divisão com dois números.");

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até Mais Tardar!!");
            }
        }
        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("Teste.txt"))
            {
              w.WriteLine("Line 1");
              w.WriteLine("Line 2");
              w.WriteLine("Line 3");
            }
          

            //Outra forma de fazer isso:
            // System.IO.TextWriter w;
            // // w = System.IO.File.CreateText("teste.txt");

            // // w.WriteLine("yz");

            // // w.Dispose();
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
