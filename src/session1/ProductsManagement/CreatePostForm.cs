using ProductsManagement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsManagement
{
    public partial class CreatePostForm : Form
    {
        PostsRepository _repo;

        public CreatePostForm()
        {
            _repo = new PostsRepository();
            InitializeComponent();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var result = await _repo.CreatePostAsync(new Models.Post
            {
                Title = textBoxTitle.Text,
                Author = texBoxAuthor.Text
            });

            if (result == null)
                MessageBox.Show("error");
            else
                MessageBox.Show($"new Id is {result.Id}");
        }
    }
}
