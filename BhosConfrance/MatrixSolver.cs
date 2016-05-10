using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhosConfrance
{
    class MatrixSolver
    {
        public  double [] Solve (double [,] A,double [] B)
        {
            int n = B.Length;

            for (int k = 0; k < n - 1; k++)
            {
                int imax = k;

                for (int m = k + 1; m < n; m++)
                { 
                    if (Math.Abs(A[m,k])>Math.Abs(A[imax,imax]))
                        imax =m;
                }
                for (int j = 0; j < n; j++)
                {
                    double c = A[k, j]; A[k, j] = A[imax, j];
                    A[imax, j] = c;
                }
                double con = B[k];
                
                B[k] = B[imax]; B[imax] = con;

                for (int i = k + 1; i < n; i++)
                {
                    double factor = A[i, k] / A[k, k];
                    for (int j = k ; j < n; j++)
                    {
                        A[i, j] = A[i, j] - factor * A[k, j];
                    }
                    B[i] = B[i] - factor * B[k];
                }
                
            
            }

        double [] X = new double[n];
        X[n - 1] = B[n - 1] / A[n - 1, n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            double sum = B[i];
            for (int j = i + 1; j < n; j++)
                sum = sum - A[i, j] * X[j];

            X[i] = sum / A[i, i];
            
        }

            return X;
        }

    }
}
