public static class Capitulo1
{
    public static void FunçãoTeste1()
    {
        Console.WriteLine(
        """

                CAPÍTULO 1 - Chegando ao Curso

        """);

        Console.WriteLine("\nSeu despertador toca às 5h40.");

        Console.WriteLine("1 - Levantar");
        Console.WriteLine("2 - Dormir mais um pouco");

        string escolhalevantar = Console.ReadLine();

        if (escolhalevantar == "1")
        {
            Variáveis.Energia = Variáveis.Energia + 5;
            Console.WriteLine("\nVocê levanta rapidamente e começa a se arrumar.");
            Console.WriteLine(
            """
            Você toma café da mnhã e ganha 5 de energia.
     
            """);
        }else
        {
            Console.WriteLine(
"""
                   __.                         
         Você descansa um pouco mais mas agora está atrasado!            
""");
            Variáveis.Energia = Variáveis.Energia + 10;
        }

        Console.WriteLine("\nO que você faz?");
        Console.WriteLine("1 - Corre para garantir lugar.");
        Console.WriteLine("2 - Caminha normalmente.");
        Console.WriteLine("3 - Espera o próximo ônibus.");

        string escolhaOnibus = Console.ReadLine();

        switch (escolhaOnibus)
        {
            case "1":
                Console.WriteLine("\nVocê corre e consegue embarcar.");
                Console.WriteLine("Mas chega cansado à escola.");

                Variáveis.Energia -= 15;
                break;

            case "2":
                Console.WriteLine("\nVocê embarca tranquilamente.");
                Console.WriteLine("A viagem segue sem problemas.");

                Variáveis.Energia -= 5;
                break;

            case "3":
                Console.WriteLine("\nVocê decide esperar o próximo ônibus.");
                Console.WriteLine("Chega mais descansado, porém atrasado.");

                Variáveis.Energia += 5;
                Variáveis.Aprendizagem -= 5;
                break;

            default:
                Console.WriteLine("\nIndecisão também é uma escolha.");
                Console.WriteLine("Você perde o ônibus e chega atrasado.");

                Variáveis.Aprendizagem -= 10;
                break;
        }
    }
}
