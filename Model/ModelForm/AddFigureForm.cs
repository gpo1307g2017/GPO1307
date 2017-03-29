using System;
using System.Windows.Forms;


namespace ModelForm
{
    public partial class AddFigureForm : Form
    {
        public AddFigureForm()
        {
            InitializeComponent();
        }

        private void AddFigureForm_Load(object sender, EventArgs e)
        {

        }

        private IFigure _figure;
        public IFigure FigureDataList => _figure;

        /// <summary>
        /// Радие-кнопка "Треугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainsideLabel.Visible = true;
            MainsideTextBox.Visible = true;

            HeightLabel.Visible = true;
            HeigthTextBox.Visible = true;

            RadiusLabel.Visible = false;
            RadiusTextBox.Visible = false;

            LengthLabel.Visible = false;
            LengthTextBox.Visible = false;

            WidthTextBox.Visible = false;
            WidthLabel.Visible = false;



        }

        /// <summary>
        /// Радио-кнопка "Прямоугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainsideLabel.Visible = false;
            MainsideTextBox.Visible = false;

            HeightLabel.Visible = false;
            HeigthTextBox.Visible = false;

            RadiusLabel.Visible = false;
            RadiusTextBox.Visible = false;

            LengthLabel.Visible = true;
            LengthTextBox.Visible = true;

            WidthTextBox.Visible = true;
            WidthLabel.Visible = true;
        }

        /// <summary>
        /// Радио-кнопка "Круг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MainsideLabel.Visible = false;
            MainsideTextBox.Visible = false;

            HeightLabel.Visible = false;
            HeigthTextBox.Visible = false;

            RadiusLabel.Visible = true;
            RadiusTextBox.Visible = true;

            LengthLabel.Visible = false;
            LengthTextBox.Visible = false;

            WidthTextBox.Visible = false;
            WidthLabel.Visible = false;
        }
    }
}
