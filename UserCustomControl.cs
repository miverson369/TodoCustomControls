using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoCustomControls
{
    public partial class UserCustomControl : UserControl

    {

        private readonly object txtViewDueDate;
        private readonly object txtViewTaskDescription;

    
        public UserCustomControl()
        {
            InitializeComponent();
        }
        private void btnMarkDone_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Yay! you did it!");
        this.Parent.Controls.Remove(this);
        }

        public void SetTaskDetails(string dueDate, string taskDescription, string taskId)
        {
            SetTaskDetails(dueDate, taskDescription, taskId, txtViewTaskDescription);
        }

        public void SetTaskDetails(string dueDate, string taskDescription, string taskId, object txtViewTaskDescription)
        {
            NewMethod(dueDate);
            txtViewTaskDescription = taskDescription;
        }

        private void NewMethod(string dueDate)
        {
            NewMethod(dueDate, txtViewDueDate);
        }

        private void NewMethod(string dueDate, object txtViewDueDate)
        {
            txtViewDueDate = dueDate;
        }

        private void MarkDoneButton_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            txtBoxViewDueDate.Text = string.Empty;
            txtBoxViewTask.Text = string.Empty;
       
        }
        internal static void SetTaskDetails(Func<string> toString, string text)
        {
            throw new NotImplementedException();
        
        }

        internal void SetTaskDetails(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
