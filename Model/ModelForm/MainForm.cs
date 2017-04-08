using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace ModelForm
{
    public partial class MainForm : Form
    {
        private readonly BindingList<IFigure> _figures = new BindingList<IFigure>();

        public MainForm()
        {
            InitializeComponent();
            FiguresList.DataSource = _figures;
        }

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
	}
}
