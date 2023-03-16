using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forumtest
{
    public partial class CreatePost : Form
    {
        public CreatePost()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Set the DialogResult to OK
            this.DialogResult = DialogResult.OK;

            // Close the form
            this.Close();
        }
    }
}
