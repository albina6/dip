using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genAlg1
{
    public partial class MainForm : Form
    {
        private double[,] matrix;
        private int countPoint;
        private bool fullFlag= false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void matrixB_Click(object sender, EventArgs e)
        {
            this.countPoint =(int)countPointNUD.Value;
            matrix = new double[countPoint,countPoint];
            MatrixForm matrixForm = new MatrixForm(matrix, fullFlag);
            //matrixForm.ShowDialog();
            matrixForm.Show();
            
        }
    }
}
