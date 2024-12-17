namespace LibraryApp
{
    partial class frmToDos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTasks = new DataGridView();
            labelTodoApp = new Label();
            textBoxInput = new TextBox();
            labelDeadline = new Label();
            dateTimePicker = new DateTimePicker();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonExportToPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.BackgroundColor = SystemColors.Control;
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Location = new Point(23, 309);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 82;
            dataGridViewTasks.Size = new Size(713, 414);
            dataGridViewTasks.TabIndex = 0;
            // 
            // labelTodoApp
            // 
            labelTodoApp.AutoSize = true;
            labelTodoApp.Font = new Font("Tahoma", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTodoApp.Location = new Point(23, 29);
            labelTodoApp.Name = "labelTodoApp";
            labelTodoApp.Size = new Size(352, 45);
            labelTodoApp.TabIndex = 1;
            labelTodoApp.Text = "To-Do Application";
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(23, 91);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(713, 50);
            textBoxInput.TabIndex = 2;
            // 
            // labelDeadline
            // 
            labelDeadline.AutoSize = true;
            labelDeadline.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeadline.Location = new Point(23, 157);
            labelDeadline.Name = "labelDeadline";
            labelDeadline.Size = new Size(117, 29);
            labelDeadline.TabIndex = 6;
            labelDeadline.Text = "Deadline";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(23, 190);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(713, 46);
            dateTimePicker.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Gold;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(23, 248);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 46);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Gold;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(23, 729);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 46);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Mark As Done";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExportToPdf
            // 
            buttonExportToPdf.BackColor = Color.Gold;
            buttonExportToPdf.FlatStyle = FlatStyle.Popup;
            buttonExportToPdf.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExportToPdf.Location = new Point(555, 729);
            buttonExportToPdf.Name = "buttonExportToPdf";
            buttonExportToPdf.Size = new Size(181, 46);
            buttonExportToPdf.TabIndex = 10;
            buttonExportToPdf.Text = "Export";
            buttonExportToPdf.UseVisualStyleBackColor = false;
            buttonExportToPdf.Click += buttonExportToPdf_Click;
            // 
            // frmToDos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(755, 787);
            Controls.Add(buttonExportToPdf);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePicker);
            Controls.Add(labelDeadline);
            Controls.Add(textBoxInput);
            Controls.Add(labelTodoApp);
            Controls.Add(dataGridViewTasks);
            Name = "frmToDos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do Application";
            Load += frmToDos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private Label labelTodoApp;
        private TextBox textBoxInput;
        private Label labelDeadline;
        private DateTimePicker dateTimePicker;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonExportToPdf;
    }
}