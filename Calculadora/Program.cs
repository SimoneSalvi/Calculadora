using System.ComponentModel.Design;

internal class Program
{

    private static void Main(string[] args)
    {
        double num1, num2;
        int opcao = 0;

        Console.WriteLine("Informe o primeiro numero");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo numero");
        num2 = double.Parse(Console.ReadLine());

        while (opcao != 5)
        {
            Menu();
            EscolhaOperacao();

        }

        int Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção");
            opcao =  int.Parse(Console.ReadLine());
            return opcao;
 
        }

        void EscolhaOperacao()
        {
            switch (opcao)
            {
                default:
                    Console.WriteLine("Opção inválida");
                    Console.WriteLine("Escolha uma opção");
                    break;

                case 1:
                    soma();
                    Console.ReadLine();
                    break;

                case 2:
                    subtracao();
                    Console.ReadLine();
                    break;

                case 3:
                    multiplicacao();
                    Console.ReadLine();
                    break;

                case 4:
                    divisao();
                    Console.ReadLine();
                    
                    break;

                case 5:
                    Console.WriteLine("Até logo!");
                    Console.ReadLine();
                    break;


            }
        }
 

        void soma()
        {       
            Console.WriteLine("A soma dos numeros é: " + (num1 + num2));
        }

        void subtracao()
        {
            Console.WriteLine("A subtracao dos numeros é: " + (num1 - num2));
        }

        void multiplicacao()
        {
            Console.WriteLine("A multiplicacao dos numeros é: " + (num1 * num2));
        }

        void divisao()
        {
            if(num2 != 0)
            {
                Console.WriteLine("A divisao dos numeros é: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Não existe divisao por zero.");
            }

        }

    }
}