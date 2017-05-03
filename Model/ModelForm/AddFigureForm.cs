using System;
using System.Windows.Forms;
using Model;


namespace ModelForm
{
    //TODO: Падает при нажатии на CalculateArea при пустых полях
    //TODO: Вводим символы, можно нажать на ОК, это не правильно
    public partial class AddFigureForm : Form
    {
        //TODO: XMl-комментарий
        private TypesOfFigures _figureType;

        public AddFigureForm()
        {
            InitializeComponent();
        }

        private void AddFigureForm_Load(object sender, EventArgs e)
        {
            //TODO: Пустой обработчик
        }

        private IFigure _figure;
        //TODO: XMl-комментарий
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
                //TODO: Длинная строка
                MessageBox.Show("Before adding a figure, calculated its area ","Add figure Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        //TODO: XMl-комментарий, не надо привязываться к названию кнопки. Комментарий некорректный.
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
        /// Кнопка "Закрыть форму"
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
