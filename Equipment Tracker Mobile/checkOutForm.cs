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
        private SQLiteConnection kumpotDBConnection = new SQLiteConnection("Data Source=|DataDirectory|\\Data\\kumpotDB.db3");

        public checkOutForm()
        {
            InitializeComponent();
        }

        private void checkOutForm_Load(object sender, EventArgs e)
        {
            //populateTreeView();
            populatePersonnel();
            populateEquipment();
        }
        private void populatePersonnel()
        {
        }

        private void populateEquipment()
        {
        }

        //private void populateTreeView()
        //{
        //    //SELECT SerialNumber FROM EquipInventory
        //    //WHERE SerialNumber !=  (SELECT CASE WHEN COUNT(*) > 0 THEN SerialNumber ELSE 0 END FROM PersonnelCheckOut WHERE ReturnedDate IS NULL)
        //    SQLiteDataAdapter equipmentDataAdapter = new SQLiteDataAdapter("SELECT SerialNumber, PartNumber FROM EquipInventory " +
        //        "WHERE SerialNumber != (SELECT CASE WHEN COUNT(*) > 0 THEN SerialNumber ELSE 0 END FROM PersonnelCheckout WHERE ReturnedDate IS NULL)" +
        //        "; SELECT PartNumber, CageNumber, ProductName FROM EquipType; SELECT CageNumber, Company FROM EquipMFR;", kumpotDBConnection);
        //    DataSet kumpotDataSet = new DataSet("Equipment");
        //    kumpotDBConnection.Open();
        //    equipmentDataAdapter.Fill(kumpotDataSet);
        //    kumpotDBConnection.Close();

        //    kumpotDataSet.Relations.Add("MFR", kumpotDataSet.Tables[2].Columns["CageNumber"], kumpotDataSet.Tables[1].Columns["CageNumber"]);
        //    kumpotDataSet.Relations.Add("Product", kumpotDataSet.Tables[1].Columns["PartNumber"], kumpotDataSet.Tables[0].Columns["PartNumber"]);

        //    equipmentTreeView.Nodes.Clear();
        //    foreach (DataRow row in kumpotDataSet.Tables[2].Rows)
        //    {
        //        TreeNode childNode = new TreeNode();
        //        foreach (DataRow childRow in row.GetChildRows("MFR"))
        //        {
        //            TreeNode grandChildNode = new TreeNode();
        //            foreach (DataRow childRow2 in childRow.GetChildRows("Product"))
        //            {
        //                grandChildNode.Nodes.Add(childRow2["SerialNumber"].ToString());
        //            }
        //            grandChildNode.Text = childRow["ProductName"].ToString();
        //            childNode.Nodes.Add(grandChildNode);
        //        }
        //        childNode.Text = row["Company"].ToString();
        //        equipmentTreeView.Nodes.Add(childNode);
        //    }
        //}
    }
}