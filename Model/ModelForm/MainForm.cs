using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace ModelForm
{
    //TODO: gitignor не настроен(?)
    public partial class MainForm : Form
    {
        private bool _isProjectChanged = false;
        //TODO: XMl-комментарий(check)
        /// <summary>
        /// Список фигур
        /// </summary>
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
        /// Кнопка "Добавить фигуру" (отдельная форма)
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

        /// <summary>
        /// Кнопка "Удачить фигуру" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow listRow in FiguresList.SelectedRows)
            {
                FiguresList.Rows.Remove(listRow);
                _isProjectChanged = true;
            }
        }

        /// <summary>
        /// Дебаг кнопка "Добавить случайную фигуру"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenterateRandomFigureButton_Click(object sender, EventArgs e)
        {
#if DEBUG
            var randomFigure = new Random();
            
            var figureType = randomFigure.Next(1, 3);
//TODO: Не по RSDN(check?)
            double randomSideA;
            double randomSideB;
            switch (figureType)
            {
                // Ветка круга
                case 1:
                    var radius = randomFigure.NextDouble() * randomFigure.Next(1, 20);
                    _figures.Add(new Circle(radius));
                    break;

                // Ветка прямоугольника
                case 2:
                    randomSideA = randomFigure.NextDouble() * randomFigure.Next(1, 20);
                    randomSideB = randomFigure.NextDouble() * randomFigure.Next(1, 20);
                    _figures.Add(new Rectangle(randomSideA, randomSideB));
                    break;

                // Ветка треугольника
                case 3:
                    randomSideA = randomFigure.NextDouble() * randomFigure.Next(1, 20);
                    randomSideB = randomFigure.NextDouble() * randomFigure.Next(1, 20);
                    _figures.Add(new Triangle(randomSideA, randomSideB));
                    break;
            }

            FiguresList.DataSource = null;
            FiguresList.DataSource = _figures;
            _isProjectChanged = true;
#endif
        }

        /// <summary>
        /// Кнопка в меню "Сохранить файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FiguresList.RowCount == 0)
            {
                MessageBox.Show("You can not save a list without items","Save Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else
            {//TODO: Не по RSDN(check?)
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "dat files (*.dat)|*.dat";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = false;
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fileStream, _figures);
                        _isProjectChanged = false;
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка в меню "Открыть файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            OpenFileDialog openFileDialog = new OpenFileDialog();

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
                    openFileDialog.ShowDialog();
                }

                if (messageResult == DialogResult.No)
                {
                    openFileDialog.ShowDialog();

                    OpenFile(openFileDialog, formatter);
                }
            }
            else
            {
                openFileDialog.ShowDialog();

                OpenFile(openFileDialog,formatter);
            }
        }

        //TODO: Не по RSDN(check?)
        /// <summary>
        /// Метод проверки наличия имени файла при открытии
        /// </summary>
        /// <param name="_openFileDialog">Диалог открытия файла</param>
        /// <param name="_formatter">Бинарный форматёр</param>
        private void OpenFile(OpenFileDialog _openFileDialog, BinaryFormatter _formatter)
        {
            if (_openFileDialog.FileName != "")
            {
                using (FileStream fileStream = new FileStream(_openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    //TODO: Сериализация повреждённого файла падает(?)
                    BindingList<IFigure> deserializedFigures =
                        (BindingList<IFigure>)_formatter.Deserialize(fileStream);
                    FiguresList.DataSource = deserializedFigures;
                    _figures = deserializedFigures;
                    _isProjectChanged = false;
                }
            }
        }

        /// <summary>
        /// Кнопка "Найти фигуры" (отдельная форма)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindFigureButton_Click(object sender, EventArgs e)
        {
            var fingingFigure = new SearchElementsForm(_figures) { Owner = this };
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

        /// <summary>
        /// Кнопка в меню "Выйти из программы"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((FiguresList.RowCount != 0) &&  (_isProjectChanged))
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
