using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace BhosConfrance
{
    class CurveFit
    {
      public  double []X;
        double[] Y;
        int n;

       public CurveFit(DataGridView Data)
        {
             n = Data.Rows.Count - 1;
             X = new double[n];
             Y = new double[n];
            for (int i = 0; i < n; i++)
            {
                X[i] = Convert.ToDouble(Data.Rows[i].Cells[0].Value);
                Y[i] = Convert.ToDouble(Data.Rows[i].Cells[1].Value);
            }
        
        }


       public double[] polynom(int order)
       {
           int size = order+1;
           double[,] A = new double[size, size];
           A[0, 0] = n;
           double[] B = new double[size];
           B[0] = sum(Y, 1);

           for (int i = 1; i < size; i++)
           {
               A[0, i] = sum(X, i);
               B[i] = sum(X, Y, i);
           }

           for (int i = 1; i < size; i++)
               for (int j = 0; j < size;j++)
                   A[i, j] = sum(X, j+i);
           MatrixSolver a = new MatrixSolver();
           double[] AB = a.Solve(A, B);
           return AB;
       }

       

       public double[] exp()
       {
           double  sumx, sumx2, sumz,sumzx;
           sumx = sumx2 = sumz =sumzx= 0;
           sumx = sum(X, 1);
           sumx2 = sum(X, 2);
           double[] Z = Y;
           for (int i = 0; i < Y.Length; i++)
           {
               if (Y[i] != 0)
               {
                   if (Y[i]>0)
                   Z[i] = Math.Log(Math.Abs(Y[i]));
                   else
                       Z[i] = -Math.Log(Math.Abs(Y[i]));
               }
           }
           sumzx = sum(Z, X, 1);
           sumz = sum(Z, 1);
           double[,] A = { { n, sumx }, { sumx, sumx2 } };
           double[] B = { sumz, sumzx };
           MatrixSolver a = new MatrixSolver();
           double[] AB = a.Solve(A, B);
           return AB;
       }
       
        public double[] power()
       {
           double  sumlnx, sumlnx2, sumz, sumzlnx;
           sumlnx = sumlnx2 = sumz = sumzlnx = 0;
           double[] Z = Y;
           double[] T = X;
           for (int i = 0; i < Y.Length; i++)
           {
                   if (Y[i] != 0)
                   {
                       if (Y[i]>0)
                       Z[i] = Math.Log(Math.Abs(Y[i]));
                       else
                       Z[i] = -Math.Log(Math.Abs(Y[i]));
                   }

                   if (X[i] != 0)
                   {
                       if (X[i]>0)
                       T[i] = Math.Log(Math.Abs(X[i]));
                       else
                           T[i] = -Math.Log(Math.Abs(X[i]));
                   }
               }
           sumlnx = sum(T, 1);
           sumlnx2 = sum(T, 2);
           sumz = sum(Z, 1);
           sumzlnx = sum(T, Z, 1);
           double[,] A = { { n, sumlnx }, { sumlnx, sumlnx2 } };
           double[] B = { sumz, sumzlnx };
           MatrixSolver a = new MatrixSolver();
           double[] AB = a.Solve(A, B);
           return AB;
       }

        public double[] combo()
        {
            double sumlnx,sumcosx2, sumlnx2, sumcosx, sumlnxcosx,sumlnxex,sumcosxex,sumex2;
            double[] lnx,cosx,ex;
            lnx = new double[X.Length];
            cosx = new double[X.Length];
            ex = new double[X.Length];

            for (int i = 0; i < X.Length; i++)
            {
                lnx[i] = Math.Log(X[i]);
                cosx[i] = Math.Cos(X[i]);
                ex[i] = Math.Exp(X[i]);
            }

            sumlnx = sum(lnx, 1);
            sumlnx2 = sum(lnx, 2);
            sumcosx = sum(cosx, 1);
            sumlnxcosx = sum(lnx, cosx, 1);
            sumlnxex = sum(lnx, ex, 1);
            sumcosxex = sum(cosx, ex, 1);
            sumex2 = sum(ex, 2);
            sumcosx2 = sum (cosx,2);
            double[,] A = { { sumlnx2, sumlnxcosx, sumlnxex }, { sumlnxcosx, sumcosx2, sumcosxex }, { sumlnxex, sumcosxex, sumex2 } };
            double[] B = { sum(Y,lnx,1), sum(Y,cosx,1),sum(Y,ex,1)};
            MatrixSolver a = new MatrixSolver();
            double[] AB = a.Solve(A, B);
            return AB;

        }
       
        public double sum(double[] arr,int order)
        {
            double summ=0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += Math.Pow(arr[i],order); 
            }
            return summ;
        }

        public double sum(double[] arr, double []arr2,int order)
        {
            double summ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summ += Math.Pow(arr[i],order)*arr2[i];
            }
            return summ;
        }

        public double error(String function,int order)
        {
            double error = 0;
          //  MessageBox.Show(combo()[0] + " " + combo()[1] + " " + combo()[2]);
            for (int i = 0; i < Y.Length; i++)
            {
                switch (function)
                {
                    case "exp": error += Math.Pow(Y[i] - expf(X[i], exp()[0], exp()[1]),2); break;
                    case "poly": error += Math.Pow(Y[i] - polyf(X[i], polynom(order)),2) ; break;
                    case "linear": error +=Math.Pow(Y[i] - polyf(X[i], polynom(1)),2); break;
                    case "power": error += Math.Pow(Y[i] - powf(X[i], power()[0], power()[1]),2) ; break;
                    case "combo":  error += Math.Pow(Y[i] - combof(X[i], combo()), 2); break;
                }
            }
            return error;
        }

        private double combof(double x, double[] AB)
        {
            return AB[0] * Math.Log(x) + AB[1] * Math.Cos(x) + AB[2] * Math.Exp(x);
        }
        private double expf(double x, double a, double b)
        {
            return a * Math.Exp(x * b);
        }

        private double powf(double x, double a, double b)
        {
            return a * Math.Pow(x, b);
        }
        private double polyf(double x, double[] AB)
        {
            double y = 0;
            for (int i = 0; i < AB.Length; i++)
            {
                y += AB[i] * Math.Pow(x, i);
            }
            return y;
        }

    }
}
