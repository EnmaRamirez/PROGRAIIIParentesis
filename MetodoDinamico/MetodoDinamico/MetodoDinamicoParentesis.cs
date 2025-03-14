using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoDinamico
{
    public class MetodoDinamicoParentesis
    {
        static void Main()
        {
            Console.Title = "Verificador de parentesis Balanciados";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== Verificador de Expresion Balanciada ===\n");
            Console.ResetColor();

            while (true)
            {
                Console.Write("Ingesa una expresión (o escriba 'salir' para terminar):  ");
                string expresion = Console.ReadLine();

                if (expresion.ToLower() =="salir")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nGracias por usar el verificador. ¡Hasta pronto!");
                    Console.ResetColor();
                    break;
                }

                bool balanceado = Balanceado(expresion);
                if (balanceado)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("✅ La expresion está balanceada. \n");
                }
                else
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" ❌ La expresion NO está banaceada. \n");

                }
                Console.ResetColor();
            }
        }
        static bool Balanceado(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(')
                {
                    pila.Push(c);
                }
                else if (c == ')')
                {
                    if (pila.Count == 0)
                    {
                        return false;// Existe un cierre sin apertura previa
                    }
                    pila.Pop();
                }
            }
            return pila.Count == 0;
        }
    }
}
