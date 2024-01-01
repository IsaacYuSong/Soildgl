using System;
using System.Threading;

namespace SolidGL
{
    public class SolidGL
    {
        private bool isRendered = false;
        public const int DefaultWindowHeight = 50;
        public const int DefaultWindowWidth = 50;

        public int WindowHeight { get; set; }
        public int WindowWidth { get; set; }
        private char[,] buffer;

        public SolidGL(int windowHeight = DefaultWindowHeight, int windowWidth = DefaultWindowWidth)
        {
            WindowHeight = windowHeight;
            WindowWidth = windowWidth;
            buffer = new char[WindowWidth, WindowHeight];
        }

        public void sdError(string msg)
        {
            Console.Error.WriteLine("ERROR: " + msg);
            Environment.Exit(1);
        }

        public void sdDrawLine(int x1, int x2, int y1, int y2, char character)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = (x1 < x2) ? 1 : -1;
            int sy = (y1 < y2) ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                sdDraw(x1, y1, character);

                if (x1 == x2 && y1 == y2)
                    break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x1 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y1 += sy;
                }
            }
        }

        public void sdDraw(int x, int y, char character)
        {
            if (x >= 0 && x < WindowWidth && y >= 0 && y < WindowHeight)
                buffer[x, y] = character;
        }

        public void sdClear()
        {
            Console.Clear();
            buffer = new char[WindowWidth, WindowHeight];
        }

        public char sdGetKey(char key)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                return keyInfo.KeyChar;
            }
            else
            {
                return '\0';
            }
        }

        public void sdRender()
        {
            if (!isRendered)
            {
                Console.Clear();
            }

            for (int y = 0; y < WindowHeight; y++)
            {
                for (int x = 0; x < WindowWidth; x++)
                {
                    Console.Write(buffer[x, y]);
                }
            }

            isRendered = true;
        }

        public void sdClearRenderFlag()
        {
            isRendered = false;
        }

        public void sdSetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }


    }
}
