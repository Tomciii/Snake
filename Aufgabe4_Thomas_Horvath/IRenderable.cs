//-----------------------------------------------------------------------
// <copyright file="IRenderable.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the IRenderableClass.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface.
    /// </summary>
    public interface IRenderable
    {
        /// <summary>
        /// The draw method that draws objects.
        /// </summary>
        /// <param name="renderer">Takes a renderer as input.</param>
        void Draw(IRenderer renderer);
    }
}
