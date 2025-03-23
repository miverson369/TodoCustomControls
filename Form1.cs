using System.Windows.Forms;

namespace TodoCustomControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            // Clear the text in both TextBoxes
            txtTaskDescription.Text = string.Empty;
            txtDueDate.Text = string.Empty;
        }

        private void btnAddTask_Click(object sender, EventArgs e, UserCustomControl userCustomControl)
        {
            // user gets to popup to confirm the add task
            MessageBox.Show($" Add Task {txtDueDate.Text}, {txtTaskDescription.Text}");

            // Clear the text in both TextBoxes after adding the input
            txtDueDate.Text = string.Empty;
            txtTaskDescription.Text = string.Empty;

            {
                // Create an instance of the user control
                UserCustomControl userControl = new UserCustomControl();
                userCustomControl.SetTaskDetails(txtDueDate.Text, txtTaskDescription.Text);
                flowLayoutPanel1.Controls.Add(value: userControl);

            }
        }
    }
}









