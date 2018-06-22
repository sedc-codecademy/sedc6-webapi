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
    public partial class Form1 : Form
    {
        private readonly PostsRepository _productsRepo;

        public Form1()
        {
            _productsRepo = new PostsRepository();
            InitializeComponent();
        }
        
        private async void seeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = await _productsRepo.GetAllPostsAsync();
            MainGrid.DataSource = data;
        }

        private void seeAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CreatePostForm();
            form.Show();
        }
    }
}
