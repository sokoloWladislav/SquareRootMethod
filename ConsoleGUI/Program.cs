﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[3, 3];                   //1, 2, 3
            double[,] matrix4 = new double[4, 4];
            double[,] matrix6 = new double[6, 6];
            double[,] matrix8 = new double[8, 8];
            double[,] matrix10 = new double[10, 10];
            double[,] matrix12 = new double[12, 12];
            double[,] matrix14 = new double[14, 14];
            matrix = new double[,] 
            { { 2, 1, 4 },
              { 1, 1, 3 },
              { 4, 3, 14 } };
            matrix4 = new double[,] 
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23, 1.0 / 24 }, 
              { 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25 }, 
              { 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26 },
              { 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27 } };
            matrix6 = new double[,] 
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26 }, 
              { 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27 }, 
              { 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28 },
              { 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29 },
              { 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30 },
              { 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31 } };
            matrix8 = new double[,] 
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, }, 
              { 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, }, 
              { 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, },
              { 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, },
              { 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, },
              { 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, },
              { 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, },
              { 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35,} };
            matrix10 = new double[,] 
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, }, 
              { 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, }, 
              { 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, },
              { 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, },
              { 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, },
              { 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, },
              { 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, },
              { 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, },
              { 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, },
              { 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, } };
            matrix12 = new double[,] 
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, }, 
              { 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, }, 
              { 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, },
              { 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, },
              { 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, },
              { 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, },
              { 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, },
              { 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, },
              { 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, },
              { 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, },
              { 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, },
              { 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, 1.0 / 43, } };
            matrix14 = new double[,] 
            { { 1.0 / 21, 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34 }, 
              { 1.0 / 22, 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35 }, 
              { 1.0 / 23, 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36 },
              { 1.0 / 24, 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37 },
              { 1.0 / 25, 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38 },
              { 1.0 / 26, 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39 },
              { 1.0 / 27, 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40 },
              { 1.0 / 28, 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41 },
              { 1.0 / 29, 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42 },
              { 1.0 / 30, 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, 1.0 / 43 },
              { 1.0 / 31, 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, 1.0 / 43, 1.0 / 44 },
              { 1.0 / 32, 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, 1.0 / 43, 1.0 / 44, 1.0 / 45 },
              { 1.0 / 33, 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, 1.0 / 43, 1.0 / 44, 1.0 / 45, 1.0 / 46 },
              { 1.0 / 34, 1.0 / 35, 1.0 / 36, 1.0 / 37, 1.0 / 38, 1.0 / 39, 1.0 / 40, 1.0 / 41, 1.0 / 42, 1.0 / 43, 1.0 / 44, 1.0 / 45, 1.0 / 46, 1.0 / 47 } };
            double[] result = new double[14];
            double[] f = {16, 12, 52, 15, 1, 6, 7, 8, 9, 11, 21, 12, 32, 13};
            result = SquareRootMethod.ToSolve(matrix14, 14, f);
            for (int i = 0; i < 14; ++i )
                Console.WriteLine(result[i]);
            Console.ReadKey();
        }
    }
}
