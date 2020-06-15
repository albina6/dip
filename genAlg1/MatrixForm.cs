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
        private int[,] matrix;
       // private *Form *form;
        private bool flagFull;
        private int sizeMatrix;
        private DataGridView dataGridView = new DataGridView();

        public MatrixForm()
        {
            //this.Load += new EventHandler(MatrixForm_Load);
            InitializeComponent();
        }
        public void  Matrix(int [,] matrix)
        {

        }
        public MatrixForm(int[,] matrix, bool flagFull)
        {
            this.matrix = (int[,])matrix.Clone();
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

        //  private void dataGridView_Validating(object sender, DataGridViewCellFormattingEventArgs e)
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {

                try
                {
                    if (Convert.ToInt32(e.Value) > 0)
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
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnCount = sizeMatrix;
            dataGridView.RowCount = sizeMatrix ;// нумерация с 1, потому что количество

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.RowHeadersDefaultCellStyle.Font =
                new Font(dataGridView.Font, FontStyle.Bold);
            //dataGridView.RowHeadersDefaultCellStyle.

            dataGridView.Name = "dataGridView";
            //

            //dataGridView.Location = new Point(10, 50);
            //dataGridView.Margin= new Padding (20);

            //dataGridView.Size = new si
            dataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            // dataGridView.
            //dataGridView.RowHeadersVisible = true;
            //dataGridView.ColumnHeadersVisible = true;
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
            
            //recordDataDGV();
            this.Controls.Add(dataGridView);
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

        private void saveB_Click(object sender, EventArgs e)
        {
            flagFull = true;
            for (int colum = 0; colum < sizeMatrix; colum++)
            {
                for (int row = 0; row < sizeMatrix; row++)
                {
                    try
                    {
                        if (colum == row)
                        {
                            matrix[colum, row] = 0;
                            continue;
                        }
                        matrix[colum, row] = Convert.ToInt32(dataGridView[colum, row].Value);
                        if (matrix[colum, row] <= 0)
                        {
                            flagFull = false;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("{0}, данные в ячейке - {1},{2} не валидны," +
                            " введите стоимость пути.", dataGridView[colum, row].Value.ToString(), colum, row);
                    }

                }
            }

            if (flagFull)
            {
                MainForm mainForm = (MainForm)this.Owner;
                mainForm.Matrix(matrix);
                mainForm.FullFlag(flagFull);
                this.Close();
                // закрытие формы и переход в главную форму
            }
            else
            {
                //добавишь потом форму да/нет
                SaveQuestionForm saveQF = new SaveQuestionForm();
                saveQF.ShowDialog();
                SaveBoolEvent saveB = saveQF.SaveBE;

                Console.WriteLine("Таблица не заполнена, хотите сохранить изменения?");
            }
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            SetupDataGridView();
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
