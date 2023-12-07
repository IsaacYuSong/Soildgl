using System;
using System.Threading;
namespace SoildGl
{
    public class Soildgl
    {
        public int windowHeight = 10;
        public int windowWidth = 10;

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

            while (x1 != x2 || y1 != y2)
            {
                Console.SetCursorPosition(x1, y1);
                Console.Write(character);

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
            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }

        public void sdDrawRectangle(int x, int y, int width, int height, char character)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sdDraw(x + j, y + i, character);
                }
            }
        }

        public void sdFillRectangle(int x, int y, int width, int height, char character)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sdDraw(x + j, y + i, character);
                }
            }
        }

        public void sdDrawCircle(int centerX, int centerY, int radius, char character)
        {
            for (int angle = 0; angle < 360; angle++)
            {
                double radians = angle * Math.PI / 180.0;
                int x = (int)(centerX + radius * Math.Cos(radians));
                int y = (int)(centerY + radius * Math.Sin(radians));
                sdDraw(x, y, character);
            }
        }

        public void sdFillCircle(int centerX, int centerY, int radius, char character)
        {
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        sdDraw(centerX + x, centerY + y, character);
                    }
                }
            }
        }

        public void sdClear()
        {
            Console.Clear();
        }

        public void sdRender()
        {
            Thread.Sleep(1000);
        }
    }
}
