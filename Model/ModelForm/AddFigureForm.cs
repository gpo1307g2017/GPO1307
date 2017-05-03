using System;
using System.Windows.Forms;
using Model;
using NUnit.Framework.Constraints;


namespace ModelForm
{
    //TODO: Падает при нажатии на CalculateArea при пустых полях
    public partial class AddFigureForm : Form
    {
        //TODO: XMl-комментарий
        private FigureType _figureType;

        public AddFigureForm()
        {
            InitializeComponent();
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
            FigureAreaTextBox.Text = string.Empty;

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
            _figureType = FigureType.Triangle;
        }

        /// <summary>
        /// Радио-кнопка "Прямоугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FigureAreaTextBox.Text = string.Empty;

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
            _figureType = FigureType.Rectangle;
        }

        /// <summary>
        /// Радио-кнопка "Круг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FigureAreaTextBox.Text = string.Empty;

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
            _figureType = FigureType.Ring;
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
                MessageBox.Show("Before adding a figure, calculated its area ","Add figure Error"
                 ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        //TODO: XMl-комментарий, не надо привязываться к названию кнопки. Комментарий некорректный.
        /// <summary>
        /// Кнопка "Calculate Area".
        /// Расчитываем площадь выбранной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateFigureAreaButton_Click(object sender, EventArgs e)
        {
            switch (_figureType)
            {
                case FigureType.Triangle:
                    if (IsTextBoxEmptyCheck(MainsideTextBox.Text) || IsTextBoxEmptyCheck(HeigthTextBox.Text))
                    {
                        MessageBox.Show("Before calculating the area, enter the values of the sides ",
                            "Calculating Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double mainside = Convert.ToDouble(MainsideTextBox.Text);
                        double heigth = Convert.ToDouble(HeigthTextBox.Text);
                        _figure = new Triangle(mainside, heigth);
                        FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea);
                    }
                    break;
                case FigureType.Rectangle:
                    if (IsTextBoxEmptyCheck(LengthTextBox.Text) || IsTextBoxEmptyCheck(WidthTextBox.Text))
                    {
                        MessageBox.Show("Before calculating the area, enter the values of the sides ",
                            "Calculating Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        double length = Convert.ToDouble(LengthTextBox.Text);
                        double width = Convert.ToDouble(WidthTextBox.Text);
                        _figure = new Rectangle(length, width);
                        FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea);
                    }
                    break;

                case FigureType.Ring:
                    if (IsTextBoxEmptyCheck(RadiusTextBox.Text))
                    {
                        MessageBox.Show("Before calculating the area, enter the values of the sides ",
                            "Calculating Area Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        _figure = new Circle(Convert.ToDouble(RadiusTextBox.Text));
                        FigureAreaTextBox.Text = Convert.ToString(_figure.CalculatedArea);
                    }
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

        /// <summary>
        /// Событие на исключение ввода символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param Поле TextBox="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 44) && (e.KeyChar != 8) && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param Текст в TextBox ="Text"></param>
        /// <returns></returns>
        public bool IsTextBoxEmptyCheck(string Text)
        {
            if (Text == string.Empty)
                return true;

            return false;
        }
    }
}
