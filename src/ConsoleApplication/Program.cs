//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        public static void Main()
        {
            /*for (int i = 1; i <= 100;i++){
                var j = new Train(i.ToString()); //actividad 7
                Console.WriteLine(Train.GetInstancias());
            }

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London"); //actividad 8
            var t3 = new Train("Runaway Train");*/
            Train t1 = new Train("Juan");
            Train t2 = new Train("Juan");
            Console.WriteLine(t1.Equals(t2));  
        }
        
    }
}