namespace genAlg1
{
    partial class MatrixForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(23, 412);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(90, 23);
            this.saveB.TabIndex = 3;
            this.saveB.Text = "Сохранить";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(157, 412);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(90, 23);
            this.clearB.TabIndex = 4;
            this.clearB.Text = "Очистить";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.saveB);
            this.Name = "MatrixForm";
            this.Text = "Матрица стоимости";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Button clearB;
    }
}