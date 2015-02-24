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
    public partial class equipmentForm : Form
    {
        private System.EventHandler readerEventHandler;

        private SQLiteConnection kumpotDBConnection = new SQLiteConnection("Data Source=|DataDirectory|\\Data\\equiptracker.db3");

        public equipmentForm()
        {
            InitializeComponent();
        }

        private void insertEquipmentMenuItem_Click(object sender, EventArgs e)
        {
            if (insertEquipmentMenuItem.Text == "New")
            {
                Scanning.StartRead();
                cancelActionEquipmentMenuItem.Enabled = true;
                insertEquipmentMenuItem.Text = "Insert";
            }
            else
            {
                try
                {
                    SQLiteCommand addEquipmentCommand = new SQLiteCommand(kumpotDBConnection);
                    addEquipmentCommand.CommandText = "INSERT INTO EquipInventory (SerialNumber, PartNumber) VALUES ('" +
                        serialNumberTextBox.Text.Trim() + "', '" + productComboBox.SelectedValue.ToString().Trim() + "')";
                    kumpotDBConnection.Open();
                    addEquipmentCommand.ExecuteScalar();
                    kumpotDBConnection.Close();
                    MessageBox.Show("Equipment Added");
                    insertEquipmentMenuItem.Text = "New";
                    cancelActionEquipmentMenuItem.Enabled = false;
                    populateTreeView();
                    Scanning.StopRead();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                    //switch (ex.ErrorCode)
                    //{
                    //    case SQLiteErrorCode.Constraint:
                    //        MessageBox.Show("Serial number is already added.", "Invalid Serial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    //        break;
                    //}
                }
                finally
                {
                    kumpotDBConnection.Close();
                }
            }
        }

        private void equipmentForm_Load(object sender, EventArgs e)
        {
            if (Scanning.InitReader())
            {
                readerEventHandler = new EventHandler(myReader_OnRead);

                Scanning.MyEventHandler = readerEventHandler;

                populateTreeView();
                populateMFRComboBox();
            }
        }
        private void populateProductComboBox(string selectedCageNumber)
        {
            SQLiteDataAdapter productDataAdapter = new SQLiteDataAdapter("SELECT PartNumber, ProductName FROM EquipType WHERE CageNumber = " + selectedCageNumber, kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("ProductComboBox");
            kumpotDBConnection.Open();
            productDataAdapter.Fill(kumpotDBDataSet);
            kumpotDBConnection.Close();

            productComboBox.DataSource = kumpotDBDataSet.Tables[0];
            productComboBox.DisplayMember = "ProductName";
            productComboBox.ValueMember = "PartNumber";
        }
        private void populateMFRComboBox()
        {
            SQLiteDataAdapter mfrDataAdapter = new SQLiteDataAdapter("SELECT CageNumber, Company FROM EquipMFR", kumpotDBConnection);
            DataSet kumpotDBDataSet = new DataSet("ProductComboBox");
            kumpotDBConnection.Open();
            mfrDataAdapter.Fill(kumpotDBDataSet);
            kumpotDBConnection.Close();

            mfrComboBox.DataSource = kumpotDBDataSet.Tables[0];
            mfrComboBox.DisplayMember = "Company";
            mfrComboBox.ValueMember = "CageNumber";
        }
        private void populateTreeView()
        {
            SQLiteDataAdapter equipmentDataAdapter = new SQLiteDataAdapter("SELECT SerialNumber, PartNumber FROM EquipInventory; SELECT PartNumber, CageNumber, ProductName FROM EquipType; SELECT CageNumber, Company FROM EquipMFR;", kumpotDBConnection);
            //SQLiteDataAdapter equipmentDataAdapter = new SQLiteDataAdapter("SELECT SerialNumber, PartNumber FROM EquipInventory; SELECT PartNumber, CageNumber, ProductName FROM EquipType; SELECT CageNumber, Company FROM EquipMFR;", kumpotDBConnection);
            DataSet kumpotDataSet = new DataSet("Equipment");
            kumpotDBConnection.Open();
            equipmentDataAdapter.Fill(kumpotDataSet);
            kumpotDBConnection.Close();

            kumpotDataSet.Relations.Add("MFR", kumpotDataSet.Tables[2].Columns["CageNumber"], kumpotDataSet.Tables[1].Columns["CageNumber"]);
            kumpotDataSet.Relations.Add("Product", kumpotDataSet.Tables[1].Columns["PartNumber"], kumpotDataSet.Tables[0].Columns["PartNumber"]);

            equipmentTreeView.Nodes.Clear();
            foreach (DataRow row in kumpotDataSet.Tables[2].Rows)
            {
                TreeNode childNode = new TreeNode();
                foreach (DataRow childRow in row.GetChildRows("MFR"))
                {
                    TreeNode grandChildNode = new TreeNode();
                    foreach (DataRow childRow2 in childRow.GetChildRows("Product"))
                    {
                        grandChildNode.Nodes.Add(childRow2["SerialNumber"].ToString());
                    }
                    grandChildNode.Text = childRow["ProductName"].ToString();
                    childNode.Nodes.Add(grandChildNode);
                }
                childNode.Text = row["Company"].ToString();
            equipmentTreeView.Nodes.Add(childNode);
            }
        }

        private void myReader_OnRead(object sender, EventArgs e)
        {
            Symbol.Barcode.ReaderData TheReaderData = Scanning.MyReaderData;

            // If it is a successful read (as opposed to a failed one)
            if (TheReaderData.Result == Symbol.Results.SUCCESS)
            {

                if (TheReaderData.Type == Symbol.Barcode.DecoderTypes.DATAMATRIX)
                {
                    //Symbol.Barcode.DecoderTypes.DATAMATRIX
                    util.Equip_DataMatrix scannedDataMatrix = new util.Equip_DataMatrix(TheReaderData.Text);

                    serialNumberTextBox.Text = scannedDataMatrix.SerialNumber;
                    mfrComboBox.SelectedValue = scannedDataMatrix.MFR;
                    populateProductComboBox(mfrComboBox.SelectedValue.ToString());
                    productComboBox.SelectedValue = scannedDataMatrix.PartNumber;

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

        private void equipmentForm_Closed(object sender, EventArgs e)
        {
            Scanning.TermReader();
        }

        private void cancelActionEquipmentMenuItem_Click(object sender, EventArgs e)
        {
            insertEquipmentMenuItem.Text = "New";
            cancelActionEquipmentMenuItem.Enabled = false;
            Scanning.StopRead();
        }

        private void mfrComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mfrComboBox.SelectedValue.ToString() != "System.Data.DataRowView")
                populateProductComboBox(mfrComboBox.SelectedValue.ToString());
        }
    }
}