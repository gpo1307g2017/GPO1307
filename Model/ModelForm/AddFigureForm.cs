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
        public IFigure FigureData => _figure;

        /// <summary>
        /// Радио-кнопка "Треугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChoseFigureLabel.Visible = false;

            MainsideLabel.Visible = true;
            MainsideTextBox.Visible = true;

            HeigthLabel.Visible = true;
            HeigthTextBox.Visible = true;
            
            RadiusLabel.Visible = false;
            RadiusTextBox.Visible = false;
            
            LengthLabel.Visible = false;
            LengthTextBox.Visible = false;
            
            WidthTextBox.Visible = false;
            WidthLabel.Visible = false;
            _figureType = TypesOfFigures.Triangle;
        }

        /// <summary>
        /// Радио-кнопка "Прямоугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChoseFigureLabel.Visible = false;

            MainsideLabel.Visible = false;
            MainsideTextBox.Visible = false;
            
            HeigthLabel.Visible = false;
            HeigthTextBox.Visible = false;
            
            RadiusLabel.Visible = false;
            RadiusTextBox.Visible = false;
            
            LengthLabel.Visible = true;
            LengthTextBox.Visible = true;
            
            WidthTextBox.Visible = true;
            WidthLabel.Visible = true;
            _figureType = TypesOfFigures.Rectangle;
        }

        /// <summary>
        /// Радио-кнопка "Круг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChoseFigureLabel.Visible = false;

            MainsideLabel.Visible = false;
            MainsideTextBox.Visible = false;
            
            HeigthLabel.Visible = false;
            HeigthTextBox.Visible = false;
            
            RadiusLabel.Visible = true;
            RadiusTextBox.Visible = true;
            
            LengthLabel.Visible = false;
            LengthTextBox.Visible = false;
            
            WidthTextBox.Visible = false;
            WidthLabel.Visible = false;
            _figureType = TypesOfFigures.Ring;
        }

        /// <summary>
        /// Кнопка "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (FigureAreaTextBox.Text == "")
            {
                MessageBox.Show("Before adding a figure, calculated its area ","Add figure Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
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
                    FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea);
                    break;

                case TypesOfFigures.Rectangle:
                    double length = Convert.ToDouble(LengthTextBox.Text);
                    double width = Convert.ToDouble(WidthTextBox.Text);
                    _figure = new Rectangle(length, width);
                    FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea);
                    break;

                case TypesOfFigures.Ring:
                    _figure = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                    FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea);
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
