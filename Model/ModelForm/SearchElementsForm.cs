using System.ComponentModel;
using System.Windows.Forms;
using Model;
using System.Linq;

namespace ModelForm
{
    public partial class SearchElementsForm : Form
    {
        //TODO: Не по RSDN(check?)
        //TODO: Плохо использовать строковые ключи(check)
         private FigureType _figureType;


        private BindingList<IFigure> _findedFiguresList = new BindingList<IFigure>();

        private readonly BindingList<IFigure> _constFiguresLits;

        //TODO: XMl-комментарий(check?)
        //TODO: Не по RSDN(check)
        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="_figures">Начальный список фигур в котором мы осуществляем поиск</param>
        public SearchElementsForm(BindingList<IFigure> _figures)
        {
            _constFiguresLits = _figures;
            InitializeComponent();
        }

        /// <summary>
        /// Радио-кнопка "Треугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriangleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _figureType = FigureType.Triangle;
            FindElements(_figureType);
        }

        /// <summary>
        /// Радио-кнопка "Прямоугольник"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectangleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _figureType = FigureType.Rectangle;
            FindElements(_figureType);
        }

        /// <summary>
        /// Радио-кнопка "Круг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _figureType = FigureType.Circle;
            FindElements(_figureType);
        }
        //TODO: XMl-комментарий(check?)
        /// <summary>
        /// Метод поиска фигур
        /// </summary>
        /// <param name="figureType">Тип фигуры</param>
        private void FindElements(FigureType figureType)
        {
            //TODO: Не по RSDN(check?)
            _findedFiguresList =
                new BindingList<IFigure>(_constFiguresLits.Where(figure => figure.TypeFigure == _figureType).ToList());
            FindingFigureList.DataSource = _findedFiguresList;
        }


        /// <summary>
        /// Кнопка "Закрыть форму"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
