using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace ModelForm
{
    public partial class MainForm : Form
    {
        private BindingList<IFigure>  _figures = new BindingList<IFigure>();

        public MainForm()
        {
            InitializeComponent();
            FiguresList.DataSource = _figures;
        }

        public BindingList<IFigure> FigureList => _figures;

        /// <summary>
        /// Кнопка "Добавить фигуру"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var addFigure = new AddFigureForm { Owner = this };
            addFigure.ShowDialog();
            if (addFigure.FigureDataList != null)
            {
                _figures.Add(addFigure.FigureDataList);
            }
            FiguresList.DataSource = null;
            FiguresList.DataSource = _figures;

        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in FiguresList.SelectedRows)
            {
                FiguresList.Rows.Remove(row);
            }
        }
    }
}
