using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            const double pi = 3.14159265358979323846264338327650;

            //declaração de variável e attribuição de valor na variável
            double raio = 10;
            double area;

            Console.WriteLine("Calculo da área de um circulo \n");
            Console.WriteLine("Fórmula: area = pi * raio * raio \n");

            //Math.Pow: exponenciação
            area = pi * Math.Pow(raio, 2); //sem usar o método Pow seria: area = pi * area * area;

            Console.WriteLine("Área = {0}", area);    //exibe resultado sem formatação de casas decimais
            Console.WriteLine("Área = {0:N}", area);  //exibe resultado com formatação de duas casas decimais
            Console.WriteLine("Área = {0:N5}", area); //exibe resultado com formatação de cinco casas decimais

            Console.ReadKey();  
        }
    }
}
