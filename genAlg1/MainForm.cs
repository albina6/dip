using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
//using System.Windows.Controls;
using System.Windows.Input;

namespace genAlg1
{
    public partial class MainForm : Form
    {
        private int[,] matrix;
        private string[] address;
        private string issueAddress;
        private int countPoint;
        private bool fullFlag= false;
        public MainForm()
        {
            matrix= new int [1,1];   
            InitializeComponent();
           // справкаToolStripMenuItem.Visible = false;
        }
        
        public void FullFlag(bool flag)
        {
            this.fullFlag = flag;
        }
        public void Matrix(int [,] matrix)
        {
            this.matrix = (int[,])matrix.Clone();
        }
        private void matrixB_Click(object sender, EventArgs e)
        {
            address = deliveryTB.Lines;
            //int sizeRoute = 5;
            //address = new string[sizeRoute];
            //issueAddress = "0 point";
            //for (int i = 1; i < sizeRoute; i++)
            //{
            //    address[i] = i + " point";
            //}


            issueAddress = issueTB.Text;
            countPoint =address.Length+1;
            if (countPoint != matrix.GetLength(0))
            {
                matrix = new int[countPoint, countPoint];
            }
            
            MatrixForm matrixForm = new MatrixForm(matrix, fullFlag);// надеемся что вернется матрица если флаг= тру можно производить расчет
            // //matrixForm.ShowDialog();
            matrixForm.Show(this);
            
            
        }

        private void calculateB_Click(object sender, EventArgs e)
        {
            if (fullFlag)
            {
                address = deliveryTB.Lines;
                issueAddress = issueTB.Text;

                //int[,] matrixWeight = new int[6, 6] { { 0,1,2,3,4,5},{5,0,6,3,2,1 },
                //    { 6,3,0,4,6,5},{1,3,5,0,2,1 },{ 2,6,1,5,0,3},{ 3,2,5,4,6,0} };
                GeneticAlg gen = new GeneticAlg(matrix, 0.4, 0.3, 0.2, 15, 10);
                //GeneticAlg gen = new GeneticAlg(matrixWeight, 0.6, 0.3, 0.2,30, 10);

                int[] el = gen.RouteElite;
                int sizeRoute = el.Length;

                //address = new string[sizeRoute];
                //issueAddress = "0 point";
                //for (int i = 1; i < sizeRoute; i++)
                //{
                //    address[i] = i + " point";
                //}

                routeTB.Text = issueAddress + System.Environment.NewLine;
                for (int i = 1; i < sizeRoute; i++)
                {
                    routeTB.Text += address[el[i]-1] + System.Environment.NewLine;
                }
                routeTB.Text += issueAddress + System.Environment.NewLine;
                routeTB.Text += el[0] + " - стоимость маршрута";
            }

            else
            {
                MessageBox.Show("В матрице стоимости есть ячейки со значениями," + '\n' + "не удовлетворяющими условию > 0."
                + '\n' + "Исправьте данные и повторите попытку.", "Ошибка матрицы стоимости");
            }
            
            //MatrixError me = new MatrixError();
            //me.ShowDialog();
            //issueAddress = issueTB.Text;
            
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string messageBoxText = "Do you want to save changes?";
            string caption = "Word Processor";

            //MessageBoxButton button = MessageBoxButton.;
            //MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBox.Show(messageBoxText, caption);
        }
    }
}
