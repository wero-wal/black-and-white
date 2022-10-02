using System;
using System.Collections.Generic;
using System.Text;

namespace BW
{
    internal class Texture
    {
        // ----- Properties -----
        public ConsoleColor ForegroundColor => _foregroundColor;
        public ConsoleColor BackgroundColor => _backgroundColor;
        public string[,] Pattern => _pattern;
        internal Point Size => _size;

        // ----- Fields -----
        private readonly ConsoleColor _foregroundColor;
        private readonly ConsoleColor _backgroundColor;
        private readonly Point _size;
        private readonly string[,] _pattern;

        // ----- Constructors -----
        public Texture()
        {

        }
        public Texture(string[,] pattern, ConsoleColor backgroundColour, ConsoleColor foregoundColour = ConsoleColor.Gray)
        {
            _pattern = pattern;
            _size = new Point(pattern.GetLength(0), pattern.GetLength(1));
            _backgroundColor = backgroundColour;
            _foregroundColor = foregoundColour;
        }

        // ----- Methods -----
        public void Draw(Point position)
        {
            Console.ForegroundColor = _foregroundColor;
            Console.BackgroundColor = _backgroundColor;
            for (int y = 0; y < _size.Y; y++)
            {
                Console.CursorTop = position.Y + _size.Y;
                for (int x = 0; x < _size.X; x++)
                {
                    Console.CursorLeft = position.X + _size.X;
                    Console.Write(_pattern[x, y]);
                }
            }
        }
    }
}
