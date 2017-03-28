using System;
using System.Windows.Forms;

namespace ModelForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int _numberOfFigure = 1;
        private void ButAddFigure_Click(object sender, EventArgs e)
        {
            string[] row1 = {Convert.ToString(_numberOfFigure),"Треугольник", "51.3"};
            _numberOfFigure++;
            dataGridView2.Rows.Add(row1);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButRemoveFigure_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0 && this.dataGridView2.SelectedRows[0].Index != this.dataGridView2.Rows.Count - 1)
            {
                this.dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
            }
        }
    }
}
