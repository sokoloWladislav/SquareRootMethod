using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class SquareRootMethod
    {   
        public static double[] ToSolve( double[,] matrix, int n, double[] f )
        {
            double temp = 0;
            double[] x = new double[n];
            double[] y = new double[n];
            double[] d = new double[n];
            double[,] s = new double[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < n; ++j)
                    s[i, j] = 0;
            for ( int i = 0; i < n; ++i )
            {
                temp = 0;
                for ( int k = 0; k < i; ++k )
                    temp += s[k, i] * s[k, i] * d[k];
                if (Math.Round(matrix[i, i] - (Math.Abs(Math.Round(temp, 1))), 1) >= 0)
                    d[i] = 1;
                else
                    d[i] = -1;
                s[i, i] = Math.Sqrt( Math.Abs(matrix[i, i] -  temp) );
                for ( int j = i + 1; j < n; ++j )
                {
                    temp = 0;
                    for (int k = 0; k < i; ++k )
                    {
                        temp += s[k, i] * d[k] * s[k, j]; 
                    }
                    s[i, j] = ( matrix[i, j] - temp ) / ( s[i, i] * d[i] );
                }

            }

            for ( int i = 0; i < n; ++i )
            {
                temp = 0;
                for ( int j = 0; j < i; ++j )
                {
                    temp += s[j, i] * y[j];
                }

                y[i] = ( f[i] - temp) / (s[i, i] * d[i] );
            }

            for (int i = n - 1; i > -1; --i )
            {
                temp = 0;
                for ( int j = i + 1; j < n; ++j )
                    temp += s[i, j] * x[j];
                x[i] = ( y[i] -  temp )/s[i, i];
            }

                return x;
        }
    }
}
