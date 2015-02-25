using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EquipmentTracker
{
    public partial class checkOutForm : Form
    {
        private SQLiteConnection etDBConnection = new SQLiteConnection("Data Source=|DataDirectory|\\Data\\equiptracker.db3");

        public checkOutForm()
        {
            InitializeComponent();
        }

        private void checkOutForm_Load(object sender, EventArgs e)
        {
            populatePersonnel();
            populateEquipment();
            populateCheckedOutList();
        }
        private void populatePersonnel()
        {
            SQLiteDataAdapter etDBDataAdapter = new SQLiteDataAdapter("SELECT LastName || ', ' || FirstName || ' ' || Rank AS FullName, PersonnelEDI FROM Personnel ORDER BY LastName", etDBConnection);
            DataSet etDBDataSet = new DataSet("Personnel");

            etDBConnection.Open();
            etDBDataAdapter.Fill(etDBDataSet);
            etDBConnection.Close();

            personnelListBox.DataSource = etDBDataSet.Tables[0];
            personnelListBox.DisplayMember = "FullName";
            personnelListBox.ValueMember = "PersonnelEDI";
        }

        private void populateEquipment()
        {
            //Only show equipment that haven't been checked out.
            SQLiteCommand etDataCommand = new SQLiteCommand(etDBConnection);
            etDataCommand.CommandText = "SELECT SerialNumber " +
                "FROM EquipInventory " +
                "WHERE SerialNumber NOT IN " +
	            "(SELECT SerialNumber FROM PersonnelCheckOut WHERE ReturnedDate IS NULL)";


            SQLiteDataAdapter etDataAdapter = new SQLiteDataAdapter(etDataCommand);
            DataSet etDBDataSet = new DataSet("Equipment");

            etDBConnection.Open();
            etDataAdapter.Fill(etDBDataSet);
            etDBConnection.Close();

            equipmentListBox.DataSource = etDBDataSet.Tables[0];
            equipmentListBox.DisplayMember = "SerialNumber";
            equipmentListBox.ValueMember = "SerialNumber";
        }

        private void populateCheckedOutList()
        {
            SQLiteCommand checkedOutDataCommand = new SQLiteCommand(etDBConnection);
            checkedOutDataCommand.CommandText = "SELECT PersonnelCheckOut.SerialNumber || ' - ' || Personnel.LastName || ', ' || Personnel.FirstName || ' ' || Personnel.MiddleInitial || ' ' || Personnel.Rank AS CheckOut, " +
                "PersonnelCheckOut.CheckoutID AS CheckoutID " +
                "FROM PersonnelCheckOut " +
                "JOIN Personnel ON PersonnelCheckOut.personnelEDI = Personnel.PersonnelEDI " +
                "WHERE PersonnelCheckOut.ReturnedDate IS NULL " +
                "ORDER BY PersonnelCheckOut.CheckOutDate";

            SQLiteDataAdapter checkedOutDataAdapter = new SQLiteDataAdapter(checkedOutDataCommand);
            DataSet checkedOutDataSet = new DataSet("CheckedOut");

            etDBConnection.Open();
            checkedOutDataAdapter.Fill(checkedOutDataSet);
            etDBConnection.Close();

            checkedOutListBox.DataSource = checkedOutDataSet.Tables[0];
            checkedOutListBox.DisplayMember = "CheckOut";
            checkedOutListBox.ValueMember = "CheckoutID";

        }

        private void personnelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personnelListBox.Items.Count > 0)
            {
                if (personnelListBox.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    ediTextBox.Text = personnelListBox.SelectedValue.ToString();
                }
            }
        }

        private void signOutMenuItem_Click(object sender, EventArgs e)
        {
            if (personnelListBox.SelectedItem != null && equipmentListBox.SelectedItem != null)
            {
                SQLiteCommand signOutCommand = new SQLiteCommand(etDBConnection);
                signOutCommand.CommandText = "INSERT INTO PersonnelCheckout (SerialNumber, PersonnelEDI) VALUES ($SerialNumber, $EDI)";

                signOutCommand.Parameters.AddWithValue("$SerialNumber", equipmentListBox.SelectedValue.ToString());
                signOutCommand.Parameters.AddWithValue("$EDI", personnelListBox.SelectedValue.ToString());

                etDBConnection.Open();
                signOutCommand.ExecuteNonQuery();
                etDBConnection.Close();

                populateEquipment();
                populateCheckedOutList();
            }
            else
            {
                MessageBox.Show("Select a valid serial number and person");
            }
        }

        private void signInMenuItem_Click(object sender, EventArgs e)
        {
            if (checkedOutListBox.SelectedItem != null)
            {
                SQLiteCommand signInCommand = new SQLiteCommand(etDBConnection);
                signInCommand.CommandText = "UPDATE PersonnelCheckout SET ReturnedDate = CURRENT_TIMESTAMP WHERE CheckoutID = $CheckoutID";
                signInCommand.Parameters.AddWithValue("$CheckoutID", checkedOutListBox.SelectedValue.ToString());

                etDBConnection.Open();
                signInCommand.ExecuteNonQuery();
                etDBConnection.Close();

                populateEquipment();
                populateCheckedOutList();
            }
            else
            {
                MessageBox.Show("You must select an item to sign in.");
            }
        }

        private void equipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipmentListBox.Items.Count > 0)
            {
                if (equipmentListBox.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    serialNumberTextBox.Text = equipmentListBox.SelectedValue.ToString();
                }
            }

        }
    }
}