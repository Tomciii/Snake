//-----------------------------------------------------------------------
// <copyright file="Renderer.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Renderer class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The Renderer Class.
    /// </summary>
    public class Renderer : IRenderer
    {
        /// <summary>
        /// Renders a snakehead.
        /// </summary>
        /// <param name="snakeHead">The class it is supposed to render as input.</param>
        public void Render(SnakeHead snakeHead)
        {
            Console.SetCursorPosition(snakeHead.XCoordinate, snakeHead.YCoordinate);
            Console.Write(snakeHead.Symbol);
        }

        /// <summary>
        /// Renders an apple.
        /// </summary>
        /// <param name="apple">The class it is supposed to render as input.</param>
        public void Render(Apple apple)
        {
            Console.SetCursorPosition(apple.XCoordinate, apple.YCoordinate);
            Console.Write(apple.Symbol);
        }

        /// <summary>
        /// Renders a SnakeBody.
        /// </summary>
        /// <param name="snakeBody">The class it is supposed to render as input.</param>
        public void Render(SnakeBody snakeBody)
        {
            Console.SetCursorPosition(snakeBody.XCoordinate, snakeBody.YCoordinate);
            Console.Write(snakeBody.Symbol);
        }

        /// <summary>
        /// Renders a Remover.
        /// </summary>
        /// <param name="remover">The class it is supposed to render as input.</param>
        public void Render(Remover remover)
        {
            Console.SetCursorPosition(remover.XCoordinate, remover.YCoordinate);
            Console.WriteLine(remover.Symbol);
        }

        /// <summary>
        /// Renders all items in a GameObjects list.
        /// </summary>
        /// <param name="renderables">Takes a list as input.</param>
        public void RenderAll(List<GameObject> renderables)
        {
            if (renderables.Count > 1)
            {
                for (int i = 0; i < renderables.Count; i++)
                {
                    renderables[i].Draw(this);
                }
            }

            renderables[0].Draw(this);
        }
    }
}
