namespace ModelForm
{
    partial class AddFigureForm
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
            this.FiguresTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.TriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FigureAreaLabel = new System.Windows.Forms.Label();
            this.FigureAreaTextBox = new System.Windows.Forms.TextBox();
            this.CalculateFigureAreaButton = new System.Windows.Forms.Button();
            this.TriangleGroupBox = new System.Windows.Forms.GroupBox();
            this.HeigthTextBox = new System.Windows.Forms.TextBox();
            this.MainsideTextBox = new System.Windows.Forms.TextBox();
            this.HeigthLabel = new System.Windows.Forms.Label();
            this.MainsideLabel = new System.Windows.Forms.Label();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.CircleGroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.FiguresTypeGroupBox.SuspendLayout();
            this.TriangleGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.CircleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiguresTypeGroupBox
            // 
            this.FiguresTypeGroupBox.Controls.Add(this.CircleRadioButton);
            this.FiguresTypeGroupBox.Controls.Add(this.RectangleRadioButton);
            this.FiguresTypeGroupBox.Controls.Add(this.TriangleRadioButton);
            this.FiguresTypeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.FiguresTypeGroupBox.Name = "FiguresTypeGroupBox";
            this.FiguresTypeGroupBox.Size = new System.Drawing.Size(102, 105);
            this.FiguresTypeGroupBox.TabIndex = 0;
            this.FiguresTypeGroupBox.TabStop = false;
            this.FiguresTypeGroupBox.Text = "Figure";
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(7, 68);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.CircleRadioButton.TabIndex = 2;
            this.CircleRadioButton.Text = "Circle";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.CircleRadioButton_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Location = new System.Drawing.Point(7, 44);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(74, 17);
            this.RectangleRadioButton.TabIndex = 1;
            this.RectangleRadioButton.Text = "Rectangle";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
            // 
            // TriangleRadioButton
            // 
            this.TriangleRadioButton.AutoSize = true;
            this.TriangleRadioButton.Location = new System.Drawing.Point(7, 20);
            this.TriangleRadioButton.Name = "TriangleRadioButton";
            this.TriangleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.TriangleRadioButton.TabIndex = 0;
            this.TriangleRadioButton.Text = "Triangle";
            this.TriangleRadioButton.UseVisualStyleBackColor = true;
            this.TriangleRadioButton.CheckedChanged += new System.EventHandler(this.TriangleRadioButton_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 191);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(244, 191);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FigureAreaLabel
            // 
            this.FigureAreaLabel.AutoSize = true;
            this.FigureAreaLabel.Location = new System.Drawing.Point(173, 121);
            this.FigureAreaLabel.Name = "FigureAreaLabel";
            this.FigureAreaLabel.Size = new System.Drawing.Size(61, 13);
            this.FigureAreaLabel.TabIndex = 16;
            this.FigureAreaLabel.Text = "Figure Area";
            // 
            // FigureAreaTextBox
            // 
            this.FigureAreaTextBox.Location = new System.Drawing.Point(176, 137);
            this.FigureAreaTextBox.Name = "FigureAreaTextBox";
            this.FigureAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.FigureAreaTextBox.TabIndex = 17;
            // 
            // CalculateFigureAreaButton
            // 
            this.CalculateFigureAreaButton.Location = new System.Drawing.Point(176, 164);
            this.CalculateFigureAreaButton.Name = "CalculateFigureAreaButton";
            this.CalculateFigureAreaButton.Size = new System.Drawing.Size(100, 23);
            this.CalculateFigureAreaButton.TabIndex = 18;
            this.CalculateFigureAreaButton.Text = "Calculate Area";
            this.CalculateFigureAreaButton.UseVisualStyleBackColor = true;
            this.CalculateFigureAreaButton.Click += new System.EventHandler(this.CalculateFigureAreaButton_Click);
            // 
            // TriangleGroupBox
            // 
            this.TriangleGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.TriangleGroupBox.Controls.Add(this.HeigthTextBox);
            this.TriangleGroupBox.Controls.Add(this.MainsideTextBox);
            this.TriangleGroupBox.Controls.Add(this.HeigthLabel);
            this.TriangleGroupBox.Controls.Add(this.MainsideLabel);
            this.TriangleGroupBox.Location = new System.Drawing.Point(176, 13);
            this.TriangleGroupBox.Name = "TriangleGroupBox";
            this.TriangleGroupBox.Size = new System.Drawing.Size(149, 105);
            this.TriangleGroupBox.TabIndex = 19;
            this.TriangleGroupBox.TabStop = false;
            this.TriangleGroupBox.Text = "Triangle";
            // 
            // HeigthTextBox
            // 
            this.HeigthTextBox.Location = new System.Drawing.Point(6, 76);
            this.HeigthTextBox.Name = "HeigthTextBox";
            this.HeigthTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeigthTextBox.TabIndex = 3;
            // 
            // MainsideTextBox
            // 
            this.MainsideTextBox.Location = new System.Drawing.Point(6, 37);
            this.MainsideTextBox.Name = "MainsideTextBox";
            this.MainsideTextBox.Size = new System.Drawing.Size(100, 20);
            this.MainsideTextBox.TabIndex = 2;
            // 
            // HeigthLabel
            // 
            this.HeigthLabel.AutoSize = true;
            this.HeigthLabel.Location = new System.Drawing.Point(6, 60);
            this.HeigthLabel.Name = "HeigthLabel";
            this.HeigthLabel.Size = new System.Drawing.Size(38, 13);
            this.HeigthLabel.TabIndex = 1;
            this.HeigthLabel.Text = "Heigth";
            // 
            // MainsideLabel
            // 
            this.MainsideLabel.AutoSize = true;
            this.MainsideLabel.Location = new System.Drawing.Point(6, 20);
            this.MainsideLabel.Name = "MainsideLabel";
            this.MainsideLabel.Size = new System.Drawing.Size(49, 13);
            this.MainsideLabel.TabIndex = 0;
            this.MainsideLabel.Text = "Mainside";
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Controls.Add(this.WidthTextBox);
            this.RectangleGroupBox.Controls.Add(this.LengthTextBox);
            this.RectangleGroupBox.Controls.Add(this.WidthLabel);
            this.RectangleGroupBox.Controls.Add(this.LengthLabel);
            this.RectangleGroupBox.Location = new System.Drawing.Point(331, 13);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Size = new System.Drawing.Size(149, 105);
            this.RectangleGroupBox.TabIndex = 20;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangle";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(6, 76);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 3;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(6, 37);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 2;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(6, 60);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(6, 20);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "Length";
            // 
            // CircleGroupBox
            // 
            this.CircleGroupBox.Controls.Add(this.RadiusTextBox);
            this.CircleGroupBox.Controls.Add(this.RadiusLabel);
            this.CircleGroupBox.Location = new System.Drawing.Point(486, 13);
            this.CircleGroupBox.Name = "CircleGroupBox";
            this.CircleGroupBox.Size = new System.Drawing.Size(149, 105);
            this.CircleGroupBox.TabIndex = 20;
            this.CircleGroupBox.TabStop = false;
            this.CircleGroupBox.Text = "Circle";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(6, 37);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 2;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(6, 20);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Radius";
            // 
            // AddFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 226);
            this.Controls.Add(this.RectangleGroupBox);
            this.Controls.Add(this.TriangleGroupBox);
            this.Controls.Add(this.CircleGroupBox);
            this.Controls.Add(this.CalculateFigureAreaButton);
            this.Controls.Add(this.FigureAreaTextBox);
            this.Controls.Add(this.FigureAreaLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FiguresTypeGroupBox);
            this.Name = "AddFigureForm";
            this.Text = "Add Figure Form";
            this.Load += new System.EventHandler(this.AddFigureForm_Load);
            this.FiguresTypeGroupBox.ResumeLayout(false);
            this.FiguresTypeGroupBox.PerformLayout();
            this.TriangleGroupBox.ResumeLayout(false);
            this.TriangleGroupBox.PerformLayout();
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
            this.CircleGroupBox.ResumeLayout(false);
            this.CircleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FiguresTypeGroupBox;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.RadioButton TriangleRadioButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FigureAreaLabel;
        private System.Windows.Forms.TextBox FigureAreaTextBox;
        private System.Windows.Forms.Button CalculateFigureAreaButton;
        private System.Windows.Forms.GroupBox TriangleGroupBox;
        private System.Windows.Forms.TextBox HeigthTextBox;
        private System.Windows.Forms.TextBox MainsideTextBox;
        private System.Windows.Forms.Label HeigthLabel;
        private System.Windows.Forms.Label MainsideLabel;
        private System.Windows.Forms.GroupBox RectangleGroupBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.GroupBox CircleGroupBox;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label RadiusLabel;
    }
}