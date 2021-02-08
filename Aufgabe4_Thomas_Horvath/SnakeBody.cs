//-----------------------------------------------------------------------
// <copyright file="SnakeBody.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the SnakeBody class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The SnakeBody class.
    /// </summary>
    public class SnakeBody : GameObject
    {
        /// <summary>
        /// Initializes a new instance of the SnakeBody class.
        /// </summary>
        public SnakeBody()
        {
            this.Symbol = '+';
        }

        /// <summary>
        /// Renders this instance of this class.
        /// </summary>
        /// <param name="renderer">Takes a renderer as input.</param>
        public override void Draw(IRenderer renderer)
        {
            renderer.Render(this);
        }
    }
}
