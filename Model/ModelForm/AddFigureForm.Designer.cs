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
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.MainsideLabel = new System.Windows.Forms.Label();
            this.HeigthLabel = new System.Windows.Forms.Label();
            this.MainsideTextBox = new System.Windows.Forms.TextBox();
            this.HeigthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.FiguresTypeGroupBox.SuspendLayout();
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
            this.OKButton.Location = new System.Drawing.Point(13, 205);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 11;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(205, 205);
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
            this.FigureAreaLabel.Location = new System.Drawing.Point(155, 105);
            this.FigureAreaLabel.Name = "FigureAreaLabel";
            this.FigureAreaLabel.Size = new System.Drawing.Size(61, 13);
            this.FigureAreaLabel.TabIndex = 16;
            this.FigureAreaLabel.Text = "Figure Area";
            // 
            // FigureAreaTextBox
            // 
            this.FigureAreaTextBox.Location = new System.Drawing.Point(158, 121);
            this.FigureAreaTextBox.Name = "FigureAreaTextBox";
            this.FigureAreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.FigureAreaTextBox.TabIndex = 17;
            // 
            // CalculateFigureAreaButton
            // 
            this.CalculateFigureAreaButton.Location = new System.Drawing.Point(158, 148);
            this.CalculateFigureAreaButton.Name = "CalculateFigureAreaButton";
            this.CalculateFigureAreaButton.Size = new System.Drawing.Size(100, 23);
            this.CalculateFigureAreaButton.TabIndex = 18;
            this.CalculateFigureAreaButton.Text = "Calculate Area";
            this.CalculateFigureAreaButton.UseVisualStyleBackColor = true;
            this.CalculateFigureAreaButton.Click += new System.EventHandler(this.CalculateFigureAreaButton_Click);
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(158, 13);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Radius";
            this.RadiusLabel.Visible = false;
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(158, 30);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 2;
            this.RadiusTextBox.Visible = false;
            // 
            // MainsideLabel
            // 
            this.MainsideLabel.AutoSize = true;
            this.MainsideLabel.Location = new System.Drawing.Point(158, 14);
            this.MainsideLabel.Name = "MainsideLabel";
            this.MainsideLabel.Size = new System.Drawing.Size(49, 13);
            this.MainsideLabel.TabIndex = 0;
            this.MainsideLabel.Text = "Mainside";
            this.MainsideLabel.Visible = false;
            // 
            // HeigthLabel
            // 
            this.HeigthLabel.AutoSize = true;
            this.HeigthLabel.Location = new System.Drawing.Point(158, 54);
            this.HeigthLabel.Name = "HeigthLabel";
            this.HeigthLabel.Size = new System.Drawing.Size(38, 13);
            this.HeigthLabel.TabIndex = 1;
            this.HeigthLabel.Text = "Heigth";
            this.HeigthLabel.Visible = false;
            // 
            // MainsideTextBox
            // 
            this.MainsideTextBox.Location = new System.Drawing.Point(158, 31);
            this.MainsideTextBox.Name = "MainsideTextBox";
            this.MainsideTextBox.Size = new System.Drawing.Size(100, 20);
            this.MainsideTextBox.TabIndex = 2;
            this.MainsideTextBox.Visible = false;
            // 
            // HeigthTextBox
            // 
            this.HeigthTextBox.Location = new System.Drawing.Point(158, 70);
            this.HeigthTextBox.Name = "HeigthTextBox";
            this.HeigthTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeigthTextBox.TabIndex = 3;
            this.HeigthTextBox.Visible = false;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(158, 13);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "Length";
            this.LengthLabel.Visible = false;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(158, 53);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.Visible = false;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(158, 30);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 2;
            this.LengthTextBox.Visible = false;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(158, 69);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 3;
            this.WidthTextBox.Visible = false;
            // 
            // AddFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 240);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.HeigthTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.MainsideTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.HeigthLabel);
            this.Controls.Add(this.MainsideLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LengthLabel);
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
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label MainsideLabel;
        private System.Windows.Forms.Label HeigthLabel;
        private System.Windows.Forms.TextBox MainsideTextBox;
        private System.Windows.Forms.TextBox HeigthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
    }
}