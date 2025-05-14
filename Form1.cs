using System;
using System.Windows.Forms;

namespace ClientSessionTracker
{
    public partial class Form1 : Form
    {
        // Constructor: Initializes the components
        public Form1()
        {
            InitializeComponent();  // This loads the designer code where controls are initialized
        }

        // Event handler for the txtClientName text box "TextChanged" event
        // Triggered every time the user changes the text in the txtClientName field
        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                // If the name is empty, disable the Add Session button
                btnAddSession.Enabled = false;
            }
            else
            {
                // If the name is not empty, enable the Add Session button
                btnAddSession.Enabled = true;
            }
        }

        // Event handler for the "Add Session" button click
        private void btnAddSession_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure all required fields are filled
                if (string.IsNullOrEmpty(txtClientName.Text) || dtpSessionDate.Value == null ||
                    string.IsNullOrEmpty(txtSessionNotes.Text))
                {
                    MessageBox.Show("Please complete all fields before adding a session.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit if validation fails
                }

                // Create a new list view item for session details
                ListViewItem newItem = new ListViewItem(txtClientName.Text);  // Add client name
                newItem.SubItems.Add(dtpSessionDate.Value.ToString("yyyy-MM-dd"));  // Add session date
                newItem.SubItems.Add(txtSessionNotes.Text);  // Add session notes
                newItem.SubItems.Add(UpDownFee.Value.ToString("C"));  // Add session fee
                newItem.SubItems.Add(checkBoxPaid.Checked ? "Paid" : "Unpaid");  // Add payment status

                // Add the new session to the list view
                listViewSessions.Items.Add(newItem);

                // update the unpaid balance after each session is added
                UpdateUnpaidBalance();
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to update the unpaid balance label based on session fees
        private void UpdateUnpaidBalance()
        {
            decimal totalUnpaid = 0m;

            // Loop through the items in the list view and calculate the unpaid balance
            foreach (ListViewItem item in listViewSessions.Items)
            {
                if (item.SubItems[4].Text == "Unpaid")  // Check if the session is unpaid
                {
                    decimal fee = decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);
                    totalUnpaid += fee;  // Add unpaid session fee to total
                }
            }

            // Display the total unpaid balance on the label
            lblUnpaidBalance.Text = "Unpaid Balance: " + totalUnpaid.ToString("C");
        }
    }
}