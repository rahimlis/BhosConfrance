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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 2;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          //  numericUpDown1.Hide();
            linear_label.Hide();
            exppow.Hide();
            exp_label.Hide();
            poly_label.Hide(); //
            power_label.Hide();
            power_pow.Hide();
            label1.Hide();
            combo_label.Hide();
            combo_pow.Hide();
            numericUpDown1.Hide();
        }

        private void PointsButton_Click(object sender, EventArgs e)
        {
            clear();
            GraphicDrawer a = new GraphicDrawer();
            a.setLimits(dataGridView1);
            a.DrawPoints(zedGraphControl1, dataGridView1);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.CurveList.Clear();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
          
        }
        
        private void MatrixButton_Click(object sender, EventArgs e)
        {
            MatrixSolve a = new MatrixSolve();
            a.Show();
        }

        private void Polybutton_Click(object sender, EventArgs e)
        {
           // clear();
            numericUpDown1.Show();
            label1.Show();
            CurveFit curv = new CurveFit(dataGridView1);
            int order = Convert.ToInt32(numericUpDown1.Value);
         //   MessageBox.Show(order + "");
            double[] X = curv.polynom(order);
            GraphicDrawer draw = new GraphicDrawer();
            draw.setLimits(dataGridView1);
            draw.DrawGraph(zedGraphControl1, "poly",X,Color.Cyan);
            polyEquation(X);
            poly_label.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            clear();
            
            GraphicDrawer a = new GraphicDrawer();
            a.setLimits(dataGridView1);
            a.DrawPoints(zedGraphControl1, dataGridView1);

            CurveFit curv = new CurveFit(dataGridView1);
            int order = Convert.ToInt32(numericUpDown1.Value);
            //MessageBox.Show(order + "");
            double[] X = curv.polynom(order);
            a.DrawGraph(zedGraphControl1, "poly", X,Color.Violet);
            polyEquation(X);
            label1.Show();
            poly_label.Show();
        }

        private void Linear_Button_Click(object sender, EventArgs e)
        {
            CurveFit curv = new CurveFit(dataGridView1);
            int order = 1;
            double[] X = curv.polynom(order);
            GraphicDrawer draw = new GraphicDrawer();
            draw.setLimits(dataGridView1);
            draw.DrawGraph(zedGraphControl1, "linear", X,Color.Orange);
            String equation ="y = "+ String.Format("{0:0.00}", X[1]) + "x+"+String.Format("{0:0.00}",X[0]);
            linear_label.Text = equation;
            linear_label.Show();
       
        }

        private void polyEquation(double[] X)
        {
            String equation = "y=";
            char[] a = new char[10];
            a[0] = '\u2070'; a[1] = '\u00B9'; 
            a[2] = '\u00B2'; a[3] = '\u00B3';
            a[4] = '\u2074'; a[5] = '\u2075';
            a[6] = '\u2076'; a[7] = '\u2077';
            a[8] = '\u2078'; a[9] = '\u2079';

            if (X[0] != 0)
                equation += String.Format("{0:0.00}", X[0]);
            /*if (X[1]!=0)
            {
                if (X[1] != 1)
                    equation += String.Format("{0:0.00}", X[1]) + "x+";
                else
                    equation += "x+";
            }*/
            for (int i = 1; i < X.Length; i++)
            {
                if (X[i] != 0)
                {
                    if (X[i] == 1)    
                            equation += "+x" + a[i%10] ;
                    else
                            equation +="+"+ String.Format("{0:0.00}", X[i]) + "x" + a[i%10];
                        
                }
                if (i % 5 == 0)
                    equation += "\n";
            }
            poly_label.Text = equation;
        
        }

      

        private void Exp_button_Click(object sender, EventArgs e)
        {
            CurveFit fit = new CurveFit(dataGridView1);
            double[] A = fit.exp();    
            A[0] = Math.Exp(A[0]);
            GraphicDrawer a = new GraphicDrawer();
            a.setLimits(dataGridView1);
            a.DrawGraph(zedGraphControl1, "exp", A,Color.Red);
            String equation = ""; String pow = "";
            equation+="Y="+ String.Format("{0:0.00}",A[0])+"e";
            pow += String.Format("{0:0.00}", A[1]) + "x";
            exp_label.Text = equation;
            exppow.Text = pow;
            exp_label.Show();
            exppow.Show();
        }

        private void power_button_Click(object sender, EventArgs e)
        {
            CurveFit fit = new CurveFit(dataGridView1);
            double[] A = fit.power();
            A[0] = Math.Exp(A[0]);
            GraphicDrawer a = new GraphicDrawer();
            a.setLimits(dataGridView1);
            a.DrawGraph(zedGraphControl1, "power", A,Color.Green);

            String equation = ""; String pow = "";
            equation += "y=" + String.Format("{0:0.00}", A[0]) + "x";
            pow += String.Format("{0:0.00}", A[1]);
            power_label.Text = equation;
            power_pow.Text = pow;
            power_label.Show();
            power_pow.Show();
        }

        private void clearData_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void ComboButton_Click(object sender, EventArgs e)
        {
            CurveFit fit = new CurveFit(dataGridView1);
            double[] A = fit.combo();
           // MessageBox.Show(A[0] + " " + A[1] + " " + A[2]);
            GraphicDrawer a = new GraphicDrawer();
            a.setLimits(dataGridView1);
            a.DrawGraph(zedGraphControl1, "combo", A, Color.Black);

            String equation = ""; String pow = "x";
            equation += "y=" + String.Format("{0:0.00}", A[0]) + "ln(x)" + String.Format("{0:0.00}", A[1]) + "cos(x)" + String.Format("{0:0.00}", A[2]) + "e";
            combo_label.Text = equation;
            combo_pow.Text = pow;
            combo_label.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurveFit fit = new CurveFit (dataGridView1);
            double[] err = new double[5];
              err[0] = fit.error("linear", 1);
              err[1] = fit.error("poly", 3);
              err[2] = fit.error("combo", 1);
              err[3] = fit.error("exp", 1);
              err[4] = fit.error("power", 1);
            int min = 0;
            for (int i = 0; i < err.Length; i++)
            {
   
                    if (err[i] < err[min])
                        min = i;
            }

            switch (min)
            {
                case 0: MessageBox.Show("The best approximation is linear function"); break;
                case 1: MessageBox.Show("The best approximation is polynom of 3rd order"); break;
                case 2: MessageBox.Show("The best approximation is combined function"); break;
                case 3: MessageBox.Show("The best approximation is exponential function"); break;
                case 4: MessageBox.Show("The best approximation is power function"); break;
            
            }
               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
