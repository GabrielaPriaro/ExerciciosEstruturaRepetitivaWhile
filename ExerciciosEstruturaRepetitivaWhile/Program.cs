using System.Globalization;

namespace ExerciciosEstruturaRepetitivaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();

        }

        static void Exercicio1()
        {
            string senha;

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("\nSenha Invalida. Tente novamente.");
                Console.Write("\nDigite a senha: ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("\nSenha Correta. ACESSO PERMITIDO");
        }

        static void Exercicio2()
        {
            int x, y;

            Console.Write("Digite as coordenadas X e Y do plano cartesiano: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            y = int.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("\nprimeiro quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("\nsegundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("\nterceiro quadrante");
                }
                else
                {
                    Console.WriteLine("\nquarto quadrante");
                }

                Console.Write("\nDigite as coordenadas X e Y do plano cartesiano: ");
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0], CultureInfo.InvariantCulture);
                y = int.Parse(coordenadas[1], CultureInfo.InvariantCulture);
            }
        }

        static void Exercicio3()
        {
            int codigo;
            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;

            do
            {
                Console.Write("\nDigite o código do combustivel abastecido: 1-Álcool 2-Gasolina 3-Diesel ou 4 Para Encerrar: ");
                codigo = int.Parse(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        contAlcool++;
                        break;

                    case 2:
                        contGasolina++;
                        break;

                    case 3:
                        contDiesel++;
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("\nCÓDIGO INVALIDO");
                        break;
                }
            } while (codigo != 4);

            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina}");
            Console.WriteLine($"Diesel: {contDiesel}");
        }
    }
}
