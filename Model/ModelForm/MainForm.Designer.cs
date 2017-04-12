namespace ModelForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguresGroupBox = new System.Windows.Forms.GroupBox();
            this.FiguresList = new System.Windows.Forms.DataGridView();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.RemoveFigureButton = new System.Windows.Forms.Button();
            this.FindFigureButton = new System.Windows.Forms.Button();
            this.GenterateRandomFigureButton = new System.Windows.Forms.Button();
            this.FileToolStrip.SuspendLayout();
            this.FiguresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiguresList)).BeginInit();
            this.SuspendLayout();
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.FileToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(359, 25);
            this.FileToolStrip.TabIndex = 0;
            this.FileToolStrip.Text = "File";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FiguresGroupBox
            // 
            this.FiguresGroupBox.Controls.Add(this.FiguresList);
            this.FiguresGroupBox.Location = new System.Drawing.Point(12, 28);
            this.FiguresGroupBox.Name = "FiguresGroupBox";
            this.FiguresGroupBox.Size = new System.Drawing.Size(335, 152);
            this.FiguresGroupBox.TabIndex = 1;
            this.FiguresGroupBox.TabStop = false;
            this.FiguresGroupBox.Text = "Figures";
            // 
            // FiguresList
            // 
            this.FiguresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiguresList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiguresList.Location = new System.Drawing.Point(3, 16);
            this.FiguresList.Name = "FiguresList";
            this.FiguresList.Size = new System.Drawing.Size(329, 133);
            this.FiguresList.TabIndex = 0;
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(15, 187);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(93, 23);
            this.AddFigureButton.TabIndex = 2;
            this.AddFigureButton.Text = "Add Figure";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // RemoveFigureButton
            // 
            this.RemoveFigureButton.Location = new System.Drawing.Point(15, 216);
            this.RemoveFigureButton.Name = "RemoveFigureButton";
            this.RemoveFigureButton.Size = new System.Drawing.Size(93, 23);
            this.RemoveFigureButton.TabIndex = 3;
            this.RemoveFigureButton.Text = "Remove Figure";
            this.RemoveFigureButton.UseVisualStyleBackColor = true;
            this.RemoveFigureButton.Click += new System.EventHandler(this.RemoveFigureButton_Click);
            // 
            // FindFigureButton
            // 
            this.FindFigureButton.Location = new System.Drawing.Point(114, 187);
            this.FindFigureButton.Name = "FindFigureButton";
            this.FindFigureButton.Size = new System.Drawing.Size(93, 23);
            this.FindFigureButton.TabIndex = 4;
            this.FindFigureButton.Text = "Find Figure";
            this.FindFigureButton.UseVisualStyleBackColor = true;
            // 
            // GenterateRandomFigureButton
            // 
            this.GenterateRandomFigureButton.Location = new System.Drawing.Point(114, 216);
            this.GenterateRandomFigureButton.Name = "GenterateRandomFigureButton";
            this.GenterateRandomFigureButton.Size = new System.Drawing.Size(93, 23);
            this.GenterateRandomFigureButton.TabIndex = 5;
            this.GenterateRandomFigureButton.Text = "RandomFigure";
            this.GenterateRandomFigureButton.UseVisualStyleBackColor = true;
            this.GenterateRandomFigureButton.Click += new System.EventHandler(this.GenterateRandomFigureButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.GenterateRandomFigureButton);
            this.Controls.Add(this.FindFigureButton);
            this.Controls.Add(this.RemoveFigureButton);
            this.Controls.Add(this.AddFigureButton);
            this.Controls.Add(this.FiguresGroupBox);
            this.Controls.Add(this.FileToolStrip);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FileToolStrip.ResumeLayout(false);
            this.FileToolStrip.PerformLayout();
            this.FiguresGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FiguresList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip FileToolStrip;
        private System.Windows.Forms.GroupBox FiguresGroupBox;
        private System.Windows.Forms.DataGridView FiguresList;
        private System.Windows.Forms.Button AddFigureButton;
        private System.Windows.Forms.Button RemoveFigureButton;
        private System.Windows.Forms.Button FindFigureButton;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button GenterateRandomFigureButton;
    }
}