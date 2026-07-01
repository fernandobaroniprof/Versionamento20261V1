// ===== SQUAD B =====
public static class Capitulo2
{
    int escolha;
    
    public static void FunçãoTeste2()
    {
        Console.WriteLine("Qual seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("");
        escolha = int.Parse(Console.ReadLine());


        switch (escolha)
        {
          case "1":

           Console.WriteLine("");
           Console.WriteLine("");
          break;

          case "2":

           Console.WriteLine("");
           Console.WriteLine("");
          break;          

          default:

           Console.WriteLine("");
           escolha = int.Parse(Console.ReadLine());
          break;


        }
    }
}