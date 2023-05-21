namespace Examples
{
    partial class ExpensesDialog
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
            this.categoryExpense = new System.Windows.Forms.ComboBox();
            this.dateExpense = new System.Windows.Forms.DateTimePicker();
            this.numericExpense = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelExpense = new System.Windows.Forms.Button();
            this.successBtn = new System.Windows.Forms.Button();
            this.commentExpense = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Период";
            // 
            // categoryExpense
            // 
            this.categoryExpense.FormattingEnabled = true;
            this.categoryExpense.Items.AddRange(new object[] {
            "Продукты питания",
            "Транспорт",
            "Мобильная связь",
            "Интернет",
            "Развлечения",
            "Другое"});
            this.categoryExpense.Location = new System.Drawing.Point(83, 35);
            this.categoryExpense.Name = "categoryExpense";
            this.categoryExpense.Size = new System.Drawing.Size(121, 21);
            this.categoryExpense.TabIndex = 20;
            // 
            // dateExpense
            // 
            this.dateExpense.Location = new System.Drawing.Point(83, 9);
            this.dateExpense.Name = "dateExpense";
            this.dateExpense.Size = new System.Drawing.Size(120, 20);
            this.dateExpense.TabIndex = 18;
            // 
            // numericExpense
            // 
            this.numericExpense.Location = new System.Drawing.Point(83, 62);
            this.numericExpense.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericExpense.Name = "numericExpense";
            this.numericExpense.Size = new System.Drawing.Size(120, 20);
            this.numericExpense.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Комментарий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Категория";
            // 
            // cancelExpense
            // 
            this.cancelExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelExpense.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cancelExpense.Location = new System.Drawing.Point(218, 219);
            this.cancelExpense.Name = "cancelExpense";
            this.cancelExpense.Size = new System.Drawing.Size(75, 23);
            this.cancelExpense.TabIndex = 13;
            this.cancelExpense.Text = "Отмена";
            this.cancelExpense.UseVisualStyleBackColor = true;
            this.cancelExpense.Click += new System.EventHandler(this.cancelExpense_Click);
            // 
            // successBtn
            // 
            this.successBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.successBtn.Location = new System.Drawing.Point(15, 219);
            this.successBtn.Name = "successBtn";
            this.successBtn.Size = new System.Drawing.Size(75, 23);
            this.successBtn.TabIndex = 12;
            this.successBtn.Text = "Ок";
            this.successBtn.UseVisualStyleBackColor = true;
            this.successBtn.Click += new System.EventHandler(this.successBtn_Click);
            // 
            // commentExpense
            // 
            this.commentExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentExpense.Location = new System.Drawing.Point(95, 98);
            this.commentExpense.Multiline = true;
            this.commentExpense.Name = "commentExpense";
            this.commentExpense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentExpense.Size = new System.Drawing.Size(198, 115);
            this.commentExpense.TabIndex = 22;
            // 
            // ExpensesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.commentExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryExpense);
            this.Controls.Add(this.dateExpense);
            this.Controls.Add(this.numericExpense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelExpense);
            this.Controls.Add(this.successBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "ExpensesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить расходов";
            ((System.ComponentModel.ISupportInitialize)(this.numericExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryExpense;
        private System.Windows.Forms.DateTimePicker dateExpense;
        private System.Windows.Forms.NumericUpDown numericExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelExpense;
        private System.Windows.Forms.Button successBtn;
        private System.Windows.Forms.TextBox commentExpense;
    }
}