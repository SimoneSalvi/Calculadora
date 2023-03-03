internal class Program
{
    private static void Main(string[] args)
    {
        int n1, n2;

        Console.WriteLine("Informe o primeiro número:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo número:");
        n2 = int.Parse(Console.ReadLine());

        //Soma

        Console.WriteLine("A soma é: " + (n1+n2));
        Console.WriteLine("A subtração é: " + (n1-n2));
        Console.WriteLine("O produto é: " + (n1 * n2));
        if(n2 == 0)
        {
            Console.WriteLine("Não existe divisão por zero.");
         }
        else
            Console.WriteLine("O quociente é:" + (n1 / n2));

    }
}