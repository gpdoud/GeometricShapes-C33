﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes {
    public class Rectangle {

        public int Height { get; set;  }
        public int Width { get; set; }

        public Rectangle(int height, int width) {
            Height = height;
            Width = width;
        }

        public void PrintPerimeter() {
            int perimeter = Rectangle.CalculatePerimeter(Height, Width);
            Console.WriteLine($"A rectange with a height of {Height} and width of {Width} " +
                                $"has a perimeter of {perimeter}");
        }
        // method called PrintArea
        public void PrintArea() {
            int area = CalculateArea(Height, Width);
            Console.WriteLine($"A rectangle with a height of {Height} and width of {Width} " +
                                $"has an area of {area}");
        }

        public static int CalculatePerimeter(int height, int width) {
            return (height + width) * 2;
        }
        public static int CalculateArea(int height, int width) {
            return height * width;
        }

    }
}
