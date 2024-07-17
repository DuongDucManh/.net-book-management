using Repositories.Entities;
using Services;

namespace BookManagement_DuongDucManh
{
    public partial class BookManager : Form
    {
        private Book _selected = null;
        private BookService _service = new BookService();
        public BookManager()
        {
            InitializeComponent();
        }

        //A method to refresh the grid
        private void RefreshDataGridView()
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _service.GetAllBooks();
        }
        public void BookManager_Load(object sender, EventArgs e)
        {
            dgvBookList.DataSource = _service.GetAllBooks();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if user clicks on the [Create book] button --> we show the empty detail form with category is filled in already
            BookDetailForm detail = new BookDetailForm();
            detail.ShowDialog();
            //the form closed, we fresh the grid
            RefreshDataGridView();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            //if user chooses a row, we will show a message, not a cell
            if (dgvBookList.SelectedRows.Count > 0)
            {
                // MessageBox.Show("XD, fck select row");
                //each row of this table 
                _selected = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            }
            //Event programming - PUB/SUB model 
            //                    publish/sublish 
            //
        }

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(book.BookId + " | " + book.BookName + " | " + book.Description + " | " + book.BookCategoryId);
            if (_selected != null)
            {
                BookDetailForm detail = new BookDetailForm();
                detail.SelectedBook = _selected; // patse the selected book to the detail form
                detail.ShowDialog();
                //refresh the grid
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a certain book to edit", "Select one book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get 2 string in txtBookName and txtDescription
            var books = new BookService().GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = books.Where(
                    book => book.BookName.ToLower().Contains(txtBookName.Text.ToLower()) || book.Description.ToLower().Contains(txtDescription.Text.ToLower())
                ).ToList();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_selected != null)
            {
                DialogResult answer = MessageBox.Show("Really want to delete it?","Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(answer == DialogResult.No)
                {
                    return;//do nothing
                }


                _service.DeleteBookFromUserSelected(_selected);
                //refresh grid
                RefreshDataGridView();
                _selected = null;//the book is deleted -> refresh _selected to null
            }
        }
    }
}
