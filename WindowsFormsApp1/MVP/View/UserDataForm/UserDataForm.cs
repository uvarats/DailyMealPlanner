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
    public partial class UserDataForm : Form, IUDataView
    {

        private readonly List<TextBox> textBoxes;
        public UserDataForm()
        {
            InitializeComponent();
            textBoxes = new List<TextBox>();
            foreach (var control in Controls)
            {
                if (control is TextBox t)
                {
                    textBoxes.Add(t);
                }
            }
        }

        public int Weight { get => int.Parse(weightField.Text); set => weightField.Text = value.ToString(); }
        public int Age { get => int.Parse(ageField.Text); set => ageField.Text = value.ToString(); }
        public UserDataPresenter Presenter { private get; set; }
        public int SelectedActivity { get => activityBox.SelectedIndex; set => activityBox.SelectedIndex = value; }
        public int UHeight { get => int.Parse(heightField.Text); set => heightField.Text = value.ToString(); }
        public IList<string> ActivityBox 
        {
            get => (IList<string>) activityBox.DataSource; 
            set => activityBox.DataSource = value;
        }
        double IUDataView.CurrentDCR
        { 
            get => double.Parse(dcrLabel.Text);
            set 
            {
                dcrLabel.Text = value.ToString();
            }

        }

        private void UserDataForm_Load(object sender, EventArgs e)
        {
            weightField.TextChanged += field_TextChanged;
            heightField.TextChanged += field_TextChanged;
            ageField.TextChanged += field_TextChanged;
            activityBox.SelectedIndexChanged += activityBox_SelectedIndexChanged;
            heightField.KeyPress += weightField_KeyPress;
            ageField.KeyPress += weightField_KeyPress;
        }

        private void weightField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int textBoxesCheck()
        {
            int fieledBoxes = 0;
            foreach (TextBox box in textBoxes)
            {
                if (!string.IsNullOrEmpty(box.Text))
                    fieledBoxes++;
            }
            return fieledBoxes;
        }

        private void field_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            int FieledBoxes = textBoxesCheck();
            
            if (FieledBoxes == textBoxes.Count)
            {
                Presenter.Save();
                Presenter.UpdateUserDataView();
            }
        }

        private void activityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int FieledBoxes = textBoxesCheck();

            if (FieledBoxes == textBoxes.Count)
            {
                Presenter.Save();
                Presenter.UpdateUserDataView();
            }

        }
    }
}
