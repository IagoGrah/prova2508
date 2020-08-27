using System;
using System.Text;

namespace prova2508
{
    class Parte2
    {
        public static void Questao5()
        {
            var arrayLength = 5;
            var arr = new double?[arrayLength];
            
            Console.Clear();
            Console.WriteLine($"Insira {arrayLength} números:");
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    var input = Double.Parse(Console.ReadLine());
                    arr[i] = input;
                }
                catch (System.Exception)
                {
                    arr[i] = null;
                }
            }
            Console.Clear();
            foreach (var item in arr)
            {
                if (item != null) {Console.Write(item+" ");}
            }
        }

        public static void Questao6()
        {
            double totalSalarios = 0;
            int pessoas = 0;
            
            Console.Clear();
            Console.WriteLine("Insira os salários, finalize com 'calcular':");
            while(true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "calcular"){break;}
                
                double salario;
                bool isNumber = Double.TryParse(input, out salario);
                if (!isNumber || salario < 0)
                {
                    Console.WriteLine("NÚMERO INVÁLIDO!");
                    continue;
                }
                totalSalarios += salario;
                pessoas++;
            }
            Console.Clear();
            Console.WriteLine($"A média salarial dos {pessoas} funcionários é de R${(totalSalarios/pessoas).ToString("0.00")}.");
        }

        public static void Questao7()
        {
            int users = 5;
            int sc = 0;
            
            for (int i = 0; i < users; i++)
            {
                Console.Clear();
                Console.WriteLine($"Usuário {i+1}, insira o código da UF do estado em que nasceu:");
                Console.WriteLine("11-RO  12-AC  13-AM  14-RR  15-PA");
                Console.WriteLine("16-AP  17-TO  21-MA  22-PI  23-CE");
                Console.WriteLine("24-RN  25-PB  26-PE  27-AL  28-SE");
                Console.WriteLine("29-BA  31-MG  32-ES  33-RJ  35-SP");
                Console.WriteLine("41-PR  42-SC  43-RS  50-MS  51-MT");
                Console.WriteLine("52-GO  53-DF");

                if (Console.ReadLine() == "42"){sc++;}
            }

            Console.Clear();
            Console.WriteLine((100/users)*sc+"% dos usuários nasceram em SC.");
        }

        public static void Questao8()
        {
            var matutino = new string[5];
            var vespertino = new string[5];
            var integral = new StringBuilder();

            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Aluno {i+1} do turno MATUTINO:");
                matutino[i] = Console.ReadLine();
                Console.WriteLine($"Aluno {i+1} do turno VESPERTINO:");
                vespertino[i] = Console.ReadLine();
            }

            foreach (var alunoM in matutino)
            {
                foreach (var alunoV in vespertino)
                {
                    if (alunoM == alunoV)
                    {
                        integral.Append($"{alunoM}, ");
                        break;
                    }
                }
            }

            Console.Clear();
            if (integral.Length != 0)
            {
                integral.Remove(integral.Length - 2, 2);
                Console.WriteLine($"Alunos no período integral: {integral}.");
            }
            else
            {
                Console.WriteLine("Todos os alunos estudam em meio período.");
            }
        }

        static void Main(string[] args)
        {
            Questao5();
        }
    }
}
