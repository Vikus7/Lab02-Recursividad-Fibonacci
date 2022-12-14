using System.Diagnostics;
namespace ConsoleApp;
class Program
{
    static void Main(string[] args){
        int numeroDeTerminos;
        
        do{
            Console.WriteLine("Introduzca el número de términos: ");
            numeroDeTerminos = Convert.ToInt32(Console.ReadLine());
        }while (numeroDeTerminos <= 1);
        
        
        Console.WriteLine("Serie de Fibonacci Recursivo: ");
        var cronometro = Stopwatch.StartNew();
        for(int i = 0; i < numeroDeTerminos; i++){
            Console.Write(fibonacciRecursivo(i) + " ");
        }
        cronometro.Stop();
        long tiempo = cronometro.ElapsedMilliseconds;
        Console.WriteLine("Tiempo transcurrido: "+ tiempo +" ms");

        //Console.WriteLine();
        cronometro.Restart();
        Console.WriteLine("Serie de Fibonacci Iterativo: ");
        fibonacciIterativo(numeroDeTerminos);
        cronometro.Stop();
        tiempo = cronometro.ElapsedMilliseconds;
        Console.WriteLine("Tiempo transcurrido: "+ tiempo +" ms");
    }
    static long fibonacciRecursivo(int limite){
        if(limite < 2) return limite;
        else return fibonacciRecursivo(limite-2)+fibonacciRecursivo(limite-1);
    }

    static void fibonacciIterativo(int limite){
        long anterior1, anterior2;
        anterior1 = anterior2 = 1;
        Console.Write("0 1 1 ");
        
        for(int i = 1; i < limite-2; i++){
            long actual = anterior1 + anterior2;
            Console.Write(actual + " ");
            anterior2 = anterior1;
            anterior1 = actual;
        }
    }
}
