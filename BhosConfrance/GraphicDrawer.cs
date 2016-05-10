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
    class GraphicDrawer
    {
        
        private double cos(double x)
        {
            return Math.Cos(x);
        }
        private double combo(double x, double[] AB)
        {
            return AB[0] * Math.Log(x) + AB[1] * Math.Cos(x) + AB[2] * Math.Exp(x);
        }
        private double exp(double x,double a,double b)
        {
            return a*Math.Exp(x*b);
        }

        private double pow(double x, double a, double b)
        {
            return a * Math.Pow(x,b);
        }
        private double poly(double x,double [] AB)
        {
            double y=0;
            for (int i =0; i<AB.Length;i++)
            {
                y += AB[i] * Math.Pow(x, i);
            }
            return y;
        }


        double xmin;
        double xmax;

        public void setLimits(DataGridView a)
        {
            double min = Convert.ToDouble(a[0,0].Value);
            double max = Convert.ToDouble(a[0, 0].Value);

            for (int i = 0; i < a.RowCount; i++)
                if (Convert.ToDouble(a[0, i].Value) < min)
                    min = Convert.ToDouble(a[0, i].Value);

            for (int i = 0; i < a.RowCount; i++)
                if (Convert.ToDouble(a[0, i].Value) > max)
                    max = Convert.ToDouble(a[0, i].Value);
            xmin = min;
            xmax = max;
        }

        public void DrawGraph(ZedGraphControl graph, String func, double[] AB,Color col)
        {

            GraphPane pane = graph.GraphPane;
          //  pane.CurveList.Clear();
            PointPairList list = new PointPairList();

            for (double x = xmin; x <= xmax; x += 0.01)
            {
                switch (func)
                {           
                    
                    case "exp": list.Add(x, exp(x,AB[0],AB[1])); break;
                    case "poly": list.Add(x, poly(x,AB)); break;
                    case "linear": list.Add(x, poly(x, AB)); break;
                    case "power": list.Add(x, pow(x, AB[0],AB[1])); break;
                    case "combo": list.Add(x, combo(x, AB)); break;
                    default: list.Add(x, x); break;
                }
                
            }
            LineItem myCurve = pane.AddCurve(func, list, col, SymbolType.None);
            graph.AxisChange();
            graph.Invalidate();
        }

        public void DrawPoints(ZedGraphControl a, DataGridView dataGridView1)
        {
            GraphPane pane = a.GraphPane;
          //  pane.CurveList.Clear();
            PointPairList list = new PointPairList();
            int n = dataGridView1.Rows.Count - 1;
            double[] Xd = new double[n];
            double[] Yd = new double[n];
            for (int i = 0; i < n; i++)
            {
                Xd[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                Yd[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                list.Add(Xd[i], Yd[i]);
            }
            LineItem myCurve = pane.AddCurve("Scatter", list, Color.Blue, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Fill.Color = Color.Blue;
            myCurve.Symbol.Fill.Type = FillType.Solid;
            myCurve.Symbol.Size = 7;
            a.AxisChange();
            a.Invalidate();
        }




    }
}
