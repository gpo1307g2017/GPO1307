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
            this.AreaRangeLabel = new System.Windows.Forms.Label();
            this.FromAreaValueTextBox = new System.Windows.Forms.TextBox();
            this.ToAreaValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindingFigureList = new System.Windows.Forms.DataGridView();
            this.FingingFiguresGroupBox = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.FindingFigureList)).BeginInit();
            this.FingingFiguresGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.FindingFigureList.Size = new System.Drawing.Size(250, 387);
            this.FindingFigureList.TabIndex = 7;
            // 
            // FingingFiguresGroupBox
            // 
            this.FingingFiguresGroupBox.Controls.Add(this.FindingFigureList);
            this.FingingFiguresGroupBox.Location = new System.Drawing.Point(236, 12);
            this.FingingFiguresGroupBox.Name = "FingingFiguresGroupBox";
            this.FingingFiguresGroupBox.Size = new System.Drawing.Size(256, 406);
            this.FingingFiguresGroupBox.TabIndex = 8;
            this.FingingFiguresGroupBox.TabStop = false;
            this.FingingFiguresGroupBox.Text = "Finging Figures";
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(42, 189);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(116, 49);
            this.FindButton.TabIndex = 8;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(408, 424);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(84, 40);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Cansel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TriangleRadioButton
            // 
            this.TriangleRadioButton.AutoSize = true;
            this.TriangleRadioButton.Location = new System.Drawing.Point(12, 12);
            this.TriangleRadioButton.Name = "TriangleRadioButton";
            this.TriangleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.TriangleRadioButton.TabIndex = 10;
            this.TriangleRadioButton.TabStop = true;
            this.TriangleRadioButton.Text = "Triangle";
            this.TriangleRadioButton.UseVisualStyleBackColor = true;
            this.TriangleRadioButton.CheckedChanged += new System.EventHandler(this.TriangleRadioButton_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Location = new System.Drawing.Point(12, 35);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(74, 17);
            this.RectangleRadioButton.TabIndex = 11;
            this.RectangleRadioButton.TabStop = true;
            this.RectangleRadioButton.Text = "Rectangle";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(12, 58);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.CircleRadioButton.TabIndex = 12;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Circle";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.CircleRadioButton_CheckedChanged);
            // 
            // FindElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 476);
            this.Controls.Add(this.CircleRadioButton);
            this.Controls.Add(this.RectangleRadioButton);
            this.Controls.Add(this.TriangleRadioButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FingingFiguresGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToAreaValueTextBox);
            this.Controls.Add(this.FromAreaValueTextBox);
            this.Controls.Add(this.AreaRangeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindElementsForm";
            this.Text = "FindElementsForm";
            ((System.ComponentModel.ISupportInitialize)(this.FindingFigureList)).EndInit();
            this.FingingFiguresGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AreaRangeLabel;
        private System.Windows.Forms.TextBox FromAreaValueTextBox;
        private System.Windows.Forms.TextBox ToAreaValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FindingFigureList;
        private System.Windows.Forms.GroupBox FingingFiguresGroupBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RadioButton TriangleRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.RadioButton CircleRadioButton;
    }
}