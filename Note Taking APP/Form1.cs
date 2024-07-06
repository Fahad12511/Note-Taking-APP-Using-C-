using System.Data;

namespace Note_Taking_APP
{
    public partial class NoteTaking : Form
    {
        DataTable note = new DataTable();
        bool editing = false;
        public NoteTaking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            note.Columns.Add("Title");
            note.Columns.Add("Note");

            previousNotes.DataSource = note;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                note.Rows[previousNotes.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex) { Console.WriteLine("NOt A Vaild Note "); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titlebox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            notebox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                note.Rows[previousNotes.CurrentCell.RowIndex]["title"] = titlebox.Text;
                note.Rows[previousNotes.CurrentCell.RowIndex]["note"] = notebox.Text;
            }
            else
            {
                note.Rows.Add(titlebox.Text, notebox.Text);
            }
            titlebox.Text = "";
            notebox.Text = "";
            editing = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            titlebox.Text = "";
            notebox.Text = "";
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titlebox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            notebox.Text = note.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
