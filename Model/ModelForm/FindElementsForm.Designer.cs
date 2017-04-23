namespace ModelForm
{
    partial class FindElementsForm
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
            this.TriangleCheckBox = new System.Windows.Forms.CheckBox();
            this.RectandleCheckBox = new System.Windows.Forms.CheckBox();
            this.CircleChekBox = new System.Windows.Forms.CheckBox();
            this.AreaRangeLabel = new System.Windows.Forms.Label();
            this.FromAreaValueTextBox = new System.Windows.Forms.TextBox();
            this.ToAreaValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindingFigureList = new System.Windows.Forms.DataGridView();
            this.FingingFiguresGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FindingFigureList)).BeginInit();
            this.FingingFiguresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TriangleCheckBox
            // 
            this.TriangleCheckBox.AutoSize = true;
            this.TriangleCheckBox.Location = new System.Drawing.Point(12, 12);
            this.TriangleCheckBox.Name = "TriangleCheckBox";
            this.TriangleCheckBox.Size = new System.Drawing.Size(64, 17);
            this.TriangleCheckBox.TabIndex = 0;
            this.TriangleCheckBox.Text = "Triangle";
            this.TriangleCheckBox.UseVisualStyleBackColor = true;
            // 
            // RectandleCheckBox
            // 
            this.RectandleCheckBox.AutoSize = true;
            this.RectandleCheckBox.Location = new System.Drawing.Point(12, 35);
            this.RectandleCheckBox.Name = "RectandleCheckBox";
            this.RectandleCheckBox.Size = new System.Drawing.Size(75, 17);
            this.RectandleCheckBox.TabIndex = 1;
            this.RectandleCheckBox.Text = "Rectangle";
            this.RectandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // CircleChekBox
            // 
            this.CircleChekBox.AutoSize = true;
            this.CircleChekBox.Location = new System.Drawing.Point(12, 58);
            this.CircleChekBox.Name = "CircleChekBox";
            this.CircleChekBox.Size = new System.Drawing.Size(52, 17);
            this.CircleChekBox.TabIndex = 2;
            this.CircleChekBox.Text = "Circle";
            this.CircleChekBox.UseVisualStyleBackColor = true;
            // 
            // AreaRangeLabel
            // 
            this.AreaRangeLabel.AutoSize = true;
            this.AreaRangeLabel.Location = new System.Drawing.Point(12, 87);
            this.AreaRangeLabel.Name = "AreaRangeLabel";
            this.AreaRangeLabel.Size = new System.Drawing.Size(59, 13);
            this.AreaRangeLabel.TabIndex = 3;
            this.AreaRangeLabel.Text = "Area range";
            // 
            // FromAreaValueTextBox
            // 
            this.FromAreaValueTextBox.Location = new System.Drawing.Point(12, 115);
            this.FromAreaValueTextBox.Name = "FromAreaValueTextBox";
            this.FromAreaValueTextBox.Size = new System.Drawing.Size(59, 20);
            this.FromAreaValueTextBox.TabIndex = 4;
            // 
            // ToAreaValueTextBox
            // 
            this.ToAreaValueTextBox.Location = new System.Drawing.Point(99, 115);
            this.ToAreaValueTextBox.Name = "ToAreaValueTextBox";
            this.ToAreaValueTextBox.Size = new System.Drawing.Size(59, 20);
            this.ToAreaValueTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // FindingFigureList
            // 
            this.FindingFigureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindingFigureList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindingFigureList.Location = new System.Drawing.Point(3, 16);
            this.FindingFigureList.Name = "FindingFigureList";
            this.FindingFigureList.Size = new System.Drawing.Size(242, 433);
            this.FindingFigureList.TabIndex = 7;
            // 
            // FingingFiguresGroupBox
            // 
            this.FingingFiguresGroupBox.Controls.Add(this.FindingFigureList);
            this.FingingFiguresGroupBox.Location = new System.Drawing.Point(236, 12);
            this.FingingFiguresGroupBox.Name = "FingingFiguresGroupBox";
            this.FingingFiguresGroupBox.Size = new System.Drawing.Size(248, 452);
            this.FingingFiguresGroupBox.TabIndex = 8;
            this.FingingFiguresGroupBox.TabStop = false;
            this.FingingFiguresGroupBox.Text = "Finging Figures";
            // 
            // FindElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 476);
            this.Controls.Add(this.FingingFiguresGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToAreaValueTextBox);
            this.Controls.Add(this.FromAreaValueTextBox);
            this.Controls.Add(this.AreaRangeLabel);
            this.Controls.Add(this.CircleChekBox);
            this.Controls.Add(this.RectandleCheckBox);
            this.Controls.Add(this.TriangleCheckBox);
            this.Name = "FindElementsForm";
            this.Text = "FindElementsForm";
            ((System.ComponentModel.ISupportInitialize)(this.FindingFigureList)).EndInit();
            this.FingingFiguresGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox TriangleCheckBox;
        private System.Windows.Forms.CheckBox RectandleCheckBox;
        private System.Windows.Forms.CheckBox CircleChekBox;
        private System.Windows.Forms.Label AreaRangeLabel;
        private System.Windows.Forms.TextBox FromAreaValueTextBox;
        private System.Windows.Forms.TextBox ToAreaValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FindingFigureList;
        private System.Windows.Forms.GroupBox FingingFiguresGroupBox;
    }
}