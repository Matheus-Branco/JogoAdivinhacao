using System.Security.AccessControl;

namespace JogoAdivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chute = 0;
            int tentativas = 0;

            for (int x = 0; x <= 40; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("*  ");
            Console.WriteLine("Bem-Vindo ao jogo da adivinhação!!!  ");
            Console.WriteLine("*");
            for (int x = 0; x <= 40; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine("Escolha o nível de dificuldade: \n(1)Fácil  (2)Médio  (3)Difícil");
            int dificuldade = Convert.ToInt32(Console.ReadLine());

            switch (dificuldade)
            {
                case 1:
                    Random random = new Random();
                    int numeroAleatorio = random.Next(0, 51); 
                    tentativas = 20;
                    Console.WriteLine($"REGRAS DO JOGO:\nVocê tem {tentativas} tentativas e o número aleatório está entre 0 e 50. Boa sorte.");

                    for (int i = 0; i < tentativas; i++)
                    {
                        if (i >= tentativas)
                        {
                            Console.WriteLine("Game Over");
                            break;
                        }

                        Console.WriteLine($"Qual é o seu {i + 1}° chute?");
                        chute = Convert.ToInt32(Console.ReadLine());

                        if (chute == numeroAleatorio)
                        {
                            Console.WriteLine($"Parabéns, você acertou o número na dificuldade {dificuldade}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Chute incorreto. Tente novamente.");
                        }
                    }

                    int pontuacao = Math.Abs(chute - numeroAleatorio) / 2;
                    Console.WriteLine($"Sua pontuação é: {pontuacao}");
                    break;
            }

            switch (dificuldade)
            {
                case 2:
                    Random random = new Random();
                    int numeroAleatorio = random.Next(0, 76);
                    tentativas = 15;
                    Console.WriteLine($"REGRAS DO JOGO:\nVocê tem {tentativas} tentativas e o número aleatório está entre 0 e 50. Boa sorte.");

                    for (int i = 0; i < tentativas; i++)
                    {
                        if (i >= tentativas)
                        {
                            Console.WriteLine("Game Over");
                            break;
                        }

                        Console.WriteLine($"Qual é o seu {i + 1}° chute?");
                        chute = Convert.ToInt32(Console.ReadLine());

                        if (chute == numeroAleatorio)
                        {
                            Console.WriteLine($"Parabéns, você acertou o número na dificuldade {dificuldade}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Chute incorreto. Tente novamente.");
                        }
                    }

                    int pontuacao = Math.Abs(chute - numeroAleatorio) / 2;
                    Console.WriteLine($"Sua pontuação é: {pontuacao}");
                    break;
            }
            switch (dificuldade)
            {
                case 3:
                    Random random = new Random();
                    int numeroAleatorio = random.Next(0, 101);
                    tentativas = 10;
                    Console.WriteLine($"REGRAS DO JOGO:\nVocê tem {tentativas} tentativas e o número aleatório está entre 0 e 50. Boa sorte.");

                    for (int i = 0; i < tentativas; i++)
                    {
                        if (i >= tentativas)
                        {
                            Console.WriteLine("Game Over");
                            break;
                        }

                        Console.WriteLine($"Qual é o seu {i + 1}° chute?");
                        chute = Convert.ToInt32(Console.ReadLine());

                        if (chute == numeroAleatorio)
                        {
                            Console.WriteLine($"Parabéns, você acertou o número na dificuldade {dificuldade}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Chute incorreto. Tente novamente.");
                        }
                    }

                    int pontuacao = Math.Abs(chute - numeroAleatorio) / 2;
                    Console.WriteLine($"Sua pontuação é: {pontuacao}");
                    break;
                default:
                    while (dificuldade != 1 || dificuldade != 2 || dificuldade != 3) 
                    {
                        Console.WriteLine("Dificuldade inválida, tente novamente:");
                    }
                    break;
            }
        }
    }
}
