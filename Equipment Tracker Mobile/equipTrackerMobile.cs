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
    public partial class equipTrackerMobile : Form
    {
        public equipTrackerMobile()
        {
            InitializeComponent();
        }

        private void viewPersonnelButton_Click(object sender, EventArgs e)
        {
            personnelForm personnelForm = new personnelForm();
            personnelForm.Show();
        }

        private void viewEquipmentButton_Click(object sender, EventArgs e)
        {
            equipmentForm equipmentForm = new equipmentForm();
            equipmentForm.Show();
        }

        private void viewCheckoutButton_Click(object sender, EventArgs e)
        {
            checkOutForm checkOutForm = new checkOutForm();
            checkOutForm.Show();
        }
    }
}