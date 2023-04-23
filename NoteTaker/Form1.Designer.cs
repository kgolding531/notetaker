namespace NoteTaker
{
    partial class NoteTaker
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
            titleTextBox = new TextBox();
            noteTextBox = new TextBox();
            titleLabel = new Label();
            noteLabel = new Label();
            previousNotes = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            newNoteButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(564, 44);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(514, 31);
            titleTextBox.TabIndex = 0;
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(564, 109);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(514, 558);
            noteTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(564, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(514, 29);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // noteLabel
            // 
            noteLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            noteLabel.Location = new Point(564, 78);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(514, 28);
            noteLabel.TabIndex = 3;
            noteLabel.Text = "Note:";
            noteLabel.TextAlign = ContentAlignment.MiddleLeft;
            noteLabel.Click += label2_Click;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 12);
            previousNotes.Name = "previousNotes";
            previousNotes.RowHeadersWidth = 62;
            previousNotes.RowTemplate.Height = 33;
            previousNotes.Size = new Size(528, 498);
            previousNotes.TabIndex = 4;
            previousNotes.CellContentClick += previousNotes_CellContentClick;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.White;
            loadButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loadButton.Location = new Point(12, 533);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(254, 60);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(286, 533);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(254, 60);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.White;
            newNoteButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            newNoteButton.Location = new Point(12, 607);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(254, 60);
            newNoteButton.TabIndex = 5;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(286, 607);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(254, 60);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(1090, 679);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newNoteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNotes);
            Controls.Add(noteLabel);
            Controls.Add(titleLabel);
            Controls.Add(noteTextBox);
            Controls.Add(titleTextBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "NoteTaker";
            Text = "NoteTaker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox noteTextBox;
        private Label titleLabel;
        private Label noteLabel;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button newNoteButton;
        private Button saveButton;
    }
}