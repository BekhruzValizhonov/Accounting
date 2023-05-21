namespace Examples
{
    partial class IncomeDialog
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
            this.successBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericIncome = new System.Windows.Forms.NumericUpDown();
            this.dateIncome = new System.Windows.Forms.DateTimePicker();
            this.categoryIncome = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commentIncome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // successBtn
            // 
            this.successBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.successBtn.Location = new System.Drawing.Point(15, 219);
            this.successBtn.Name = "successBtn";
            this.successBtn.Size = new System.Drawing.Size(75, 23);
            this.successBtn.TabIndex = 0;
            this.successBtn.Text = "Ок";
            this.successBtn.UseVisualStyleBackColor = true;
            this.successBtn.Click += new System.EventHandler(this.successBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cancelBtn.Location = new System.Drawing.Point(218, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комментарий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сумма";
            // 
            // numericIncome
            // 
            this.numericIncome.Location = new System.Drawing.Point(83, 62);
            this.numericIncome.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericIncome.Name = "numericIncome";
            this.numericIncome.Size = new System.Drawing.Size(120, 20);
            this.numericIncome.TabIndex = 6;
            // 
            // dateIncome
            // 
            this.dateIncome.Location = new System.Drawing.Point(83, 9);
            this.dateIncome.Name = "dateIncome";
            this.dateIncome.Size = new System.Drawing.Size(120, 20);
            this.dateIncome.TabIndex = 7;
            // 
            // categoryIncome
            // 
            this.categoryIncome.FormattingEnabled = true;
            this.categoryIncome.Items.AddRange(new object[] {
            "Заработная плата",
            "Дохода с сдачи в аренду недвижимости",
            "Иные доходы"});
            this.categoryIncome.Location = new System.Drawing.Point(83, 35);
            this.categoryIncome.Name = "categoryIncome";
            this.categoryIncome.Size = new System.Drawing.Size(121, 21);
            this.categoryIncome.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Период";
            // 
            // commentIncome
            // 
            this.commentIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentIncome.Location = new System.Drawing.Point(95, 98);
            this.commentIncome.Multiline = true;
            this.commentIncome.Name = "commentIncome";
            this.commentIncome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentIncome.Size = new System.Drawing.Size(198, 115);
            this.commentIncome.TabIndex = 23;
            // 
            // IncomeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.commentIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryIncome);
            this.Controls.Add(this.dateIncome);
            this.Controls.Add(this.numericIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.successBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "IncomeDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление доходов";
            ((System.ComponentModel.ISupportInitialize)(this.numericIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button successBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericIncome;
        private System.Windows.Forms.DateTimePicker dateIncome;
        private System.Windows.Forms.ComboBox categoryIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentIncome;
    }
}