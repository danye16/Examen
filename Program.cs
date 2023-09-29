namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Examen _examen = new Examen();

            Console.WriteLine("Escriba dos numeros");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());


            _examen.Intervalo(numero1, numero2);
        }
    }
}