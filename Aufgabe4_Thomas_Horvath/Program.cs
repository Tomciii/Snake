//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the program class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main method that starts the app.
        /// </summary>
        /// <param name="args">Command Line Arguments.</param>
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();
        }
    }
}
