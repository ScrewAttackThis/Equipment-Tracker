namespace EquipmentTracker
{
    partial class equipmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.equipmentMainMenu = new System.Windows.Forms.MainMenu();
            this.actionsEquipmentMenuItem = new System.Windows.Forms.MenuItem();
            this.insertEquipmentMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.cancelActionEquipmentMenuItem = new System.Windows.Forms.MenuItem();
            this.equipmentTreeView = new System.Windows.Forms.TreeView();
            this.equipmentDetailsPanel = new System.Windows.Forms.Panel();
            this.serialLabel = new System.Windows.Forms.Label();
            this.partLabel = new System.Windows.Forms.Label();
            this.mfrLabel = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.mfrComboBox = new System.Windows.Forms.ComboBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.deleteMenuItem = new System.Windows.Forms.MenuItem();
            this.equipmentDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentMainMenu
            // 
            this.equipmentMainMenu.MenuItems.Add(this.actionsEquipmentMenuItem);
            this.equipmentMainMenu.MenuItems.Add(this.cancelActionEquipmentMenuItem);
            // 
            // actionsEquipmentMenuItem
            // 
            this.actionsEquipmentMenuItem.MenuItems.Add(this.insertEquipmentMenuItem);
            this.actionsEquipmentMenuItem.MenuItems.Add(this.menuItem2);
            this.actionsEquipmentMenuItem.MenuItems.Add(this.deleteMenuItem);
            this.actionsEquipmentMenuItem.Text = "Actions";
            // 
            // insertEquipmentMenuItem
            // 
            this.insertEquipmentMenuItem.Text = "New";
            this.insertEquipmentMenuItem.Click += new System.EventHandler(this.insertEquipmentMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Edit";
            // 
            // cancelActionEquipmentMenuItem
            // 
            this.cancelActionEquipmentMenuItem.Enabled = false;
            this.cancelActionEquipmentMenuItem.Text = "Cancel";
            this.cancelActionEquipmentMenuItem.Click += new System.EventHandler(this.cancelActionEquipmentMenuItem_Click);
            // 
            // equipmentTreeView
            // 
            this.equipmentTreeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipmentTreeView.Location = new System.Drawing.Point(0, 0);
            this.equipmentTreeView.Name = "equipmentTreeView";
            this.equipmentTreeView.Size = new System.Drawing.Size(240, 114);
            this.equipmentTreeView.TabIndex = 0;
            // 
            // equipmentDetailsPanel
            // 
            this.equipmentDetailsPanel.Controls.Add(this.serialLabel);
            this.equipmentDetailsPanel.Controls.Add(this.partLabel);
            this.equipmentDetailsPanel.Controls.Add(this.mfrLabel);
            this.equipmentDetailsPanel.Controls.Add(this.productComboBox);
            this.equipmentDetailsPanel.Controls.Add(this.mfrComboBox);
            this.equipmentDetailsPanel.Controls.Add(this.serialNumberTextBox);
            this.equipmentDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentDetailsPanel.Location = new System.Drawing.Point(0, 114);
            this.equipmentDetailsPanel.Name = "equipmentDetailsPanel";
            this.equipmentDetailsPanel.Size = new System.Drawing.Size(240, 154);
            // 
            // serialLabel
            // 
            this.serialLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.serialLabel.Location = new System.Drawing.Point(4, 60);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(44, 20);
            this.serialLabel.Text = "Serial:";
            // 
            // partLabel
            // 
            this.partLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.partLabel.Location = new System.Drawing.Point(9, 33);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(39, 20);
            this.partLabel.Text = "Part:";
            // 
            // mfrLabel
            // 
            this.mfrLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.mfrLabel.Location = new System.Drawing.Point(9, 5);
            this.mfrLabel.Name = "mfrLabel";
            this.mfrLabel.Size = new System.Drawing.Size(39, 20);
            this.mfrLabel.Text = "MFR:";
            // 
            // productComboBox
            // 
            this.productComboBox.Location = new System.Drawing.Point(49, 31);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(188, 22);
            this.productComboBox.TabIndex = 7;
            // 
            // mfrComboBox
            // 
            this.mfrComboBox.Location = new System.Drawing.Point(49, 3);
            this.mfrComboBox.Name = "mfrComboBox";
            this.mfrComboBox.Size = new System.Drawing.Size(188, 22);
            this.mfrComboBox.TabIndex = 6;
            this.mfrComboBox.SelectedValueChanged += new System.EventHandler(this.mfrComboBox_SelectedValueChanged);
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(49, 59);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(188, 21);
            this.serialNumberTextBox.TabIndex = 5;
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Text = "Delete";
            // 
            // equipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.equipmentDetailsPanel);
            this.Controls.Add(this.equipmentTreeView);
            this.Menu = this.equipmentMainMenu;
            this.MinimizeBox = false;
            this.Name = "equipmentForm";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.equipmentForm_Load);
            this.Closed += new System.EventHandler(this.equipmentForm_Closed);
            this.equipmentDetailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu equipmentMainMenu;
        private System.Windows.Forms.TreeView equipmentTreeView;
        private System.Windows.Forms.MenuItem actionsEquipmentMenuItem;
        private System.Windows.Forms.MenuItem cancelActionEquipmentMenuItem;
        private System.Windows.Forms.MenuItem insertEquipmentMenuItem;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Panel equipmentDetailsPanel;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox mfrComboBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label partLabel;
        private System.Windows.Forms.Label mfrLabel;
        private System.Windows.Forms.MenuItem deleteMenuItem;
    }
}