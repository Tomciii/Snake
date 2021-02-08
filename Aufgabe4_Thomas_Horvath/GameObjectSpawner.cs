//-----------------------------------------------------------------------
// <copyright file="GameObjectSpawner.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the GameObjectSpawner class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The class that spawns objects.
    /// </summary>
    public class GameObjectSpawner
    {
        /// <summary>
        /// Spawns a new Apple.
        /// </summary>
        /// <param name="objects">Takes a List as input.</param>
        /// <returns>Returns a boolean.</returns>
        public bool SpawnApple(List<GameObject> objects)
        {
            objects.Add(new Apple());
            return true;
        }

        /// <summary>
        /// Checks for BodyCollision.
        /// </summary>
        /// <param name="movables">Takes a list of gameObjects as input.</param>
        /// <returns>Returns true or false.</returns>
        public bool BodyCollision(List<GameObject> movables)
        {
            if (movables.Count > 1)
            {
                for (int i = 0; i < movables.Count; i++)
                {
                    for (int j = 0; j < movables.Count; j++)
                    {
                        if ((i != j) && (movables[i].XCoordinate == movables[j].XCoordinate) && (movables[i].YCoordinate == movables[j].YCoordinate))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the snake ate the remover.
        /// </summary>
        /// <param name="removers">List that contains remover.</param>
        /// <param name="movables">List that contains snake.</param>
        /// <returns>Returns true or false.</returns>
        public bool SnakeEatsRemoverCheck(List<GameObject> removers, List<GameObject> movables)
        {
            if (movables.Count > 1)
            {
                if (removers[0].XCoordinate == movables[movables.Count - 1].XCoordinate && removers[0].YCoordinate == movables[movables.Count - 1].YCoordinate)
                {
                    movables.RemoveAt(movables.Count - 1);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Adds a remover to a list.
        /// </summary>
        /// <param name="objects">Takes a list as parameter.</param>
        /// <returns>Returns true.</returns>
        public bool SpawnRemover(List<GameObject> objects)
        {
            objects.Add(new Remover());
            return true;
        }

        /// <summary>
        /// Detects if there was a collision.
        /// </summary>
        /// <param name="apples">Takes the object as list.</param>
        /// <param name="movables">Takes the movables as input.</param>
        /// <returns>Returns a value.</returns>
        public bool SnakeEatsAppleCheck(List<GameObject> apples, List<GameObject> movables)
        {
            if (apples[0].XCoordinate == movables[0].XCoordinate && apples[0].YCoordinate == movables[0].YCoordinate)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Adds a body to the snake list.
        /// </summary>
        /// <param name="movables">The list as input.</param>
        public void SpawnBodySegment(List<GameObject> movables)
        {
            movables.Add(new SnakeBody());
        }
    }
}
