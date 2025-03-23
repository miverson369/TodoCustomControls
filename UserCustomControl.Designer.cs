namespace TodoCustomControls
{
    partial class UserCustomControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMarkDone = new Button();
            userTaskLabel = new Label();
            userDueDateLabel = new Label();
            txtBoxViewDueDate = new TextBox();
            txtBoxViewTask = new TextBox();
            SuspendLayout();
            // 
            // btnMarkDone
            // 
            btnMarkDone.Location = new Point(233, 18);
            btnMarkDone.Name = "btnMarkDone";
            btnMarkDone.Size = new Size(75, 23);
            btnMarkDone.TabIndex = 0;
            btnMarkDone.Text = "Mark Done";
            btnMarkDone.UseVisualStyleBackColor = true;
            btnMarkDone.Click += btnMarkDone_Click;
            // 
            // userTaskLabel
            // 
            userTaskLabel.AutoSize = true;
            userTaskLabel.Location = new Point(13, 33);
            userTaskLabel.Name = "userTaskLabel";
            userTaskLabel.Size = new Size(32, 15);
            userTaskLabel.TabIndex = 1;
            userTaskLabel.Text = "Task:";
            // 
            // userDueDateLabel
            // 
            userDueDateLabel.AutoSize = true;
            userDueDateLabel.Location = new Point(13, 18);
            userDueDateLabel.Name = "userDueDateLabel";
            userDueDateLabel.Size = new Size(58, 15);
            userDueDateLabel.TabIndex = 2;
            userDueDateLabel.Text = "Due Date:";
            // 
            // txtBoxViewDueDate
            // 
            txtBoxViewDueDate.BorderStyle = BorderStyle.None;
            txtBoxViewDueDate.Location = new Point(87, 18);
            txtBoxViewDueDate.Name = "txtBoxViewDueDate";
            txtBoxViewDueDate.ReadOnly = true;
            txtBoxViewDueDate.Size = new Size(100, 16);
            txtBoxViewDueDate.TabIndex = 3;
            // 
            // txtBoxViewTask
            // 
            txtBoxViewTask.BorderStyle = BorderStyle.None;
            txtBoxViewTask.Location = new Point(13, 51);
            txtBoxViewTask.Name = "txtBoxViewTask";
            txtBoxViewTask.ReadOnly = true;
            txtBoxViewTask.Size = new Size(295, 16);
            txtBoxViewTask.TabIndex = 4;
            // 
            // UserCustomControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtBoxViewTask);
            Controls.Add(txtBoxViewDueDate);
            Controls.Add(userDueDateLabel);
            Controls.Add(userTaskLabel);
            Controls.Add(btnMarkDone);
            Name = "UserCustomControl";
            Size = new Size(328, 96);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMarkDone;
        private Label userTaskLabel;
        private Label userDueDateLabel;
        private TextBox txtBoxViewDueDate;
        private TextBox txtBoxViewTask;
    }
}
