using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IchirakuRamenShop
{

    public partial class AdminHome : Form
    {
        private DataAccess Da { get; set; }

        public AdminHome()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

        }

        private void PopulateGridView(string sql = "select * from Users;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Row first to delete the data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var id = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                var username = this.dgvUser.CurrentRow.Cells["Username"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {username}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                var sql = "delete from Users where Uid = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(username + " user removed properly.");
                else
                    MessageBox.Show("Failure While removing the data");

                this.PopulateGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured due to invalid choice.\nError Info:" + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddUser au = new AdminAddUser();
            au.ShowDialog();
        }
    }
}
