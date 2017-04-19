﻿using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModelForm
{

    //[Serializable]
    public partial class MainForm : Form
    {
        
        private BindingList<IFigure> _figures = new BindingList<IFigure>();

        public MainForm()
        {
            InitializeComponent();
            FiguresList.DataSource = _figures;

#if DEBUG
            GenterateRandomFigureButton.Visible = true;
#endif

        }

        /// <summary>
        /// Кнопка "Добавить фигуру"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var addFigure = new AddFigureForm {Owner = this};
            addFigure.ShowDialog();
            if (addFigure.FigureData != null)
            {
                _figures.Add(addFigure.FigureData);
            }

        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow listRow in FiguresList.SelectedRows)
            {
                FiguresList.Rows.Remove(listRow);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void GenterateRandomFigureButton_Click(object sender, EventArgs e)
        {
#if DEBUG
            var randomFigure = new Random();

            var figureType = randomFigure.Next(0, 3);
            double EstimatedSideA;
            double EstimatedSideB;
            switch (figureType)
            {
                case 0:
                    var radius = randomFigure.NextDouble() * randomFigure.Next(1, 11);
                    _figures.Add(new Circle(radius));
                    break;
                case 1:
                    EstimatedSideA = randomFigure.NextDouble() * randomFigure.Next(1, 11);
                    EstimatedSideB = randomFigure.NextDouble() * randomFigure.Next(1, 11);
                    _figures.Add(new Rectangle(EstimatedSideA, EstimatedSideB));
                    break;
                case 2:
                    EstimatedSideA = randomFigure.NextDouble() * randomFigure.Next(1, 11);
                    EstimatedSideB = randomFigure.NextDouble() * randomFigure.Next(1, 11);
                    _figures.Add(new Triangle(EstimatedSideA, EstimatedSideB));
                    break;
            }

            FiguresList.DataSource = null;
            FiguresList.DataSource = _figures;
#endif
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _filePath = null;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.ShowDialog();


            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, _figures);
            }


            
        }

    }
}
