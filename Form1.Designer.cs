namespace TodoCustomControls
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBox1 = new GroupBox();
            btnAddTask = new Button();
            btnClearForm = new Button();
            txtDueDate = new TextBox();
            txtTaskDescription = new TextBox();
            DueDateLabel = new Label();
            TaskLabel = new Label();
            grpBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            grpBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpBox1
            // 
            grpBox1.Controls.Add(btnAddTask);
            grpBox1.Controls.Add(btnClearForm);
            grpBox1.Controls.Add(txtDueDate);
            grpBox1.Controls.Add(txtTaskDescription);
            grpBox1.Controls.Add(DueDateLabel);
            grpBox1.Controls.Add(TaskLabel);
            grpBox1.FlatStyle = FlatStyle.Flat;
            grpBox1.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBox1.Location = new Point(12, 27);
            grpBox1.Name = "grpBox1";
            grpBox1.Size = new Size(435, 133);
            grpBox1.TabIndex = 0;
            grpBox1.TabStop = false;
            grpBox1.Text = "Task Form";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(330, 105);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(87, 21);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Todo";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(237, 105);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(87, 21);
            btnClearForm.TabIndex = 3;
            btnClearForm.Text = "Clear";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(118, 66);
            txtDueDate.MaxLength = 100;
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(299, 23);
            txtDueDate.TabIndex = 2;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(118, 35);
            txtTaskDescription.MaxLength = 100;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(299, 23);
            txtTaskDescription.TabIndex = 1;
            // 
            // DueDateLabel
            // 
            DueDateLabel.AutoSize = true;
            DueDateLabel.Location = new Point(17, 72);
            DueDateLabel.Name = "DueDateLabel";
            DueDateLabel.Size = new Size(56, 17);
            DueDateLabel.TabIndex = 1;
            DueDateLabel.Text = "Due Date";
            // 
            // TaskLabel
            // 
            TaskLabel.AutoSize = true;
            TaskLabel.Location = new Point(17, 41);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(32, 17);
            TaskLabel.TabIndex = 0;
            TaskLabel.Text = "Task";
            // 
            // grpBox2
            // 
            grpBox2.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBox2.Location = new Point(12, 178);
            grpBox2.Name = "grpBox2";
            grpBox2.Size = new Size(435, 466);
            grpBox2.TabIndex = 1;
            grpBox2.TabStop = false;
            grpBox2.Text = "Task List";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(435, 422);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 653);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(grpBox2);
            Controls.Add(grpBox1);
            Name = "Form1";
            Text = "Form1";
            grpBox1.ResumeLayout(false);
            grpBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBox1;
        private Label TaskLabel;
        private Label DueDateLabel;
        private Button btnAddTask;
        private Button btnClearForm;
        private TextBox txtDueDate;
        private TextBox txtTaskDescription;
        private GroupBox grpBox2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
