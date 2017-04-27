using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Model;
using System.Runtime.Serialization.Formatters.Binary;
using ModelForm;

namespace ModelForm
{
    public partial class MainForm : Form
    {
        private bool _isProjectChanged = false;
        
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
                _isProjectChanged = true;
            }

        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow listRow in FiguresList.SelectedRows)
            {
                FiguresList.Rows.Remove(listRow);
                _isProjectChanged = true;
            }
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
            _isProjectChanged = true;
#endif
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FiguresList.RowCount == 0)
            {
                MessageBox.Show("You can not save a list without items");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "dat files (*.dat)|*.dat";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = false;
                sfd.ShowDialog();

                if (sfd.FileName != "")
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    using (FileStream fileStream = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fileStream, _figures);
                        _isProjectChanged = false;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           BinaryFormatter formatter = new BinaryFormatter();
            OpenFileDialog ofd = new OpenFileDialog();

            if (FiguresList.RowCount != 0)
            {
                const string message = "You have unsaved data left. Do you want to save them before opening other data?";
                const string caption = "Save before open";
                var messageResult = MessageBox.Show(message, caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (messageResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender,e);
                    ofd.ShowDialog();
                }

                if (messageResult == DialogResult.No)
                {
                    ofd.ShowDialog();

                    OpenFile(ofd, formatter);
                }
            }
            else
            {
                ofd.ShowDialog();

                OpenFile(ofd,formatter);
            }
        }

        private void OpenFile(OpenFileDialog _ofd, BinaryFormatter _formatter)
        {
            if (_ofd.FileName != "")
            {
                using (FileStream fileStream = new FileStream(_ofd.FileName, FileMode.OpenOrCreate))
                {
                    BindingList<IFigure> deserializedFigures =
                        (BindingList<IFigure>)_formatter.Deserialize(fileStream);
                    FiguresList.DataSource = deserializedFigures;
                    _figures = deserializedFigures;
                    _isProjectChanged = false;
                }
            }
        }

        private void FindFigureButton_Click(object sender, EventArgs e)
        {
            var fingingFigure = new FindElementsForm(_figures) { Owner = this };
            try
            {
                if (_figures.Count == 0)
                {
                    throw new System.ArgumentException();
                }
                
                fingingFigure.ShowDialog();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("The original list does not have data", "Values Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
        
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isProjectChanged)
            {
                const string message = "You have unsaved data left. Do you want to save them before closing program?";
                const string caption = "Save before close";
                var messageResult = MessageBox.Show(message, caption,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (messageResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    Close();
                }

                if (messageResult == DialogResult.No)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

    }
}
