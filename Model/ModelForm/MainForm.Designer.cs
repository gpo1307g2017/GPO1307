namespace ModelForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RadButCircle = new System.Windows.Forms.RadioButton();
            this.ButAddFigure = new System.Windows.Forms.Button();
            this.RadButRectangle = new System.Windows.Forms.RadioButton();
            this.ButRemoveFigure = new System.Windows.Forms.Button();
            this.RadButTriangle = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NumberOfFigure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfFigure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FigureArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RadButCircle);
            this.splitContainer1.Panel1.Controls.Add(this.ButAddFigure);
            this.splitContainer1.Panel1.Controls.Add(this.RadButRectangle);
            this.splitContainer1.Panel1.Controls.Add(this.ButRemoveFigure);
            this.splitContainer1.Panel1.Controls.Add(this.RadButTriangle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(462, 261);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // RadButCircle
            // 
            this.RadButCircle.AutoSize = true;
            this.RadButCircle.Location = new System.Drawing.Point(3, 49);
            this.RadButCircle.Name = "RadButCircle";
            this.RadButCircle.Size = new System.Drawing.Size(48, 17);
            this.RadButCircle.TabIndex = 2;
            this.RadButCircle.Text = "Круг";
            this.RadButCircle.UseVisualStyleBackColor = true;
            // 
            // ButAddFigure
            // 
            this.ButAddFigure.Location = new System.Drawing.Point(21, 197);
            this.ButAddFigure.Name = "ButAddFigure";
            this.ButAddFigure.Size = new System.Drawing.Size(90, 23);
            this.ButAddFigure.TabIndex = 3;
            this.ButAddFigure.Text = "Add Figure";
            this.ButAddFigure.UseVisualStyleBackColor = true;
            this.ButAddFigure.Click += new System.EventHandler(this.ButAddFigure_Click);
            // 
            // RadButRectangle
            // 
            this.RadButRectangle.AutoSize = true;
            this.RadButRectangle.Location = new System.Drawing.Point(3, 26);
            this.RadButRectangle.Name = "RadButRectangle";
            this.RadButRectangle.Size = new System.Drawing.Size(105, 17);
            this.RadButRectangle.TabIndex = 1;
            this.RadButRectangle.Text = "Прямоугольник";
            this.RadButRectangle.UseVisualStyleBackColor = true;
            // 
            // ButRemoveFigure
            // 
            this.ButRemoveFigure.Location = new System.Drawing.Point(21, 226);
            this.ButRemoveFigure.Name = "ButRemoveFigure";
            this.ButRemoveFigure.Size = new System.Drawing.Size(90, 23);
            this.ButRemoveFigure.TabIndex = 4;
            this.ButRemoveFigure.Text = "Remove Figure";
            this.ButRemoveFigure.UseVisualStyleBackColor = true;
            this.ButRemoveFigure.Click += new System.EventHandler(this.ButRemoveFigure_Click);
            // 
            // RadButTriangle
            // 
            this.RadButTriangle.AutoSize = true;
            this.RadButTriangle.Checked = true;
            this.RadButTriangle.Location = new System.Drawing.Point(3, 3);
            this.RadButTriangle.Name = "RadButTriangle";
            this.RadButTriangle.Size = new System.Drawing.Size(90, 17);
            this.RadButTriangle.TabIndex = 0;
            this.RadButTriangle.TabStop = true;
            this.RadButTriangle.Text = "Треугольник";
            this.RadButTriangle.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfFigure,
            this.TypeOfFigure,
            this.FigureArea});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(304, 257);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // NumberOfFigure
            // 
            this.NumberOfFigure.HeaderText = "№фигуры";
            this.NumberOfFigure.Name = "NumberOfFigure";
            this.NumberOfFigure.ReadOnly = true;
            this.NumberOfFigure.Width = 60;
            // 
            // TypeOfFigure
            // 
            this.TypeOfFigure.HeaderText = "Тип фигуры";
            this.TypeOfFigure.Name = "TypeOfFigure";
            this.TypeOfFigure.ReadOnly = true;
            // 
            // FigureArea
            // 
            this.FigureArea.HeaderText = "Площади фигуры";
            this.FigureArea.Name = "FigureArea";
            this.FigureArea.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Добавление и удаление фигур";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton RadButCircle;
        private System.Windows.Forms.RadioButton RadButRectangle;
        private System.Windows.Forms.RadioButton RadButTriangle;
        private System.Windows.Forms.Button ButRemoveFigure;
        private System.Windows.Forms.Button ButAddFigure;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfFigure;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfFigure;
        private System.Windows.Forms.DataGridViewTextBoxColumn FigureArea;
    }
}

