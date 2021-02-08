//-----------------------------------------------------------------------
// <copyright file="GameObject.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the GameObject class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The game object class.
    /// </summary>
    public abstract class GameObject : IRenderable
    {
        /// <summary>
        /// The x coordinate.
        /// </summary>
        private int xCoordinate;

        /// <summary>
        /// The y coordinate.
        /// </summary>
        private int yCoordinate;

        /// <summary>
        /// The symbol.
        /// </summary>
        private char symbol;

        /// <summary>
        /// Gets or sets the value of the xCoordinate.
        /// </summary>
        /// <value>The Value of xCoordinate.</value>
        public virtual int XCoordinate
        {
            get
            {
                return this.xCoordinate;
            }

            set
            {
                this.xCoordinate = value;
            }
        }

        /// <summary>
        /// Gets or sets the value of the YCoordinate.
        /// </summary>
        /// <value>The Value of yCoordinate.</value>
        public virtual int YCoordinate
        {
            get
            {
                return this.yCoordinate;
            }

            set
            {
                this.yCoordinate = value;
            }
        }

        /// <summary>
        /// Gets or sets the value of the Symbol.
        /// </summary>
        /// <value>The Value of symbol.</value>
        public char Symbol
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
        /// The draw method.
        /// </summary>
        /// <param name="renderer">Takes a renderer as input.</param>
        public abstract void Draw(IRenderer renderer);
    }
}
