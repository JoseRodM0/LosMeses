namespace LosMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero");
            string dato = Console.ReadLine();

            int Mes = 0;

            bool SePudoConvertir = false;
            SePudoConvertir = int.TryParse(dato, out Mes);
            if (SePudoConvertir)
            {
                switch (Mes)
                {
                    case 1:
                        Console.WriteLine("Enero");
                        break;

                    case 2:
                        Console.WriteLine("Febrero");
                        break;

                    case 3:
                        Console.WriteLine("Marzo");
                        break;

                    case 4:
                        Console.WriteLine("Abril");
                        break;

                    case 5:
                        Console.WriteLine("Mayo");
                        break;

                    case 6:
                        Console.WriteLine("Junio");
                        break;

                    case 7:
                        Console.WriteLine("Julio");
                        break;

                    case 8:
                        Console.WriteLine("Agosto");
                        break;

                    case 9:
                        Console.WriteLine("Septiembre");
                        break;

                    case 10:
                        Console.WriteLine("Octubre");
                        break;

                    case 11:
                        Console.WriteLine("Noviembre");
                        break;

                    case 12:
                        Console.WriteLine("Diciembre");
                        break;

                    default:
                        Console.WriteLine($"Dato incorrecto (switch): {dato}");
                        break;

                }
            }
            else
            {
                Console.WriteLine($"El dato introducido es incorrecto: {dato}");
            }

        }
    }
}
