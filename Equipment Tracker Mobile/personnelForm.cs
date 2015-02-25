using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Data.SQLite;

namespace EquipmentTracker
{
    public partial class personnelForm : Form
    {
        private SQLiteConnection etDBConnection = new SQLiteConnection("Data Source=|DataDirectory|\\Data\\equiptracker.db3");

        private System.EventHandler readerEventHandler;

        public personnelForm()
        {
            InitializeComponent();
        }

        private void personnelForm_Load(object sender, EventArgs e)
        {
            SQLiteDataAdapter etDBDataAdapter = new SQLiteDataAdapter("SELECT Branch, BranchCode FROM Branch", etDBConnection);
            DataSet etDBDataSet = new DataSet("Personnel");

            etDBConnection.Open();
            etDBDataAdapter.Fill(etDBDataSet);
            etDBConnection.Close();

            branchComboBox.DataSource = etDBDataSet.Tables[0];
            branchComboBox.DisplayMember = "Branch";
            branchComboBox.ValueMember = "BranchCode";

            refreshPersonnelListbox();
            if (Scanning.InitReader())
            {
                readerEventHandler = new EventHandler(myReader_OnRead);

                Scanning.MyEventHandler = readerEventHandler;
            }
        }

        private void myReader_OnRead(object sender, EventArgs e)
        {
            Symbol.Barcode.ReaderData TheReaderData = Scanning.MyReaderData;

            // If it is a successful read (as opposed to a failed one)
            if (TheReaderData.Result == Symbol.Results.SUCCESS)
            {

                if (TheReaderData.Type == Symbol.Barcode.DecoderTypes.PDF417)
                {
                    util.CAC_PDF417 CAC_PDF417 = new util.CAC_PDF417(TheReaderData.Text);

                    lastNameTextBox.Text = CAC_PDF417.LastName;
                    firstNameTextBox.Text = CAC_PDF417.FirstName;
                    middleInitialTextBox.Text = CAC_PDF417.MiddleInitial;
                    ediTextBox.Text = CAC_PDF417.EDI;
                    rankTextBox.Text = CAC_PDF417.Rank;
                    branchComboBox.SelectedValue = CAC_PDF417.BranchCode;

                    if (TheReaderData.MultiPart)
                        MessageBox.Show(TheReaderData.AuxData.Text);
                }

                // Start the next read
                Scanning.StartRead();
            }
            else
            {
                string sMsg = "Read Failed\n"
                       + "Result = "
                       + (TheReaderData.Result).ToString();

                MessageBox.Show(sMsg, "ReadNotify");

                if (TheReaderData.Result == Symbol.Results.E_SCN_READINCOMPATIBLE)
                {
                    // If the failure is E_SCN_READINCOMPATIBLE, exit the application.
                    MessageBox.Show("The application will now exit.");
                    this.Close();
                    return;
                }


            }
        }

        private void refreshPersonnelListbox()
        {
            SQLiteDataAdapter etDBDataAdapter = new SQLiteDataAdapter("SELECT LastName || ', ' || FirstName || ' ' || Rank AS FullName, PersonnelEDI FROM Personnel ORDER BY LastName", etDBConnection);
            DataSet etDBDataSet = new DataSet("Personnel");

            etDBConnection.Open();
            etDBDataAdapter.Fill(etDBDataSet);
            etDBConnection.Close();

            personnelListBox.DataSource = etDBDataSet.Tables[0];
            personnelListBox.DisplayMember = "FullName";
            personnelListBox.ValueMember = "PersonnelEDI";
            if (personnelListBox.Items.Count == 0)
            {
                clearPersonnelForm();
            }
        }

        private void refreshPersonnelDetails(string personnelEDI)
        {
            try
            {
                SQLiteCommand personnelCommand = new SQLiteCommand("SELECT Personnel.LastName, Personnel.FirstName," +
                    "Personnel.MiddleInitial, Personnel.PersonnelEDI, Personnel.Rank, Personnel.Branch FROM Personnel WHERE Personnel.PersonnelEDI = $EDI", etDBConnection);
                personnelCommand.Parameters.AddWithValue("$EDI", personnelListBox.SelectedValue.ToString());
                SQLiteDataAdapter etDBDataAdapter = new SQLiteDataAdapter(personnelCommand);

                DataSet etDBDataSet = new DataSet("Personnel");

                etDBConnection.Open();
                etDBDataAdapter.Fill(etDBDataSet);
                etDBConnection.Close();

                lastNameTextBox.Text = etDBDataSet.Tables[0].Rows[0]["LastName"].ToString();
                firstNameTextBox.Text = etDBDataSet.Tables[0].Rows[0]["FirstName"].ToString();
                middleInitialTextBox.Text = etDBDataSet.Tables[0].Rows[0]["MiddleInitial"].ToString();
                ediTextBox.Text = etDBDataSet.Tables[0].Rows[0]["PersonnelEDI"].ToString();
                rankTextBox.Text = etDBDataSet.Tables[0].Rows[0]["Rank"].ToString();
                branchComboBox.SelectedValue = etDBDataSet.Tables[0].Rows[0]["Branch"].ToString();
            }
            catch (SQLiteException sqliteEx)
            {
                MessageBox.Show(sqliteEx.Message);
            }
            finally
            {
                etDBConnection.Close();
            }
        }

        private void clearPersonnelForm()
        {
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            middleInitialTextBox.Text = "";
            ediTextBox.Text = "";
            rankTextBox.Text = "";
            branchComboBox.SelectedIndex = 0;
        }
        private void togglePersonnelForm(bool toggle)
        {
            if (toggle)
            {
                branchComboBox.Enabled = true;
                lastNameTextBox.ReadOnly = false;
                firstNameTextBox.ReadOnly = false;
                middleInitialTextBox.ReadOnly = false;
                ediTextBox.ReadOnly = false;
                rankTextBox.ReadOnly = false;
            }
            else
            {
                lastNameTextBox.ReadOnly = true;
                firstNameTextBox.ReadOnly = true;
                middleInitialTextBox.ReadOnly = true;
                ediTextBox.ReadOnly = true;
                rankTextBox.ReadOnly = true;
                branchComboBox.Enabled = false;
            }
        }

        private void personnelForm_Closed(object sender, EventArgs e)
        {
            Scanning.TermReader();
        }

        private void personnelListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (personnelListBox.Items.Count > 0)
            {
                if (personnelListBox.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    refreshPersonnelDetails(personnelListBox.SelectedValue.ToString());
                }
            }
        }

        private void personnelInputPanel_EnabledChanged(object sender, EventArgs e)
        {
            if (personnelInputPanel.Enabled)
            {
                personnelListBox.Visible = false;
            }
            else
            {
                personnelListBox.Visible = true;
            }
        }

        private void insertPersonnelMenuItem_Click(object sender, EventArgs e)
        {
            if (insertPersonnelMenuItem.Text == "New")
            {
                togglePersonnelForm(true);
                personnelListBox.Enabled = false;
                insertPersonnelMenuItem.Text = "Insert";
                deletePersonnelMenuItem.Enabled = false;
                cancelMenuItem.Enabled = true;
                editPersonnelMenuItem.Enabled = false;
                clearPersonnelForm();
                Scanning.StartRead();
            }
            else if (MessageBox.Show("Are you sure you want to commit this information to the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && ediTextBox.Text != "" && rankTextBox.Text != "")
                {
                    try
                    {
                        SQLiteCommand addPersonnelCommand = new SQLiteCommand(etDBConnection);
                        addPersonnelCommand.CommandText = "INSERT INTO Personnel (PersonnelEDI, FirstName, LastName, Rank, Branch, MiddleInitial) " +
                            "VALUES ($EDI,$FirstName,$LastName,$Rank,$Branch,$MiddleInitial)";

                        
                        addPersonnelCommand.Parameters.AddWithValue("$EDI", ediTextBox.Text.Trim());
                        addPersonnelCommand.Parameters.AddWithValue("$FirstName", firstNameTextBox.Text.Trim());
                        addPersonnelCommand.Parameters.AddWithValue("$LastName",lastNameTextBox.Text.Trim());
                        addPersonnelCommand.Parameters.AddWithValue("$Rank",rankTextBox.Text.Trim());
                        addPersonnelCommand.Parameters.AddWithValue("$Branch",branchComboBox.SelectedValue.ToString());
                        addPersonnelCommand.Parameters.AddWithValue("$MiddleInitial",middleInitialTextBox.Text.Trim());

                        //Open database and execute command
                        etDBConnection.Open();
                        addPersonnelCommand.ExecuteNonQuery();
                        etDBConnection.Close();
                        MessageBox.Show("Personnel Added");

                        insertPersonnelMenuItem.Text = "New";
                        cancelMenuItem.Enabled = false;
                        deletePersonnelMenuItem.Enabled = true;
                        editPersonnelMenuItem.Enabled = true;
                        personnelListBox.Enabled = true;

                        togglePersonnelForm(false);
                        clearPersonnelForm();
                        refreshPersonnelListbox();
                        Scanning.StopRead();
                    }
                    catch (SQLiteException sqliteException)
                    {
                        MessageBox.Show(sqliteException.Message);
                        //if (sqliteException.ErrorCode == SQLiteErrorCode.Constraint)
                        //{
                        //    MessageBox.Show("Entered EDI number is not unique and already added.  User is possibly already added.", "Invalid EDI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        //}
                    }
                    finally
                    {
                        etDBConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Missing required information");
                }
            }
        }

        private void cancelMenuItem_Click(object sender, EventArgs e)
        {
            if (insertPersonnelMenuItem.Text == "Insert")
            {
                insertPersonnelMenuItem.Text = "New";
                Scanning.StopRead();
                togglePersonnelForm(false);
                clearPersonnelForm();
                refreshPersonnelDetails(personnelListBox.SelectedValue.ToString());
                editPersonnelMenuItem.Enabled = true;
            }
            else if (editPersonnelMenuItem.Text == "Update")
            {
                editPersonnelMenuItem.Text = "Edit";
                togglePersonnelForm(false);
                clearPersonnelForm();
                refreshPersonnelDetails(personnelListBox.SelectedValue.ToString());
                insertPersonnelMenuItem.Enabled = true;
                ediTextBox.Enabled = true;
            }
            personnelListBox.Enabled = true;
            cancelMenuItem.Enabled = false;
            deletePersonnelMenuItem.Enabled = true;
        }

        private void editPersonnelMenuItem_Click(object sender, EventArgs e)
        {
            if (editPersonnelMenuItem.Text == "Edit")
            {
                togglePersonnelForm(true);
                ediTextBox.Enabled = false;
                editPersonnelMenuItem.Text = "Update";
                cancelMenuItem.Enabled = true;
                deletePersonnelMenuItem.Enabled = false;
                insertPersonnelMenuItem.Enabled = false;
                personnelListBox.Enabled = false;
            }
            else if (MessageBox.Show("Are you sure you want to commit this information to the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && ediTextBox.Text != "" && rankTextBox.Text != "")
                {
                    try
                    {
                        SQLiteCommand editPersonnelCommand = new SQLiteCommand(etDBConnection);
                        editPersonnelCommand.CommandText = "UPDATE Personnel " +
                            "SET LastName = $LastName, " +
                            "FirstName = $FirstName, " +
                            "MiddleInitial = $MiddleInitial, " +
                            "Rank = $Rank, " +
                            "Branch = $Branch " +
                            "WHERE PersonnelEDI = $EDI";

                        editPersonnelCommand.Parameters.AddWithValue("$LastName", lastNameTextBox.Text.Trim());
                        editPersonnelCommand.Parameters.AddWithValue("$FirstName", firstNameTextBox.Text.Trim());
                        editPersonnelCommand.Parameters.AddWithValue("$MiddleInitial", middleInitialTextBox.Text.Trim());
                        editPersonnelCommand.Parameters.AddWithValue("$Rank", rankTextBox.Text.Trim());
                        editPersonnelCommand.Parameters.AddWithValue("$Branch", branchComboBox.SelectedValue.ToString());
                        editPersonnelCommand.Parameters.AddWithValue("$EDI", ediTextBox.Text.Trim());

                        etDBConnection.Open();
                        editPersonnelCommand.ExecuteNonQuery();
                        etDBConnection.Close();
                        togglePersonnelForm(false);
                        MessageBox.Show("Personnel Updated");

                        editPersonnelMenuItem.Text = "Edit";
                        refreshPersonnelListbox();
                        cancelMenuItem.Enabled = false;
                        deletePersonnelMenuItem.Enabled = true;
                        insertPersonnelMenuItem.Enabled = true;
                        ediTextBox.Enabled = true;
                        personnelListBox.Enabled = true;
                    }
                    catch (SQLiteException sqliteException)
                    {
                        MessageBox.Show(sqliteException.Message.ToString());
                    }
                    finally
                    {
                        etDBConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Missing required information.  Ensure a valid last name, first name, EDI, and rank have been entered.");
                }
            }
        }

        private void deletePersonnelMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand deletePersonnelCommand = new SQLiteCommand(@"DELETE FROM Personnel WHERE PersonnelEDI = $EDINumber", etDBConnection);
                    deletePersonnelCommand.Parameters.AddWithValue("$EDINumber", personnelListBox.SelectedValue.ToString());
                    etDBConnection.Open();
                    deletePersonnelCommand.ExecuteNonQuery();
                    etDBConnection.Close();
                    refreshPersonnelListbox();
                    MessageBox.Show("Person deleted succesfully.");
                }
                catch (SQLiteException sqliteEx)
                {
                    MessageBox.Show(sqliteEx.Message);
                }
                finally
                {
                    etDBConnection.Close();
                }
            }
        }
    }
}