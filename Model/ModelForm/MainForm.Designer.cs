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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiguresGroupBox = new System.Windows.Forms.GroupBox();
            this.FiguresList = new System.Windows.Forms.DataGridView();
            this.AddFigureButton = new System.Windows.Forms.Button();
            this.RemoveFigureButton = new System.Windows.Forms.Button();
            this.FindFigureButton = new System.Windows.Forms.Button();
            this.GenterateRandomFigureButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExinButton = new System.Windows.Forms.Button();
            this.FileToolStrip.SuspendLayout();
            this.FiguresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiguresList)).BeginInit();
            this.SuspendLayout();
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FileToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.FileToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(396, 25);
            this.FileToolStrip.TabIndex = 0;
            this.FileToolStrip.Text = "File";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // FiguresGroupBox
            // 
            this.FiguresGroupBox.Controls.Add(this.FiguresList);
            this.FiguresGroupBox.Location = new System.Drawing.Point(114, 28);
            this.FiguresGroupBox.Name = "FiguresGroupBox";
            this.FiguresGroupBox.Size = new System.Drawing.Size(270, 307);
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
            this.FiguresList.Size = new System.Drawing.Size(264, 288);
            this.FiguresList.TabIndex = 0;
            // 
            // AddFigureButton
            // 
            this.AddFigureButton.Location = new System.Drawing.Point(12, 28);
            this.AddFigureButton.Name = "AddFigureButton";
            this.AddFigureButton.Size = new System.Drawing.Size(93, 23);
            this.AddFigureButton.TabIndex = 2;
            this.AddFigureButton.Text = "Add Figure";
            this.AddFigureButton.UseVisualStyleBackColor = true;
            this.AddFigureButton.Click += new System.EventHandler(this.AddFigureButton_Click);
            // 
            // RemoveFigureButton
            // 
            this.RemoveFigureButton.Location = new System.Drawing.Point(12, 57);
            this.RemoveFigureButton.Name = "RemoveFigureButton";
            this.RemoveFigureButton.Size = new System.Drawing.Size(93, 23);
            this.RemoveFigureButton.TabIndex = 3;
            this.RemoveFigureButton.Text = "Remove Figure";
            this.RemoveFigureButton.UseVisualStyleBackColor = true;
            this.RemoveFigureButton.Click += new System.EventHandler(this.RemoveFigureButton_Click);
            // 
            // FindFigureButton
            // 
            this.FindFigureButton.Location = new System.Drawing.Point(12, 86);
            this.FindFigureButton.Name = "FindFigureButton";
            this.FindFigureButton.Size = new System.Drawing.Size(93, 23);
            this.FindFigureButton.TabIndex = 4;
            this.FindFigureButton.Text = "Find Figure";
            this.FindFigureButton.UseVisualStyleBackColor = true;
            this.FindFigureButton.Click += new System.EventHandler(this.FindFigureButton_Click);
            // 
            // GenterateRandomFigureButton
            // 
            this.GenterateRandomFigureButton.Location = new System.Drawing.Point(12, 115);
            this.GenterateRandomFigureButton.Name = "GenterateRandomFigureButton";
            this.GenterateRandomFigureButton.Size = new System.Drawing.Size(93, 23);
            this.GenterateRandomFigureButton.TabIndex = 5;
            this.GenterateRandomFigureButton.Text = "RandomFigure";
            this.GenterateRandomFigureButton.UseVisualStyleBackColor = true;
            this.GenterateRandomFigureButton.Visible = false;
            this.GenterateRandomFigureButton.Click += new System.EventHandler(this.GenterateRandomFigureButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ExinButton
            // 
            this.ExinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExinButton.Location = new System.Drawing.Point(12, 296);
            this.ExinButton.Name = "ExinButton";
            this.ExinButton.Size = new System.Drawing.Size(93, 39);
            this.ExinButton.TabIndex = 6;
            this.ExinButton.Text = "Exit";
            this.ExinButton.UseVisualStyleBackColor = true;
            this.ExinButton.Click += new System.EventHandler(this.ExinButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 347);
            this.Controls.Add(this.ExinButton);
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
        private System.Windows.Forms.Button GenterateRandomFigureButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ExinButton;
    }
}