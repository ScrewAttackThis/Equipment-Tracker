namespace EquipmentTracker
{
    partial class personnelForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personnelForm));
            this.personnelDetailsPanel = new System.Windows.Forms.Panel();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.rankTextBox = new System.Windows.Forms.TextBox();
            this.ediTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.branchLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.ediLabel = new System.Windows.Forms.Label();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.personnelListBox = new System.Windows.Forms.ListBox();
            this.personnelMainMenu = new System.Windows.Forms.MainMenu();
            this.actionsMenuItem = new System.Windows.Forms.MenuItem();
            this.insertPersonnelMenuItem = new System.Windows.Forms.MenuItem();
            this.editPersonnelMenuItem = new System.Windows.Forms.MenuItem();
            this.deletePersonnelMenuItem = new System.Windows.Forms.MenuItem();
            this.cancelMenuItem = new System.Windows.Forms.MenuItem();
            this.personnelInputPanel = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.personnelDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelDetailsPanel
            // 
            this.personnelDetailsPanel.Controls.Add(this.branchComboBox);
            this.personnelDetailsPanel.Controls.Add(this.rankTextBox);
            this.personnelDetailsPanel.Controls.Add(this.ediTextBox);
            this.personnelDetailsPanel.Controls.Add(this.middleInitialTextBox);
            this.personnelDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.personnelDetailsPanel.Controls.Add(this.lastNameTextBox);
            this.personnelDetailsPanel.Controls.Add(this.branchLabel);
            this.personnelDetailsPanel.Controls.Add(this.rankLabel);
            this.personnelDetailsPanel.Controls.Add(this.ediLabel);
            this.personnelDetailsPanel.Controls.Add(this.middleInitialLabel);
            this.personnelDetailsPanel.Controls.Add(this.firstNameLabel);
            this.personnelDetailsPanel.Controls.Add(this.lastNameLabel);
            this.personnelDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelDetailsPanel.Location = new System.Drawing.Point(0, 100);
            this.personnelDetailsPanel.Name = "personnelDetailsPanel";
            this.personnelDetailsPanel.Size = new System.Drawing.Size(240, 168);
            // 
            // branchComboBox
            // 
            this.branchComboBox.Enabled = false;
            this.branchComboBox.Location = new System.Drawing.Point(62, 146);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(175, 22);
            this.branchComboBox.TabIndex = 12;
            // 
            // rankTextBox
            // 
            this.rankTextBox.Location = new System.Drawing.Point(52, 118);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.ReadOnly = true;
            this.rankTextBox.Size = new System.Drawing.Size(185, 21);
            this.rankTextBox.TabIndex = 11;
            // 
            // ediTextBox
            // 
            this.ediTextBox.Location = new System.Drawing.Point(52, 90);
            this.ediTextBox.Name = "ediTextBox";
            this.ediTextBox.ReadOnly = true;
            this.ediTextBox.Size = new System.Drawing.Size(185, 21);
            this.ediTextBox.TabIndex = 10;
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Location = new System.Drawing.Point(52, 62);
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.ReadOnly = true;
            this.middleInitialTextBox.Size = new System.Drawing.Size(185, 21);
            this.middleInitialTextBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(52, 34);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(185, 21);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(52, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(185, 21);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // branchLabel
            // 
            this.branchLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.branchLabel.Location = new System.Drawing.Point(3, 146);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(53, 20);
            this.branchLabel.Text = "Branch:";
            // 
            // rankLabel
            // 
            this.rankLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rankLabel.Location = new System.Drawing.Point(3, 118);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(43, 20);
            this.rankLabel.Text = "Rank:";
            // 
            // ediLabel
            // 
            this.ediLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ediLabel.Location = new System.Drawing.Point(3, 90);
            this.ediLabel.Name = "ediLabel";
            this.ediLabel.Size = new System.Drawing.Size(43, 20);
            this.ediLabel.Text = "EDI:";
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.middleInitialLabel.Location = new System.Drawing.Point(3, 62);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(43, 20);
            this.middleInitialLabel.Text = "Mid:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(3, 34);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(43, 20);
            this.firstNameLabel.Text = "First:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(3, 6);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(43, 20);
            this.lastNameLabel.Text = "Last:";
            // 
            // personnelListBox
            // 
            this.personnelListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.personnelListBox.Location = new System.Drawing.Point(0, 0);
            this.personnelListBox.Name = "personnelListBox";
            this.personnelListBox.Size = new System.Drawing.Size(240, 100);
            this.personnelListBox.TabIndex = 0;
            this.personnelListBox.SelectedValueChanged += new System.EventHandler(this.personnelListBox_SelectedValueChanged);
            // 
            // personnelMainMenu
            // 
            this.personnelMainMenu.MenuItems.Add(this.actionsMenuItem);
            this.personnelMainMenu.MenuItems.Add(this.cancelMenuItem);
            // 
            // actionsMenuItem
            // 
            this.actionsMenuItem.MenuItems.Add(this.insertPersonnelMenuItem);
            this.actionsMenuItem.MenuItems.Add(this.editPersonnelMenuItem);
            this.actionsMenuItem.MenuItems.Add(this.deletePersonnelMenuItem);
            this.actionsMenuItem.Text = "Actions";
            // 
            // insertPersonnelMenuItem
            // 
            this.insertPersonnelMenuItem.Text = "New";
            this.insertPersonnelMenuItem.Click += new System.EventHandler(this.insertPersonnelMenuItem_Click);
            // 
            // editPersonnelMenuItem
            // 
            this.editPersonnelMenuItem.Text = "Edit";
            this.editPersonnelMenuItem.Click += new System.EventHandler(this.editPersonnelMenuItem_Click);
            // 
            // deletePersonnelMenuItem
            // 
            this.deletePersonnelMenuItem.Text = "Delete";
            this.deletePersonnelMenuItem.Click += new System.EventHandler(this.deletePersonnelMenuItem_Click);
            // 
            // cancelMenuItem
            // 
            this.cancelMenuItem.Enabled = false;
            this.cancelMenuItem.Text = "Cancel";
            this.cancelMenuItem.Click += new System.EventHandler(this.cancelMenuItem_Click);
            // 
            // personnelInputPanel
            // 
            this.personnelInputPanel.EnabledChanged += new System.EventHandler(this.personnelInputPanel_EnabledChanged);
            // 
            // personnelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.personnelDetailsPanel);
            this.Controls.Add(this.personnelListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.personnelMainMenu;
            this.MinimizeBox = false;
            this.Name = "personnelForm";
            this.Text = "Personnel";
            this.Load += new System.EventHandler(this.personnelForm_Load);
            this.Closed += new System.EventHandler(this.personnelForm_Closed);
            this.personnelDetailsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel personnelDetailsPanel;
        private System.Windows.Forms.TextBox middleInitialTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label ediLabel;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ListBox personnelListBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.TextBox rankTextBox;
        private System.Windows.Forms.TextBox ediTextBox;
        private System.Windows.Forms.MainMenu personnelMainMenu;
        private Microsoft.WindowsCE.Forms.InputPanel personnelInputPanel;
        private System.Windows.Forms.MenuItem actionsMenuItem;
        private System.Windows.Forms.MenuItem insertPersonnelMenuItem;
        private System.Windows.Forms.MenuItem editPersonnelMenuItem;
        private System.Windows.Forms.MenuItem deletePersonnelMenuItem;
        private System.Windows.Forms.MenuItem cancelMenuItem;
    }
}