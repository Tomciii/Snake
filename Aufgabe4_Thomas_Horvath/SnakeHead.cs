//-----------------------------------------------------------------------
// <copyright file="SnakeHead.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the SnakeHead class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The snakehead class.
    /// </summary>
    public class SnakeHead : GameObject
    {
        /// <summary>
        /// The head symbol of the SnakeHead.
        /// </summary>
        private char symbol;

        /// <summary>
        /// An instance of Random for this class.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Initializes a new instance of the SnakeHead class.
        /// </summary>
        public SnakeHead()
        {
            this.symbol = 'X';
            this.XCoordinate = this.random.Next(Console.WindowWidth - 10);
            this.YCoordinate = this.random.Next(Console.WindowHeight - 10);
        }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>The value of symbol.</value>>
        public new char Symbol
        {
            get
            {
                return this.symbol;
            }

            set
            {
                this.symbol = value;
            }
        }

        /// <summary>
        /// Renders this instance of this class.
        /// </summary>
        /// <param name="renderer">Uses a renderer as input.</param>
        public override void Draw(IRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
