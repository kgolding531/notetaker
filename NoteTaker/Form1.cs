using System.Data;

namespace NoteTaker
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable(); // acts as the backend for the data grid view
        bool editing = false; // used for keeping tracking of when the user is editing the note

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title", typeof(string));
            notes.Columns.Add("Note", typeof(string));

            previousNotes.DataSource = notes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /* Statement used to ensure that an unselected note (which is null)
             * does not cause the app to crash (NullPointerException).*/
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note! {0}", ex);
            }
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            noteTextBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = noteTextBox.Text;
            }
            else
            {
                notes.Rows.Add(titleTextBox.Text, noteTextBox.Text);
            }

            titleTextBox.Text = "";
            noteTextBox.Text = "";

            editing = false;
        }

        private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteTextBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();

            editing = true;
        }
    }
}