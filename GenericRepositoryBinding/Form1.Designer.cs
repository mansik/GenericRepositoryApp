namespace GenericRepository
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
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            pnlContainer = new Panel();
            genderCheckBox = new CheckBox();
            addressTextBox = new TextBox();
            label4 = new Label();
            label6 = new Label();
            ageTextBox = new TextBox();
            label5 = new Label();
            fullNameTextBox = new TextBox();
            label2 = new Label();
            studentIDTextBox = new TextBox();
            label1 = new Label();
            newButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView.Location = new Point(12, 12);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowTemplate.Height = 27;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(480, 426);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "StudentID";
            Column1.HeaderText = "Student ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FullName";
            Column2.HeaderText = "Full Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Gender";
            Column3.HeaderText = "Gender";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Age";
            Column4.HeaderText = "Age";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Address";
            Column5.HeaderText = "Address";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(genderCheckBox);
            pnlContainer.Controls.Add(addressTextBox);
            pnlContainer.Controls.Add(label4);
            pnlContainer.Controls.Add(label6);
            pnlContainer.Controls.Add(ageTextBox);
            pnlContainer.Controls.Add(label5);
            pnlContainer.Controls.Add(fullNameTextBox);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(studentIDTextBox);
            pnlContainer.Controls.Add(label1);
            pnlContainer.Location = new Point(498, 12);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(6);
            pnlContainer.Size = new Size(290, 233);
            pnlContainer.TabIndex = 7;
            // 
            // genderCheckBox
            // 
            genderCheckBox.AutoSize = true;
            genderCheckBox.Location = new Point(93, 75);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(45, 21);
            genderCheckBox.TabIndex = 3;
            genderCheckBox.Text = "???";
            genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressTextBox
            // 
            addressTextBox.BackColor = SystemColors.Window;
            addressTextBox.Location = new Point(87, 136);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(196, 86);
            addressTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 136);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 2;
            label4.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 2;
            label6.Text = "Gender:";
            // 
            // ageTextBox
            // 
            ageTextBox.BackColor = SystemColors.Window;
            ageTextBox.Location = new Point(87, 101);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(196, 25);
            ageTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 105);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 2;
            label5.Text = "Age:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = SystemColors.Window;
            fullNameTextBox.Location = new Point(87, 42);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(196, 25);
            fullNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Fullname:";
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.BackColor = SystemColors.Window;
            studentIDTextBox.Location = new Point(87, 11);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.ReadOnly = true;
            studentIDTextBox.Size = new Size(196, 25);
            studentIDTextBox.TabIndex = 1;
            studentIDTextBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 2;
            label1.Text = "Student ID:";
            // 
            // newButton
            // 
            newButton.Location = new Point(551, 251);
            newButton.Name = "newButton";
            newButton.Size = new Size(75, 25);
            newButton.TabIndex = 8;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(632, 251);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 25);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(713, 251);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 25);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newButton);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(pnlContainer);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel pnlContainer;
        private CheckBox genderCheckBox;
        private TextBox addressTextBox;
        private Label label4;
        private Label label6;
        private TextBox ageTextBox;
        private Label label5;
        private TextBox fullNameTextBox;
        private Label label2;
        private TextBox studentIDTextBox;
        private Label label1;
        private Button newButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}