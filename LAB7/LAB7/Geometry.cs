﻿using System;

namespace LAB7
{
    public class Geometry
    {
        public int CalculateArea(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException();
            return a * b;
        }
    }
}
