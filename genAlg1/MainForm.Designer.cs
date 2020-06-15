namespace genAlg1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label deliveryL;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueTB = new System.Windows.Forms.TextBox();
            this.issueL = new System.Windows.Forms.Label();
            this.deliveryTB = new System.Windows.Forms.TextBox();
            this.calculateB = new System.Windows.Forms.Button();
            this.matrixB = new System.Windows.Forms.Button();
            this.routeTB = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            deliveryL = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryL
            // 
            deliveryL.AutoSize = true;
            deliveryL.Location = new System.Drawing.Point(16, 85);
            deliveryL.Name = "deliveryL";
            deliveryL.Size = new System.Drawing.Size(94, 13);
            deliveryL.TabIndex = 3;
            deliveryL.Text = "Адреса доставки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // issueTB
            // 
            this.issueTB.Location = new System.Drawing.Point(16, 62);
            this.issueTB.Name = "issueTB";
            this.issueTB.Size = new System.Drawing.Size(168, 20);
            this.issueTB.TabIndex = 1;
            // 
            // issueL
            // 
            this.issueL.AutoSize = true;
            this.issueL.Location = new System.Drawing.Point(16, 46);
            this.issueL.Name = "issueL";
            this.issueL.Size = new System.Drawing.Size(115, 13);
            this.issueL.TabIndex = 2;
            this.issueL.Text = "Адрес пункта выдачи";
            // 
            // deliveryTB
            // 
            this.deliveryTB.AcceptsReturn = true;
            this.deliveryTB.Location = new System.Drawing.Point(16, 101);
            this.deliveryTB.Multiline = true;
            this.deliveryTB.Name = "deliveryTB";
            this.deliveryTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.deliveryTB.Size = new System.Drawing.Size(168, 224);
            this.deliveryTB.TabIndex = 4;
            this.deliveryTB.WordWrap = false;
            // 
            // calculateB
            // 
            this.calculateB.Location = new System.Drawing.Point(16, 360);
            this.calculateB.Name = "calculateB";
            this.calculateB.Size = new System.Drawing.Size(168, 23);
            this.calculateB.TabIndex = 5;
            this.calculateB.Text = "Построение маршрута";
            this.calculateB.UseVisualStyleBackColor = true;
            this.calculateB.Click += new System.EventHandler(this.calculateB_Click);
            // 
            // matrixB
            // 
            this.matrixB.Location = new System.Drawing.Point(16, 331);
            this.matrixB.Name = "matrixB";
            this.matrixB.Size = new System.Drawing.Size(168, 23);
            this.matrixB.TabIndex = 6;
            this.matrixB.Text = "Редактирование матрицы";
            this.matrixB.UseVisualStyleBackColor = true;
            this.matrixB.Click += new System.EventHandler(this.matrixB_Click);
            // 
            // routeTB
            // 
            this.routeTB.AcceptsReturn = true;
            this.routeTB.Location = new System.Drawing.Point(237, 46);
            this.routeTB.Multiline = true;
            this.routeTB.Name = "routeTB";
            this.routeTB.ReadOnly = true;
            this.routeTB.Size = new System.Drawing.Size(493, 339);
            this.routeTB.TabIndex = 11;
            this.routeTB.WordWrap = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 425);
            this.Controls.Add(this.routeTB);
            this.Controls.Add(this.matrixB);
            this.Controls.Add(this.calculateB);
            this.Controls.Add(this.deliveryTB);
            this.Controls.Add(deliveryL);
            this.Controls.Add(this.issueL);
            this.Controls.Add(this.issueTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Поиск рационального маршрута";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.TextBox issueTB;
        private System.Windows.Forms.Label issueL;
        private System.Windows.Forms.TextBox deliveryTB;
        private System.Windows.Forms.Button calculateB;
        private System.Windows.Forms.Button matrixB;
        private System.Windows.Forms.TextBox routeTB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

