using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using Model;

namespace ModelForm
{


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

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            //_filePath = "@C:\Users\neshc\Desktop\GitHub";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

            //DataContractSerializer dcs = new DataContractSerializer(typeof(MainForm));
            //XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(_figures);

            var writer = new System.Xml.Serialization.XmlSerializer(typeof(MainForm));

           using (var file = File.Create(_filePath))
            {

                writer.Serialize(file, _figures);

                file.Close();
            }
        }

    }
}
