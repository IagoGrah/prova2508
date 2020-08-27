using System;

namespace prova2508
{
    class Program
    {
        static void Questao1()
        {
            double horas;
            double minutos;
            double porHora;

            Console.Clear();
            Console.WriteLine("Quantas horas e minutos você trabalha por dia?");
            Console.Write("Horas: ");
            horas = Double.Parse(Console.ReadLine());
            Console.Write("Minutos: ");
            minutos = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nQuantos R$ você ganha por hora?");
            porHora = Double.Parse(Console.ReadLine());

            double porDia = ((minutos/60) + horas) * porHora;
            Console.WriteLine($"Você recebe R${porDia.ToString("0.00")} por dia de trabalho.");
        }

        static void Questao2()
        {
            string inputStr = "";

            Console.WriteLine("Insira um texto 1 caractére de cada vez. Insira 'finalizar' para imprimir.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "finalizar") {break;}
                if (input.Length>1)
                {
                    Console.WriteLine("ERRO! Insira um caractére de cada vez:");
                    continue;
                }
                inputStr += input;
            }
            Console.WriteLine("\n"+inputStr);
        }
        
        static void Questao3()
        {
            int arrayLength = 5;
            string[] solteiros = new string[arrayLength];
            
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Clear();
                Console.WriteLine($"Usuário #{i+1}, insira seu nome:");
                var userName = Console.ReadLine();
                Console.WriteLine($"{userName}, você é solteiro(a)?");
                Console.Write("Responda com S ou N: ");
                var solteiroInput = Console.ReadLine();
                if (solteiroInput.ToUpper() == "S")
                {
                    solteiros[i] = userName;
                    continue;
                }
                else if (solteiroInput.ToUpper() != "N")
                {
                    Console.WriteLine("ERRO!");
                    return;
                }
            }

            Console.Clear();
            Console.WriteLine("Solteiros:");
            foreach (var item in solteiros)
            {
                if (item != null) {Console.WriteLine(item);}
            }
        }

        static void Questao4()
        {
            Console.WriteLine("Insira seu ano de nascimento:");
            
            int inputAno;
            while(true)
            {
                var isNumber = Int32.TryParse(Console.ReadLine(), out inputAno);
                if (!isNumber || inputAno > 2020 || inputAno < 1900)
                {
                    System.Console.WriteLine("Número inválido, tente novamente:");
                    continue;
                }
                break;
            }
            Console.WriteLine(inputAno<2002 ? "Você é maior de idade." : "Você é menor de idade.");
        }
        static void Main(string[] args)
        {
            Questao1();
        }
    }
}
