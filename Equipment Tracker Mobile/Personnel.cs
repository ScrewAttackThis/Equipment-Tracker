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

namespace KUMPOT_Mobile
{
    public partial class personnel : Form
    {
        private SQLiteConnection kumpotDBConnection = new SQLiteConnection("Data Source=|DataDirectory|\\Data\\kumpotDB.db3");
        public personnel()
        {
            InitializeComponent();
        }

        private void enableScanButton_Click(object sender, EventArgs e)
        {
            if (enableScanButton.Text == "Enable")
            {
                enableScanButton.Text = "Disable";
                personnelBarcode.EnableScanner = true;
            }
            else
            {
                enableScanButton.Text = "Enable";
                personnelBarcode.EnableScanner = false;
            }
        }

        private void personnelBarcode_OnRead(object sender, Symbol.Barcode.ReaderData readerData)
        {
            if (readerData.Type == Symbol.Barcode.DecoderTypes.PDF417)
            {
                //debug purposes only
                rawDataLabel.Text = readerData.Text;

                util.CAC_PDF417 CAC_PDF417 = new util.CAC_PDF417(readerData.Text);

                lastNameAddTextBox.Text = CAC_PDF417.LastName;
                firstNameAddTextBox.Text = CAC_PDF417.FirstName;
                middleInitialAddTextBox.Text = CAC_PDF417.MiddleInitial;
                ediAddTextBox.Text = CAC_PDF417.EDI;
                rankAddTextBox.Text = CAC_PDF417.Rank;
                branchAddComboBox.SelectedValue = CAC_PDF417.BranchCode;
            }
        }

        private void personnelForm_Closed(object sender, EventArgs e)
        {
            personnelBarcode.EnableScanner = false;
        }

        private void addPersonnelButton_Click(object sender, EventArgs e)
        {
            if (lastNameAddTextBox.Text.Trim() != "" && firstNameAddTextBox.Text.Trim() != "" && ediAddTextBox.Text.Trim() != "" && rankAddTextBox.Text.Trim() != "")
            {
                try
                {
                    SQLiteCommand addPersonnelCommand = new SQLiteCommand(kumpotDBConnection);
                    addPersonnelCommand.CommandText = "INSERT INTO Personnel (PersonnelEDI, FirstName, LastName, Rank, Branch, MiddleInitial) VALUES ('" +
                        ediAddTextBox.Text.Trim() + "', '" + firstNameAddTextBox.Text.Trim() + "', '" + lastNameAddTextBox.Text.Trim() + "', '" +
                        rankAddTextBox.Text.Trim() + "', '" + branchAddComboBox.SelectedValue.ToString() + "', '" + middleInitialAddTextBox.Text.Trim() + "')";
                    kumpotDBConnection.Open();
                    addPersonnelCommand.ExecuteScalar();
                    kumpotDBConnection.Close();
                    MessageBox.Show("Personnel Added");
                    clearPersonnelForm();
                }
                catch (SQLiteException sqliteException)
                {
                    switch(sqliteException.ErrorCode)
                    {
                        case SQLiteErrorCode.Constraint:
                            MessageBox.Show("Entered EDI number is not unique and already added.  User is possibly already added.", "Invalid EDI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            break;
                    }
                }
                finally
                {
                    kumpotDBConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Required information missing", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void RefreshPersonnelListbox()
        {
            SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Rank || ' ' || LastName || ', ' || FirstName AS FullName, PersonnelEDI FROM Personnel", kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("Personnel");

            kumpotDBConnection.Open();
            kumpotDBDataAdapter.Fill(kumpotDBDataSet);
            personnelListBox.DataSource = kumpotDBDataSet.Tables[0];
            personnelListBox.DisplayMember = "FullName";
            personnelListBox.ValueMember = "PersonnelEDI";
            kumpotDBConnection.Close();
        }
        private void RefreshPersonnelDetails(string personnelEDI)
        {
            SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Personnel.LastName, Personnel.FirstName," +
                "Personnel.MiddleInitial, Personnel.PersonnelEDI, Personnel.Rank, Branch.Branch FROM Personnel JOIN Branch ON Personnel.Branch = Branch.BranchCode WHERE Personnel.PersonnelEDI = " + personnelEDI, kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("Personnel");

            kumpotDBConnection.Open();
            kumpotDBDataAdapter.Fill(kumpotDBDataSet);
            kumpotDBConnection.Close();

            lastNameViewLabel.Text = kumpotDBDataSet.Tables[0].Rows[0]["LastName"].ToString();
            firstNameViewLabel.Text = kumpotDBDataSet.Tables[0].Rows[0]["FirstName"].ToString();
            middleInitialViewLabel.Text = kumpotDBDataSet.Tables[0].Rows[0]["MiddleInitial"].ToString();
            ediViewLabel.Text = kumpotDBDataSet.Tables[0].Rows[0]["PersonnelEDI"].ToString();
            rankViewLabel.Text = kumpotDBDataSet.Tables[0].Rows[0]["Rank"].ToString();
            branchViewLabel.Text = kumpotDBDataSet.Tables[0].Rows[0]["Branch"].ToString();
        }
        private void personnelForm_Load(object sender, EventArgs e)
        {
            RefreshPersonnelListbox();
        }

        private void personnelTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (personnelTabControl.SelectedIndex == 1)
            {
                SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Branch, BranchCode FROM Branch", kumpotDBConnection);
                DataSet kumpotDBDataSet = new DataSet("Branch");

                kumpotDBConnection.Open();
                kumpotDBDataAdapter.Fill(kumpotDBDataSet);
                kumpotDBConnection.Close();

                branchAddComboBox.DataSource = kumpotDBDataSet.Tables[0];
                branchAddComboBox.DisplayMember = "Branch";
                branchAddComboBox.ValueMember = "BranchCode";
            }
            else if (personnelTabControl.SelectedIndex == 2)
            {
                SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Branch, BranchCode FROM Branch", kumpotDBConnection);
                DataSet kumpotDBDataSet = new DataSet("Branch");

                kumpotDBConnection.Open();
                kumpotDBDataAdapter.Fill(kumpotDBDataSet);
                kumpotDBConnection.Close();

                branchEditComboBox.DataSource = kumpotDBDataSet.Tables[0];
                branchEditComboBox.DisplayMember = "Branch";
                branchEditComboBox.ValueMember = "BranchCode";

                //dataBindPersonnelEditForm();
            }
            
        }
        private void dataBindPersonnelEditForm(string personnelEDI)
        {
            SQLiteDataAdapter kumpotDBDataAdapter = new SQLiteDataAdapter("SELECT Personnel.LastName, Personnel.FirstName," +
                "Personnel.MiddleInitial, Personnel.PersonnelEDI, Personnel.Rank, Branch.Branch FROM Personnel JOIN Branch ON Personnel.Branch = Branch.BranchCode WHERE Personnel.PersonnelEDI = " + personnelEDI, kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("Personnel");

            kumpotDBConnection.Open();
            kumpotDBDataAdapter.Fill(kumpotDBDataSet);
            kumpotDBConnection.Close();

            
        }
        private void refreshPersonnelButton_Click(object sender, EventArgs e)
        {
            RefreshPersonnelListbox();
        }

        private void editPersonnelButton_Click(object sender, EventArgs e)
        {
            //Code to databind personnel edit form.

        }

        private void personnelDetailsViewButton_Click(object sender, EventArgs e)
        {
            if (personnelListBox.SelectedValue != null)
                RefreshPersonnelDetails(personnelListBox.SelectedValue.ToString());
        }

        private void deletePersonnelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected person?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("Test");
            }
        }
        private void clearPersonnelForm()
        {
            lastNameAddTextBox.Text = "";
            firstNameAddTextBox.Text = "";
            middleInitialAddTextBox.Text = "";
            ediAddTextBox.Text = "";
            rankAddTextBox.Text = "";
            branchAddComboBox.SelectedIndex = 0;
        }
        private void clearPersonnelButton_Click(object sender, EventArgs e)
        {
            clearPersonnelForm();
        }

        private void showKeyboardButton_Click(object sender, EventArgs e)
        {
            kumpotPersonnelInputPanel.Enabled = true;
        }

    }
}