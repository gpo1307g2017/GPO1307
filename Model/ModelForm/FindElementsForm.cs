using System;
using System.ComponentModel;
using System.Windows.Forms;
using Model;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ModelForm
{
    public partial class FindElementsForm : Form
    {
        string _figureType = "";

        private BindingList<IFigure> _findedFigures = new BindingList<IFigure>();
        private BindingList<IFigure> _constFiguresLits = new BindingList<IFigure>();

        public FindElementsForm(BindingList<IFigure> _figures)
        {
            _constFiguresLits = _figures;
            InitializeComponent();
        }

        private void TriangleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _figureType = "Triangle";
            FindElements(_figureType);
        }

        private void RectangleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _figureType = "Rectangle";
            FindElements(_figureType);
        }

        private void CircleRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            _figureType = "Circle";
            FindElements(_figureType);
        }


        private void FindElements(string figureType)
        {
            try
            {
                if (figureType == "")
                {
                    throw new System.NotFiniteNumberException();
                }

            }
            catch (System.NotFiniteNumberException)
            {
                MessageBox.Show("Select a figure type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            _findedFigures = FindingByType(ref _constFiguresLits, _figureType);
            FindingFigureList.DataSource = _findedFigures;
            //FindingFigureList.Sort();
        }

        public static BindingList<IFigure> FindingByType(ref BindingList<IFigure> list, string figureType) =>
            new BindingList<IFigure>(list.Where(figure => figure.TypeFigure == figureType).ToList());

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        //private void FindButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_figureType == "")
        //        {
        //            throw new System.NotFiniteNumberException();
        //        }

        //        if (_constFiguresLits.Count == 0)
        //        {
        //            throw new System.ArgumentException();
        //        }
        //    }
        //    catch (System.NotFiniteNumberException)
        //    {
        //        MessageBox.Show("Select a figure type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (System.ArgumentException)
        //    {
        //        MessageBox.Show("The original list does not have data", "Values Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    _findedFigures = FindingByType(ref _constFiguresLits, _figureType);
        //    FindingFigureList.DataSource = _findedFigures;
        //    FindingFigureList.Sort(delegate ()
        //    {


        //    });
        //}
    }
}
