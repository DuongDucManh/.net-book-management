using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_DuongDucManh
{
    public partial class BookDetailForm : Form
    {
        //detail form is a class,  we declare a book var to connect with the book selected in the Main form
        public Book SelectedBook { get; set; } = null;


        public BookDetailForm()
        {
            InitializeComponent();
        }

        private void BookUpdateForm_Load(object sender, EventArgs e)
        {
            //call when ever this form is open, we call the categoryService to fill the data into the combobox
            BookCategoryService category = new BookCategoryService();
            cboBookCategory.DataSource = category.GetAllCategories();
            cboBookCategory.DisplayMember = "BookGenreType";//what we show in UI
            cboBookCategory.ValueMember = "BookCategoryId";//what we need to store in DB

            //jump to a specific options as default, or match to the current category of a book
            /*cboBookCategory.SelectedValue = 3;*/ //make default value for combobox 
            //if the editedbook is not null, that means this form is called by the grid, we have an actual book to update 
            //We fill the book data into the elements like: txtbox, combobox
            if (SelectedBook != null)
            {
                lblHeader.Text = "Update a selected book";
                //fill in the data
                txtBookId.Enabled = false;
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtBookName.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                cboBookCategory.SelectedValue = SelectedBook.BookCategoryId;
                dtpPublicationDate.Text = SelectedBook.PublicationDate.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtPrice.Text = SelectedBook.Price.ToString();
                txtAuthor.Text = SelectedBook.Author.ToString();
            }
            else 
                lblHeader.Text = "Create a new book";
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Call update method in save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            //We will call the service to help update a book 
            //But at first, we need to create a book with the updated info
            //Not create a new one

            Book book = new Book()
            {
                BookId = int.Parse(txtBookId.Text),
                Author = txtAuthor.Text,
                BookName = txtBookName.Text,
                Description = txtDescription.Text,
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtQuantity.Text),
                Price = double.Parse(txtPrice.Text),
                BookCategoryId = int.Parse(cboBookCategory.SelectedValue.ToString())
            };

            BookService service = new();
            if (SelectedBook != null)
            {
                //edit mode
                service.UpdateBook(book);
            }
            else
            {
                service.CreateBookFromUserInput(book);
            }

            //close
            Close();
        }

        
    }
}
