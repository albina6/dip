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
    public enum SaveBoolEvent
    {
        Yes,
        No
    }
    public partial class MatrixForm : Form
    {
        private double[,] matrix;

        private bool flagFull;
        private int sizeMatrix;
        private DataGridView dataGridView = new DataGridView();
        
        public MatrixForm()
        {
            //this.Load += new EventHandler(MatrixForm_Load);
            InitializeComponent();
        }

        public MatrixForm(double [,] matrix,bool flagFull)
        {
            this.matrix = matrix;
            this.flagFull = flagFull;
            this.sizeMatrix = matrix.GetLength(0);
            this.Load += new EventHandler(MatrixForm_Load);
            InitializeComponent();
        }
        private void MatrixForm_Load(System.Object sender, System.EventArgs e)
        {
            SetupDataGridView();
            recordDataDGV();
        }

        private void dataGridView_Validating(object sender, DataGridViewCellFormattingEventArgs e)
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                
                try
                {
                    if (Convert.ToDouble(e.Value) > 0)
                       // e.Value = DateTime.Parse(e.Value.ToString()).ToLongDateString();
                    e.FormattingApplied = true;
                    else
                        Console.WriteLine("{0}, значение должно быть >0", e.Value.ToString());

                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}, данные в ячейке не валидны, введите стоимость пути.", e.Value.ToString());
                }
            }
        }
        private void SetupDataGridView()
        {
            this.Controls.Add(dataGridView);
            dataGridView.ColumnCount = sizeMatrix;
            dataGridView.RowCount = sizeMatrix;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);

            //dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Navy;
            //dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView.RowHeadersDefaultCellStyle.Font =
            //    new Font(dataGridView.Font, FontStyle.Bold);
           // dataGridView.RowHeadersDefaultCellStyle.

            dataGridView.Name = "dataGridView";
            dataGridView.Location = new Point(10, 10);
           // dataGridView.Margin= new margi (20);

            //dataGridView.Size = new Size(500, 500);
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.RowHeadersVisible = true;
            dataGridView.ColumnHeadersVisible = true;
            //dataGridView.GridColor = Color.Black;
            ////dataGridView.Rows.

            for (int i = 0; i < sizeMatrix; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = i.ToString();
                dataGridView.Columns[i].HeaderCell.Value = i.ToString();
                dataGridView.Columns[i].Name = i.ToString();

            }

            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.MultiSelect = false;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AllowUserToAddRows = false;

            //dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormatting);
        }

        private void recordDataDGV()
        {
            for (int colum = 0; colum < sizeMatrix; colum++)
            {
                for (int row = 0; row < sizeMatrix; row++)
                {
                    dataGridView[colum, row].Value = matrix[colum, row];
                }
            }
        }
       

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SetupDataGridView();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int colum = 0; colum < sizeMatrix; colum++)
            {
                for (int row = 0; row < sizeMatrix; row++)
                {
                    try
                    {
                        matrix[colum, row] = Convert.ToDouble(dataGridView[colum, row].Value);
                        if (matrix[colum, row] <= 0)
                        {
                            flagFull = false;
                        }
                    
                    catch (FormatException)
                    {
                        Console.WriteLine("{0}, данные в ячейке не валидны," +
                            " введите стоимость пути.", dataGridView[colum, row].Value.ToString());
                    }

                }
            }
            if (!flagFull)
            {
                //добавишь потом форму да/нет
                SaveQuestionForm saveQF = new SaveQuestionForm();
                saveQF.ShowDialog();
                SaveBoolEvent saveB = saveQF.SaveBE;
                

                Console.WriteLine("Таблица не заполнена, хотите сохранить изменения?");
            }
            //отправка матрицы и флага на главную форму
        }
    }
}
