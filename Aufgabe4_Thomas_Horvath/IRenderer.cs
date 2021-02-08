//-----------------------------------------------------------------------
// <copyright file="IRenderer.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the IRenderer class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The IRenderer interface.
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// Renders a snakehead instance.
        /// </summary>
        /// <param name="snakeHead">The instance as input.</param>
        void Render(SnakeHead snakeHead);

        /// <summary>
        /// Renders a snakehead instance.
        /// </summary>
        /// <param name="snakeHead">The instance as input.</param>
        void Render(SnakeBody snakeHead);

        /// <summary>
        /// Renders a snakehead instance.
        /// </summary>
        /// <param name="snakeHead">The instance as input.</param>
        void Render(Remover snakeHead);

        /// <summary>
        /// Renders an Apple instance.
        /// </summary>
        /// <param name="apple">An apple instance as input.</param>
        void Render(Apple apple);

        /// <summary>
        /// Renders all elements.
        /// </summary>
        /// <param name="renderables">Takes a list as input.</param>
        void RenderAll(List<GameObject> renderables);
    }
}
