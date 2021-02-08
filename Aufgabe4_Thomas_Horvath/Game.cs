//-----------------------------------------------------------------------
// <copyright file="Game.cs" company="FH WN">
//     Copyright (c) Thomas Horvath. All rights reserved.
// </copyright>
// <summary>This file contains the Game class.</summary>
//-----------------------------------------------------------------------
namespace Aufgabe4_Thomas_Horvath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The game class.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Instance of the renderer class.
        /// </summary>
       private Renderer renderer = new Renderer();

        /// <summary>
        /// Instance of the spawn class.
        /// </summary>
        private GameObjectSpawner spawner = new GameObjectSpawner();

        /// <summary>
        /// A list containing all apples.
        /// </summary>
       private List<GameObject> apples = new List<GameObject>();

        /// <summary>
        /// The list containing all snake parts.
        /// </summary>
       private List<GameObject> snake = new List<GameObject>();

        /// <summary>
        /// A list containing all removers.
        /// </summary>
       private List<GameObject> removers = new List<GameObject>();

        /// <summary>
        /// A boolean that checks if an apple exists.
        /// </summary>
        private bool appleExists;

        /// <summary>
        /// A boolean that checks if a remover exists.
        /// </summary>
        private bool removerExists = false;

        /// <summary>
        /// A boolean that checks if the snake has eaten an apple.
        /// </summary>
        private bool snakeAppleCollisionDetected = false;

        /// <summary>
        /// A boolean that checks if the snake has eaten a remover.
        /// </summary>
        private bool snakeRemoverCollisionDetected;

        /// <summary>
        /// A boolean that checks if the snake has eaten itself.
        /// </summary>
        private bool snakeBodyCollisionDetected;

        /// <summary>
        /// The input used for the arrow keys.
        /// </summary>
        private ConsoleKey input;

        /// <summary>
        /// Initializes a new instance of the Game class.
        /// </summary>
        public Game()
        {
            this.snake.Add(new SnakeHead());
            this.appleExists = this.spawner.SpawnApple(this.apples);
        }

        /// <summary>
        /// Runs the game.
        /// </summary>
        public void Run()
        {
            do
            {
                try
                {
                    //// Checks if the snake has eatin itself.
                    this.snakeBodyCollisionDetected = this.spawner.BodyCollision(this.snake);

                    if (this.snakeBodyCollisionDetected == true)
                    {
                        Environment.Exit(0);
                    }

                    //// Checks if an apple needs to be spawned.
                    if (this.appleExists == false)
                    {
                        this.appleExists = this.spawner.SpawnApple(this.apples);
                    }

                    //// Checks if a remover needs to be spawned.
                    if (this.removerExists == false)
                    {
                        this.removerExists = this.spawner.SpawnRemover(this.removers);
                    }

                    //// Renders the game and moves the moving parts.  
                    this.renderer.RenderAll(this.snake);
                    this.MoveSnakeBodyParts(this.snake);
                    this.renderer.RenderAll(this.removers);

                    //// Checks if an apple or remover was eaten.
                    this.snakeAppleCollisionDetected = this.spawner.SnakeEatsAppleCheck(this.apples, this.snake);
                    this.snakeRemoverCollisionDetected = this.spawner.SnakeEatsRemoverCheck(this.removers, this.snake);

                    if (this.snakeAppleCollisionDetected == true)
                    {
                        this.apples.Remove(this.apples[0]);
                        this.appleExists = false;
                        this.spawner.SpawnBodySegment(this.snake);
                    }

                    if (this.snakeRemoverCollisionDetected == true)
                    {
                        this.removers.Remove(this.removers[0]);
                        this.removerExists = false;
                    }

                    this.renderer.RenderAll(this.apples);
                }
                catch
                {
                }

                //// Check if snake has left the console screen.
                if (this.snake[0].YCoordinate > Console.WindowHeight - 1 || this.snake[0].YCoordinate < 0 || this.snake[0].XCoordinate > Console.WindowWidth - 1 || this.snake[0].XCoordinate < 0)
                {
                    Environment.Exit(0);
                }

                this.input = Console.ReadKey().Key;
             
                this.MoveSnakeHead();

             
                Console.Clear();
            }
            while (!this.input.Equals(ConsoleKey.Escape));
        }

        /// <summary>
        /// Moves the head of the snake.
        /// </summary>
        private void MoveSnakeHead()
        {
            if (this.input.Equals(ConsoleKey.UpArrow))
            {
                this.snake[0].YCoordinate--;
            }
            else if (this.input.Equals(ConsoleKey.DownArrow))
            {
                this.snake[0].YCoordinate++;
            }
            else if (this.input.Equals(ConsoleKey.LeftArrow))
            {
                this.snake[0].XCoordinate--;
            }
            else if (this.input.Equals(ConsoleKey.RightArrow))
            {
                this.snake[0].XCoordinate++;
            }
            else if (this.input.Equals(ConsoleKey.Escape))
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Moves all items in the GameObject list except for the 1st one at index 0.
        /// </summary>
        /// <param name="movables">The movables it takes as input.</param>
        private void MoveSnakeBodyParts(List<GameObject> movables)
        {
            if (movables.Count > 1)
            {
                for (int i = movables.Count - 1; i > 0; i--)
                {
                    if (i != 0)
                    {
                        movables[i].XCoordinate = movables[i - 1].XCoordinate;
                        movables[i].YCoordinate = movables[i - 1].YCoordinate;
                    }
                }
            }
        }
    }
}
