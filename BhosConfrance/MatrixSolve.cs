using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BhosConfrance
{
    public partial class MatrixSolve : Form
    {
        public MatrixSolve()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            label1.Hide();
            SubmitButton.Hide();
            textBox1.Hide();

            dataGridView1.RowCount = Convert.ToInt32(textBox1.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(textBox1.Text);
            
            dataGridView2.RowCount = Convert.ToInt32(textBox1.Text);
            dataGridView2.ColumnCount = 1;

            dataGridView2.AutoResizeRows();
            dataGridView2.AutoResizeColumns();

            dataGridView1.AutoResizeRows();
            dataGridView1.AutoResizeColumns();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            dataGridView1.Show();
            dataGridView2.Show();
            SolveButton.Show();
        }

        private void MatrixSolve_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            SolveButton.Hide();
            label2.Hide();

        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int size = dataGridView1.ColumnCount;
          

            double[,] A = new double [size,size];
            double[] B = new double[size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    A[j, i] = Convert.ToDouble(dataGridView1[i, j].Value);

            for (int i = 0; i < size; i++)
                B[i] = Convert.ToDouble(dataGridView2[0,i].Value);

            MatrixSolver sol = new MatrixSolver();
            double[] X = sol.Solve(A, B);
            for (int i = 0; i < size; i++)
                label2.Text += "root "+(i+1)+" is " + X[i].ToString()+"\n";
            label2.Show();

        }
    }
}
