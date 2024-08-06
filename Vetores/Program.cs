namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosLocatário[] vetDadosAluguel = new DadosLocatário[10];

            int qtdAlugueis = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAlugueis; i++)
            {
                Console.Write("Digite o seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o seu e-mail: ");
                string email = Console.ReadLine();

                Console.Write("Digite o número do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                vetDadosAluguel[numeroQuarto] = new DadosLocatário {NomeLocatario = nome, EmailLocatario = email, NumeroQuarto = numeroQuarto };

                Console.WriteLine();
            }

            for (int i = 0; i < vetDadosAluguel.Length; i++)
            {
                if (vetDadosAluguel[i] != null)
                {
                    Console.WriteLine(vetDadosAluguel[i].NumeroQuarto + ": " + vetDadosAluguel[i].NomeLocatario + ", " + vetDadosAluguel[i].EmailLocatario);
                }
            }


        }
    }
}