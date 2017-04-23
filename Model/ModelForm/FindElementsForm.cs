using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace ModelForm
{
    public partial class FindElementsForm : Form
    {
        public FindElementsForm(BindingList<IFigure> _figures)
        {
            InitializeComponent();
        }

        private BindingList<IFigure> _findFigures = new BindingList<IFigure>();
        
        
        //if(foreach ())
    }
}
