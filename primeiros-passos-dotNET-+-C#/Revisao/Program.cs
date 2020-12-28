using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Alune[] alunes = new Alune[5];
            var contadorAlunes = 0;
            string opçaoUsuario = OpcaoMenu();

            while (opçaoUsuario.ToUpper() != "X")
            {
                switch (opçaoUsuario)
                {
                    case "1":

                        Console.WriteLine("Informe o nome de alune: ");
                        Alune alune = new Alune();
                        alune.Nome = Console.ReadLine();

                        Console.WriteLine("Informe agora a nota desse alune: ");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            alune.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Coloque a Nota da pessoa vei. Avacalhe não.");
                        }
                        
                        alunes[contadorAlunes] = alune;
                        contadorAlunes++;
                        break;

                    case "2":

                        Console.WriteLine("-------------------LISTA DE ALUNOS-------------------\n");
                        foreach(var a in alunes)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                                Console.WriteLine($"|NOME: {a.Nome} ---- NOTA: {a.Nota}|\n");
                            
                        }
                        break;


                    case "3":

                        decimal somaNota = 0;
                        for(int i = 0; i < alunes.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunes[i].Nome))
                            {
                                somaNota += alunes[i].Nota;
                            }
                        }

                        var media = (somaNota/contadorAlunes);
                        ConceitoEnum conceito;

                        if (media >= 8)
                        {
                            conceito = ConceitoEnum.A;
                        }
                        else if (media < 2)
                        {
                            conceito = ConceitoEnum.F;
                        }
                        else if (media < 4)
                        {
                            conceito = ConceitoEnum.D;
                        }
                        else if (media < 6)
                        {
                            conceito = ConceitoEnum.C;
                        }
                        else
                        {
                            conceito = ConceitoEnum.B;
                        }
                        
                        Console.WriteLine($"MEDIA GERAL: {media} ----- CONCEITO: {conceito}");
                        break;

                    default:

                        throw new ArgumentOutOfRangeException("Escolheu uma opção inexistente. Tente novamente...");
                }
                
                opçaoUsuario = OpcaoMenu();
            }
        }

        private static string OpcaoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opçaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opçaoUsuario;
        }
    }
}
