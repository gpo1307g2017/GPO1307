using System;
using System.Windows.Forms;
using Model;


namespace ModelForm
{
    public partial class AddFigureForm : Form
    {
        private TypesOfFigures _figureType;

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
        /// Радио-кнопка "Треугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           // MainsideLabel.Visible = TriangleGroupBox.SelectedIndex == 0;
            TriangleGroupBox.Visible = true;
            RectangleGroupBox.Visible = false;
            CircleGroupBox.Visible = false;
            _figureType = TypesOfFigures.Triangle;
        }

        /// <summary>
        /// Радио-кнопка "Прямоугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TriangleGroupBox.Visible = false;
            RectangleGroupBox.Visible = true;
            CircleGroupBox.Visible = false;
            _figureType = TypesOfFigures.Rectangle;
        }

        /// <summary>
        /// Радио-кнопка "Круг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TriangleGroupBox.Visible = false;
            RectangleGroupBox.Visible = false;
            CircleGroupBox.Visible = true;
            _figureType = TypesOfFigures.Ring;
        }

        /// <summary>
        /// Кнопка "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        /// <summary>
        /// Кнопка "Calculate Area". Расчёт площади фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateFigureAreaButton_Click(object sender, EventArgs e)
        {
            switch (_figureType)
            {
                case TypesOfFigures.Triangle:
                    double mainside = Convert.ToDouble(MainsideTextBox.Text);
                    double heigth = Convert.ToDouble(HeigthTextBox.Text);
                    _figure = new Triangle(mainside, heigth);
                    _figure.CalculatedArea();
                    FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea());
                    break;

                case TypesOfFigures.Rectangle:
                    double length = Convert.ToDouble(LengthTextBox.Text);
                    double width = Convert.ToDouble(WidthTextBox.Text);
                    _figure = new Rectangle(length, width);
                    FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea());
                    break;

                case TypesOfFigures.Ring:
                    _figure = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                    FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea());
                    break;


            }
        }

        /// <summary>
        /// Кнопка "Close"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            _figure = null;
            Close();
        }
    }
}
