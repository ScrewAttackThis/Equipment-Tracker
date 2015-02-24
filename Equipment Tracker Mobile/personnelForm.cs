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
        private SQLiteConnection kumpotDBConnection = new SQLiteConnection("Data Source=|DataDirectory|\\Data\\equiptracker.db3");

        private System.EventHandler readerEventHandler;

        public personnelForm()
        {
            InitializeComponent();
        }

        private void personnelForm_Load(object sender, EventArgs e)
        {
            SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Branch, BranchCode FROM Branch", kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("Personnel");

            kumpotDBConnection.Open();
            kumpotDBDataAdapter.Fill(kumpotDBDataSet);
            kumpotDBConnection.Close();

            branchComboBox.DataSource = kumpotDBDataSet.Tables[0];
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
            SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT LastName || ', ' || FirstName || ' ' || Rank AS FullName, PersonnelEDI FROM Personnel ORDER BY LastName", kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("Personnel");

            kumpotDBConnection.Open();
            kumpotDBDataAdapter.Fill(kumpotDBDataSet);
            kumpotDBConnection.Close();

            personnelListBox.DataSource = kumpotDBDataSet.Tables[0];
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
                SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Personnel.LastName, Personnel.FirstName," +
                    "Personnel.MiddleInitial, Personnel.PersonnelEDI, Personnel.Rank, Personnel.Branch FROM Personnel WHERE Personnel.PersonnelEDI = " + personnelEDI, kumpotDBConnection);
                DataSet kumpotDBDataSet = new DataSet("Personnel");

                kumpotDBConnection.Open();
                kumpotDBDataAdapter.Fill(kumpotDBDataSet);
                kumpotDBConnection.Close();

                lastNameTextBox.Text = kumpotDBDataSet.Tables[0].Rows[0]["LastName"].ToString();
                firstNameTextBox.Text = kumpotDBDataSet.Tables[0].Rows[0]["FirstName"].ToString();
                middleInitialTextBox.Text = kumpotDBDataSet.Tables[0].Rows[0]["MiddleInitial"].ToString();
                ediTextBox.Text = kumpotDBDataSet.Tables[0].Rows[0]["PersonnelEDI"].ToString();
                rankTextBox.Text = kumpotDBDataSet.Tables[0].Rows[0]["Rank"].ToString();
                branchComboBox.SelectedValue = kumpotDBDataSet.Tables[0].Rows[0]["Branch"].ToString();
            }
            catch (SQLiteException sqliteEx)
            {
                MessageBox.Show(sqliteEx.Message);
            }
            finally
            {
                kumpotDBConnection.Close();
            }
        }

        private void insertPersonnelButton_Click(object sender, EventArgs e)
        {
            if (insertPersonnelButton.Text == "New")
            {
                togglePersonnelForm(true);
                personnelListBox.Enabled = false;
                insertPersonnelButton.Text = "Insert";
                deletePersonnelButton.Enabled = false;
                cancelButton.Enabled = true;
                editPersonnelButton.Enabled = false;
                clearPersonnelForm();
                Scanning.StartRead();
            }
            else if(MessageBox.Show("Are you sure you want to commit this information to the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && ediTextBox.Text != "" && rankTextBox.Text != "")
                {
                    try
                    {
                        SQLiteCommand addPersonnelCommand = new SQLiteCommand(kumpotDBConnection);
                        addPersonnelCommand.CommandText = "INSERT INTO Personnel (PersonnelEDI, FirstName, LastName, Rank, Branch, MiddleInitial) VALUES ('" +
                            ediTextBox.Text.Trim() + "', '" + firstNameTextBox.Text.Trim() + "', '" + lastNameTextBox.Text.Trim() + "', '" +
                            rankTextBox.Text.Trim() + "', '" + branchComboBox.SelectedValue.ToString() + "', '" + middleInitialTextBox.Text.Trim() + "')";
                        kumpotDBConnection.Open();
                        addPersonnelCommand.ExecuteScalar();
                        kumpotDBConnection.Close();
                        MessageBox.Show("Personnel Added");
                        insertPersonnelButton.Text = "New";
                        cancelButton.Enabled = false;
                        deletePersonnelButton.Enabled = true;
                        editPersonnelButton.Enabled = true;
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
                        kumpotDBConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Missing required information");
                }
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
        private void editPersonnelButton_Click(object sender, EventArgs e)
        {
            if(editPersonnelButton.Text == "Edit")
            {
                togglePersonnelForm(true);
                ediTextBox.Enabled = false;
                editPersonnelButton.Text = "Update";
                cancelButton.Enabled = true;
                deletePersonnelButton.Enabled = false;
                insertPersonnelButton.Enabled = false;
                personnelListBox.Enabled = false;
            }
            else if(MessageBox.Show("Are you sure you want to commit this information to the database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (lastNameTextBox.Text != "" && firstNameTextBox.Text != "" && ediTextBox.Text != "" && rankTextBox.Text != "")
                {
                    try
                    {
                        SQLiteCommand editPersonnelCommand = new SQLiteCommand(kumpotDBConnection);
                        editPersonnelCommand.CommandText = "UPDATE Personnel " +
                            "SET LastName = '" + lastNameTextBox.Text.Trim() + "', " +
                            "FirstName = '" + firstNameTextBox.Text.Trim() + "', " +
                            "MiddleInitial = '" + middleInitialTextBox.Text.Trim() + "', " +
                            "Rank = '" + rankTextBox.Text.Trim() + "', " +
                            "Branch = '" + branchComboBox.SelectedValue.ToString() + "' " +
                            "WHERE PersonnelEDI = " + ediTextBox.Text.Trim();
                        kumpotDBConnection.Open();
                        editPersonnelCommand.ExecuteScalar();
                        kumpotDBConnection.Close();
                        togglePersonnelForm(false);
                        MessageBox.Show("Personnel Updated");
                        editPersonnelButton.Text = "Edit";
                        refreshPersonnelListbox();
                        cancelButton.Enabled = false;
                        deletePersonnelButton.Enabled = true;
                        insertPersonnelButton.Enabled = true;
                        ediTextBox.Enabled = true;
                        personnelListBox.Enabled = true;
                    }
                    catch (SQLiteException sqliteException)
                    {
                        MessageBox.Show(sqliteException.Message.ToString());
                    }
                    finally
                    {
                        kumpotDBConnection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Missing required information");
                }
            }
        }

        private void deletePersonnelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    SQLiteCommand editPersonnelCommand = new SQLiteCommand(kumpotDBConnection);
                    editPersonnelCommand.CommandText = "DELETE FROM Personnel WHERE PersonnelEDI = " + personnelListBox.SelectedValue.ToString();
                    kumpotDBConnection.Open();
                    editPersonnelCommand.ExecuteScalar();
                    kumpotDBConnection.Close();
                    refreshPersonnelListbox();
                }
                catch (SQLiteException sqliteEx)
                {
                    MessageBox.Show(sqliteEx.Message);
                }
                finally
                {
                    kumpotDBConnection.Close();
                }
            }
        }

        private void personnelForm_Closed(object sender, EventArgs e)
        {
            Scanning.TermReader();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (insertPersonnelButton.Text == "Insert")
            {
                insertPersonnelButton.Text = "New";
                Scanning.StopRead();
                togglePersonnelForm(false);
                clearPersonnelForm();     
                refreshPersonnelDetails(personnelListBox.SelectedValue.ToString());
                editPersonnelButton.Enabled = true;
            }
            else if (editPersonnelButton.Text == "Update")
            {
                editPersonnelButton.Text = "Edit";
                togglePersonnelForm(false);
                clearPersonnelForm();
                refreshPersonnelDetails(personnelListBox.SelectedValue.ToString());
                insertPersonnelButton.Enabled = true;
                ediTextBox.Enabled = true;
            }
            personnelListBox.Enabled = true;
            cancelButton.Enabled = false;
            deletePersonnelButton.Enabled = true;
        }


        private void personnelListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (personnelListBox.Items.Count != 0)
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
    }
}