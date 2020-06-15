namespace genAlg1
{
    partial class SaveQuestionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.yesB = new System.Windows.Forms.Button();
            this.noB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Существуют ячейки значения которых <=0, ";
            // 
            // yesB
            // 
            this.yesB.Location = new System.Drawing.Point(65, 72);
            this.yesB.Name = "yesB";
            this.yesB.Size = new System.Drawing.Size(75, 23);
            this.yesB.TabIndex = 1;
            this.yesB.Text = "Да";
            this.yesB.UseVisualStyleBackColor = true;
            this.yesB.Click += new System.EventHandler(this.yesB_Click);
            // 
            // noB
            // 
            this.noB.Location = new System.Drawing.Point(209, 72);
            this.noB.Name = "noB";
            this.noB.Size = new System.Drawing.Size(75, 23);
            this.noB.TabIndex = 2;
            this.noB.Text = "Нет";
            this.noB.UseVisualStyleBackColor = true;
            this.noB.Click += new System.EventHandler(this.noB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "хотите сохранить изменения?";
            // 
            // SaveQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 132);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noB);
            this.Controls.Add(this.yesB);
            this.Controls.Add(this.label1);
            this.Name = "SaveQuestionForm";
            this.Text = "Сохранение";
            this.Load += new System.EventHandler(this.SaveQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesB;
        private System.Windows.Forms.Button noB;
        private System.Windows.Forms.Label label2;
    }
}