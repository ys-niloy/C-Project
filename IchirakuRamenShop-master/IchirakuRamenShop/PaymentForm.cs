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
    public partial class PaymentForm : Form
    {
        private DataAccess Da { get; set; }
        public PaymentForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    MessageBox.Show("Amount field cannot be empty.");
                    return;
                }

                // Find max PayID
                var query = "select max(PayID) as LastPayID from PaymentTable;";
                var dt = this.Da.ExecuteQueryTable(query);

                int newPayID = 1; // default if table is empty

                if (dt.Rows.Count == 1 && dt.Rows[0]["LastPayID"] != DBNull.Value)
                {
                    newPayID = Convert.ToInt32(dt.Rows[0]["LastPayID"]) + 1;
                }

                // Insert into PaymentTable with calculated PayID
                var sql = "insert into PaymentTable values(" + newPayID + ", " + txtAmount.Text + ");";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Payment saved successfully with PayID: " + newPayID);
                else
                    MessageBox.Show("Failed to save payment.");

                

                // Clear textbox after inserting
                txtAmount.Clear();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred while saving payment.\nError Info: " + exc.Message);
            }


        }
    }
}
