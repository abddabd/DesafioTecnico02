using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int seuDinheiro = 0;
        int dinheiroInsti = 100;
        int temp;
        int alcance;
        int nota = 70;
        while (true)
        {
            temp = 0;
            Console.WriteLine("Escolha uma das funções abaixo:");
            Console.WriteLine("1: Informações contextuais e conta\r\n2: Trabalhar \r\n3: Doar à Jovens de rua \r\n4: Alcance da instituição \r\n5: participar na loteria \r\n6: Estudar (R$30 para os livros)");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"O seu nome é Akira, um estudante do ensino médio. Você possue R${seuDinheiro}. Você faz parte ong Jovens de Rua");
                    Console.WriteLine("Essa instituição abriga jovens abandonados em situação de rua\r\n");
                    break;

                case 2:
                    Console.WriteLine("Você trabalhou por 28 horas no mercadinho, ganhando R$400\r\n");
                    seuDinheiro += 100;
                    break;

                case 3:
                    Console.WriteLine($"Selecione a quantidade a ser doada (Você possue R${seuDinheiro}): ");
                    temp = int.Parse(Console.ReadLine());
                    if (temp <= 0)
                    {
                        Console.WriteLine("Quantidade inválida\r\n");
                    } else if (temp > seuDinheiro)
                    {
                        Console.WriteLine("Você não possue essa quantidade de dinheiro\r\n");
                    } else
                    {
                        dinheiroInsti += temp;
                        Console.WriteLine($"Doou {temp} à instituição Jovens na rua, agora eles possuem R${dinheiroInsti}\r\n");
                    }
                    break;

                case 4:
                    alcance = dinheiroInsti / 25;
                    Console.WriteLine($"Com R${dinheiroInsti}, Jovens na rua é capaz de abrigar um total de {alcance} jovens\r\n");
                    break;

                case 5:
                    int loteria = rand.Next(1, 500);
                    Console.WriteLine("Comprar quantos tickets? (1 ticket = R$10):");
                    int tentativas = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= tentativas; i++)
                    {
                        Console.WriteLine("Insira um número de 1 a 500:");
                        int chute = int.Parse(Console.ReadLine());
                        if (chute == loteria)
                        {
                            Console.WriteLine("Ganhou R$100.000!");
                            seuDinheiro += 100000 - 2;
                            break;
                        } else
                        {
                            Console.WriteLine("Não ganhou");
                            seuDinheiro -= 2;
                        }
                    } 
                    break;

                case 6:
                    int escolha = 1;
                    do
                    {
                        nota += 3;
                        Console.WriteLine($"Você passou algumas horas estudando. Agora, você se considera um aluno nota {nota}");
                        Console.WriteLine($"Para os livros didáticos, você pagou R$30, assim tendo R${seuDinheiro} na conta");
                        seuDinheiro -= 30;
                        Console.WriteLine("Comprar mais livros e estudar ainda mais? (1: Sim, 0: Não)");
                        escolha = int.Parse(Console.ReadLine());
                    } while (escolha == 1);
                    break;
            }
        }
    }
}