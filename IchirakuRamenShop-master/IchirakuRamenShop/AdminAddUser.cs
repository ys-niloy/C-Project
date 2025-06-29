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
    public partial class AdminAddUser : Form
    {
        private DataAccess Da { get; set; }

        public AdminAddUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIncrementUid();
            this.txtUid.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome ah = new AdminHome();
            ah.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }

        private void AutoIncrementUid()
        {
            try
            {
                var query = "select max(Uid) as LastUid from Users;";
                var dt = this.Da.ExecuteQueryTable(query);

                int newUid = 1; // default for empty table

                if (dt.Rows.Count == 1 && dt.Rows[0]["LastUid"] != DBNull.Value)
                {
                    newUid = Convert.ToInt32(dt.Rows[0]["LastUid"]) + 1;
                }

                this.txtUid.Text = newUid.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error in generating new Uid.\nError Info: " + exc.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtRole.Text) ||
                    string.IsNullOrWhiteSpace(txtName.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Empty fields are not allowed. Please fill all the information");
                    return;
                }

                var query = "select * from Users where Uid = '" + this.txtUid.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    // Update existing user
                    var sql = @"update Users
                    set Username = '" + this.txtUsername.Text + @"',
                    Role = '" + this.txtRole.Text + @"',
                    Name = '" + this.txtName.Text + @"',
                    Password = '" + this.txtPassword.Text + @"'
                    where Uid = '" + this.txtUid.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("User data updated properly.");
                    else
                        MessageBox.Show("Failure while updating the user data.");
                }
                else
                {
                    // New insert: generate next uid automatically
                    var queryLastUid = "select max(Uid) as LastUid from Users;";
                    var dtLastUid = this.Da.ExecuteQueryTable(queryLastUid);

                    int newUid = 1;
                    if (dtLastUid.Rows.Count == 1 && dtLastUid.Rows[0]["LastUid"] != DBNull.Value)
                    {
                        newUid = Convert.ToInt32(dtLastUid.Rows[0]["LastUid"]) + 1;
                    }

                    //// Set txtUid for UI consistency
                    //this.txtUid.Text = newUid.ToString();

                    var sql = "insert into Users values(" + newUid + ", '" + this.txtUsername.Text + "', '" + this.txtRole.Text + "', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("User data saved properly.");
                    else
                        MessageBox.Show("Failure while saving the user data.");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred due to invalid input.\nError Info: " + exc.Message);
            }
        }
    }
}
