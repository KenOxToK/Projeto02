namespace AgendasSalas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //como a gente vai transformar em API, não sei se vale a pena fazer essa interface
            //pode só fazer um teste simples, sem pedir entrada do usuário
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("               Bem vindo(a) - Aluguel de sala              ");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("");
            ;
            Console.WriteLine("                           ♦Menu♦                          ");

            Console.WriteLine("-Dia de Semanas por Segunda-Feira a Domingo");
            Console.WriteLine("-Horario das 9h a 12 ou 13h a 16h");           
            Console.WriteLine("-Sala com Seguro por 30$");
            Console.WriteLine("-Sala com Estacionamento por 10$");
            Console.WriteLine("-Sala com Ar Condicionado por 20$");
            Console.WriteLine("-Sala com Banheiro por 15$");
            Console.WriteLine("-Sala com Janela por 10$");
            Console.WriteLine("-Sala de Voltagem: 110V ou 220V");
            Console.WriteLine("-Temos equipamento em Ar-Condicionado,Mesas de reunião,Cadeiras,Televisão,Iluminação,tapetes e mais.");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("");

            Console.WriteLine("Deseja em cadastrar este aluguel de sala?(Sim ou Não)");
            string deseja = (Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Qual é o seu nome?");
            string nome = (Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Qual é o seu email?");
            string email = (Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Qual é o seu telefone?");
            int telefone = int.Parse(Console.ReadLine());




        }
    }
}