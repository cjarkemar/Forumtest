using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forumtest
{
    public partial class MainForum : Form
    {
        public MainForum()
        {
            InitializeComponent();
        }

        private void CreatePostButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the CreatePost form
            CreatePost createPostForm = new CreatePost();

            // Show the CreatePost form as a modal dialog
            DialogResult result = createPostForm.ShowDialog();

            // If the user clicked the OK button, add the post to the list of posts
            if (result == DialogResult.OK)
            {
                // Get the title and message from the CreatePost form
                string genre = (string)ComboBox1.SelectedItem;
                string title = createPostForm.TitleTextBox.Text;
                string message = createPostForm.MessageTextBox.Text;
                string timeStamp = DateTime.Now.ToString();
                // Add the post to the list of posts
                PostList.Items.Add(timeStamp + " " + genre + " | " + title);
                PostList.Items.Add(message);
                PostList.Items.Add("");
                PostList.Items.Add("------------------------------------------------");

            }
        }
    }
}
