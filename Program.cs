using System;

namespace CalculoDeAreaConstruida
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaTotal;
            double areaConstruida;
            double areaNaoConstruida;
            double resultado;
            double impostoAreaConstruida = 5;
            double impostoAreaNaoConstruida = 3.8;

            try
            {
                Console.WriteLine("\nInforme a area total do terreno");
                areaTotal = ValorMencionado();
                Console.WriteLine("Informe a area total construida");
                areaConstruida = ValorMencionado();
                areaNaoConstruida = areaTotal - areaConstruida;
                resultado = (impostoAreaNaoConstruida * areaNaoConstruida) + (impostoAreaConstruida * areaConstruida);
                Console.WriteLine("O valor a ser pago é: {0}", resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o erro: {0}", ex.Message);
            }
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
        static double ValorMencionado()
        {
            try
            {
                var valor = Console.ReadLine();
                return Convert.ToDouble(valor);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor informado esta incorreto, informe novamente:");
                return ValorMencionado();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
