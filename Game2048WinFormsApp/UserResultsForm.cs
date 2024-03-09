using Game2048.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048WinFormsApp
{
    public partial class UserResultsForm : Form
    {
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var usersResults = UsersResultStorage.GetAll();
            foreach (var userResult in usersResults)
            {
                userResultsDataGridView.Rows.Add(userResult.Name, userResult.Score);
            }
        }
    }
}
