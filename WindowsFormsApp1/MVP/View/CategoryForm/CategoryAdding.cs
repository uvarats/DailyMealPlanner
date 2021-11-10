using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public partial class CategoryAdding : Form, ICategoryView
    {
        public CategoryAdding()
        {
            InitializeComponent();
        }

        public string Description { get => descriptionField.Text; set => descriptionField.Text = value; }

        public CategoryAddingPresenter Presenter { private get; set; }
        public string NameField { get => nameField.Text; set => nameField.Text = value; }

        private void CategoryAdding_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameField))
            {
                Presenter.NewCategory();
                Close();
            }
            else MessageBox.Show("Please, input category name.");
        }
    }
}
