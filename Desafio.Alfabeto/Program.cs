namespace Desafio.Alfabeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio: Usuário digita um número de 1 a 26, e retorna um array com as letras do alfabeto
            // Ex: digito 2, retorna uma lista com a, b

            Console.WriteLine("Digite um número de 1 a 26:");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 1 || numero <= 26)
            {
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(new List<char> { (char)('a' + i) }[0]);
                }
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

            //Desafio extra: Faça o código em duas linhas e sem usar List

            int numero2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero2 && numero2 >= 1 && numero2 <= 26; i++) Console.WriteLine((char)('a' + i));


        }
    }
}
