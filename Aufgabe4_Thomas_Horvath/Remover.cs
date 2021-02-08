//-----------------------------------------------------------------------
// <copyright file="Remover.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Remover class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The Remover class.
    /// </summary>
    public class Remover : GameObject
    {
        /// <summary>
        /// An instance of the Random class. 
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// The symbol of the SnakeHead.
        /// </summary>
        private char symbol;

        /// <summary>
        /// The x Coordinate.
        /// </summary>
        private int xCoordinate;

        /// <summary>
        /// The y coordinate.
        /// </summary>
        private int yCoordinate;

        /// <summary>
        /// Initializes a new instance of the Remover class.
        /// </summary>
        public Remover()
        {
            this.symbol = 'Ω';
            this.xCoordinate = this.random.Next(Console.WindowWidth - 3);
            this.yCoordinate = this.random.Next(Console.WindowHeight - 3);
        }

        /// <summary>
        /// Gets the value of x.
        /// </summary>
        /// <value>The value of x.</value>
        public override int XCoordinate
        {
            get
            {
                return this.xCoordinate;
            }
        }

        /// <summary>
        /// Gets the value of y.
        /// </summary>
        /// <value>The value of y.</value>
        public override int YCoordinate
        {
            get
            {
                return this.yCoordinate;
            }
        }

        /// <summary>
        /// Gets the value of symbol.
        /// </summary>
        /// <value>The value of symbol.</value>
        public new char Symbol
        {
            get
            {
                return this.symbol;
            }
        }

        /// <summary>
        /// Draw method for the apple.
        /// </summary>
        /// <param name="renderer">Takes a IRenderer as input.</param>
        public override void Draw(IRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
