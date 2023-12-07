using System;
using System.Threading;

namespace SoildGl
{
    public class SoildglDoubleBuffer
    {
        const int windowHeight = 10;
        const int windowWidth = 10;
        static char[][] frontBuffer = new char[windowHeight][];
        static char[][] backBuffer = new char[windowHeight][];
        public SoildglDoubleBuffer()
        {
            for (int i = 0; i < windowHeight; i++)
            {
                frontBuffer[i] = new char[windowWidth];
                backBuffer[i] = new char[windowWidth];
            }
        }

        public void sdError(string msg)
        {
            Console.Error.WriteLine("ERROR: " + msg);
            Environment.Exit(1);
        }

        public void sdDrawBack(int x, int y, char character)
        {
            if (x >= 0 && x < windowWidth && y >= 0 && y < windowHeight)
            {
                backBuffer[y][x] = character;
            }
        }

        public void sdDrawLine(int x1, int x2, int y1, int y2, char character)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = (x1 < x2) ? 1 : -1;
            int sy = (y1 < y2) ? 1 : -1;
            int err = dx - dy;

            while (x1 != x2 || y1 != y2)
            {
                sdDrawBack(x1, y1, character);
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

        public void sdClearBack()
        {
            for (int j = 0; j < windowHeight; j++)
            {
                for (int k = 0; k < windowWidth; k++)
                {
                    backBuffer[j][k] = ' ';
                }
            }
        }

        public void sdClearFront()
        {
            for (int j = 0; j < windowHeight; j++)
            {
                for (int k = 0; k < windowWidth; k++)
                {
                    frontBuffer[j][k] = ' ';
                }
            }
        }

        public void sdSwapBuffer()
        {
            for (int y = 0; y < windowHeight; y++)
            {
                for (int x = 0; x < windowWidth; x++)
                {
                    frontBuffer[y][x] = backBuffer[y][x];
                }
            }
        }

        public void sdRenderFront()
        {
            sdClearFront();
            for (int y = 0; y < windowHeight; y++)
            {
                for (int x = 0; x < windowWidth; x++)
                {
                    Console.Write(frontBuffer[y][x]);
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        public void sdRenderBack()
        {
            sdClearBack();
            for (int y = 0; y < windowHeight; y++)
            {
                for (int x = 0; x < windowWidth; x++)
                {
                    Console.Write(backBuffer[y][x]);
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        public void sdDrawFront(int x, int y, char character)
        {
            if (x >= 0 && x < windowWidth && y >= 0 && y < windowHeight)
            {
                frontBuffer[y][x] = character;
            }
        }

        public void sdClear()
        {
            Console.Clear();
        }

    }
}