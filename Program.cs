namespace Examen_OAEA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hola buen dia Ingrese su Curp");
            

            int year;
            string Dia;
            string Mes;
            */

            Console.WriteLine("Hola buen dia Ingresa un numero de inicio ");
            int inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora ingresa el nuemero del final");
            int final = int.Parse(Console.ReadLine());




            if (inicio > final)
            {

                Console.WriteLine("Tienes que ingresar un nuemero positivo");


            }

            else
            {
                Console.WriteLine("Los numeros en ese intevalo son");
                for (int numero = inicio; numero <= final; numero++)

                {
                    Console.WriteLine(numero);
                }

            }









        }
    }
}