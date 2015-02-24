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
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.insertPersonnelButton = new System.Windows.Forms.Button();
            this.deletePersonnelButton = new System.Windows.Forms.Button();
            this.editPersonnelButton = new System.Windows.Forms.Button();
            this.personnelInputPanel = new Microsoft.WindowsCE.Forms.InputPanel();
            this.personnelDetailsPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
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
            this.personnelDetailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.personnelDetailsPanel.Location = new System.Drawing.Point(0, 100);
            this.personnelDetailsPanel.Name = "personnelDetailsPanel";
            this.personnelDetailsPanel.Size = new System.Drawing.Size(159, 168);
            // 
            // branchComboBox
            // 
            this.branchComboBox.Enabled = false;
            this.branchComboBox.Location = new System.Drawing.Point(62, 146);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(89, 22);
            this.branchComboBox.TabIndex = 12;
            // 
            // rankTextBox
            // 
            this.rankTextBox.Location = new System.Drawing.Point(52, 118);
            this.rankTextBox.Name = "rankTextBox";
            this.rankTextBox.ReadOnly = true;
            this.rankTextBox.Size = new System.Drawing.Size(100, 21);
            this.rankTextBox.TabIndex = 11;
            // 
            // ediTextBox
            // 
            this.ediTextBox.Location = new System.Drawing.Point(52, 90);
            this.ediTextBox.Name = "ediTextBox";
            this.ediTextBox.ReadOnly = true;
            this.ediTextBox.Size = new System.Drawing.Size(100, 21);
            this.ediTextBox.TabIndex = 10;
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Location = new System.Drawing.Point(52, 62);
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.ReadOnly = true;
            this.middleInitialTextBox.Size = new System.Drawing.Size(100, 21);
            this.middleInitialTextBox.TabIndex = 9;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(52, 34);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(52, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 21);
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
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.cancelButton);
            this.controlsPanel.Controls.Add(this.insertPersonnelButton);
            this.controlsPanel.Controls.Add(this.deletePersonnelButton);
            this.controlsPanel.Controls.Add(this.editPersonnelButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlsPanel.Location = new System.Drawing.Point(159, 100);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(81, 168);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(4, 144);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 20);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // insertPersonnelButton
            // 
            this.insertPersonnelButton.Location = new System.Drawing.Point(4, 5);
            this.insertPersonnelButton.Name = "insertPersonnelButton";
            this.insertPersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.insertPersonnelButton.TabIndex = 8;
            this.insertPersonnelButton.Text = "New";
            this.insertPersonnelButton.Click += new System.EventHandler(this.insertPersonnelButton_Click);
            // 
            // deletePersonnelButton
            // 
            this.deletePersonnelButton.Location = new System.Drawing.Point(4, 61);
            this.deletePersonnelButton.Name = "deletePersonnelButton";
            this.deletePersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.deletePersonnelButton.TabIndex = 10;
            this.deletePersonnelButton.Text = "Delete";
            this.deletePersonnelButton.Click += new System.EventHandler(this.deletePersonnelButton_Click);
            // 
            // editPersonnelButton
            // 
            this.editPersonnelButton.Location = new System.Drawing.Point(4, 33);
            this.editPersonnelButton.Name = "editPersonnelButton";
            this.editPersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.editPersonnelButton.TabIndex = 9;
            this.editPersonnelButton.Text = "Edit";
            this.editPersonnelButton.Click += new System.EventHandler(this.editPersonnelButton_Click);
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
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.personnelDetailsPanel);
            this.Controls.Add(this.personnelListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.personnelMainMenu;
            this.MinimizeBox = false;
            this.Name = "personnelForm";
            this.Text = "Personnel";
            this.Closed += new System.EventHandler(this.personnelForm_Closed);
            this.Load += new System.EventHandler(this.personnelForm_Load);
            this.personnelDetailsPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button insertPersonnelButton;
        private System.Windows.Forms.Button deletePersonnelButton;
        private System.Windows.Forms.Button editPersonnelButton;
        private Microsoft.WindowsCE.Forms.InputPanel personnelInputPanel;
    }
}