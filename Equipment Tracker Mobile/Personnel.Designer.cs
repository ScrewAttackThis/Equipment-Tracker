namespace KUMPOT_Mobile
{
    partial class personnel
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
            this.personnelTabControl = new System.Windows.Forms.TabControl();
            this.personnelTabPage = new System.Windows.Forms.TabPage();
            this.refreshPersonnelButton = new System.Windows.Forms.Button();
            this.deletePersonnelButton = new System.Windows.Forms.Button();
            this.personnelDetailsViewButton = new System.Windows.Forms.Button();
            this.editPersonnelButton = new System.Windows.Forms.Button();
            this.personnelDetailsPanel = new System.Windows.Forms.Panel();
            this.lastNameViewLabel = new System.Windows.Forms.Label();
            this.rankViewLabel = new System.Windows.Forms.Label();
            this.ediViewLabel = new System.Windows.Forms.Label();
            this.middleInitialViewLabel = new System.Windows.Forms.Label();
            this.firstNameViewLabel = new System.Windows.Forms.Label();
            this.branchViewLabel = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.rankLabel = new System.Windows.Forms.Label();
            this.ediLabel = new System.Windows.Forms.Label();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.personnelListBox = new System.Windows.Forms.ListBox();
            this.addPersonnelTabPage = new System.Windows.Forms.TabPage();
            this.showKeyboardButton = new System.Windows.Forms.Button();
            this.branchAddComboBox = new System.Windows.Forms.ComboBox();
            this.rawDataLabel = new System.Windows.Forms.Label();
            this.rankAddTextBox = new System.Windows.Forms.TextBox();
            this.branchAddLabel = new System.Windows.Forms.Label();
            this.rankAddLabel = new System.Windows.Forms.Label();
            this.ediAddTextBox = new System.Windows.Forms.TextBox();
            this.ediAddLabel = new System.Windows.Forms.Label();
            this.middleInitialAddTextBox = new System.Windows.Forms.TextBox();
            this.firstNameAddTextBox = new System.Windows.Forms.TextBox();
            this.lastNameAddTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialAddLabel = new System.Windows.Forms.Label();
            this.firstNameAddLabel = new System.Windows.Forms.Label();
            this.lastNameAddLabel = new System.Windows.Forms.Label();
            this.enableScanButton = new System.Windows.Forms.Button();
            this.clearPersonnelButton = new System.Windows.Forms.Button();
            this.addPersonnelButton = new System.Windows.Forms.Button();
            this.personnelBarcode = new Barcode.Barcode();
            this.kumpotPersonnelInputPanel = new Microsoft.WindowsCE.Forms.InputPanel();
            this.editPersonnelTabPage = new System.Windows.Forms.TabPage();
            this.branchEditComboBox = new System.Windows.Forms.ComboBox();
            this.rankEditTextBox = new System.Windows.Forms.TextBox();
            this.branchEditLabel = new System.Windows.Forms.Label();
            this.rankEditLabel = new System.Windows.Forms.Label();
            this.ediEditTextBox = new System.Windows.Forms.TextBox();
            this.ediEditLabel = new System.Windows.Forms.Label();
            this.middleInitialEditTextBox = new System.Windows.Forms.TextBox();
            this.firstNameEditTextBox = new System.Windows.Forms.TextBox();
            this.lastNameEditTextBox = new System.Windows.Forms.TextBox();
            this.middleInitialEditLabel = new System.Windows.Forms.Label();
            this.firstNameEditLabel = new System.Windows.Forms.Label();
            this.lastNameEditLabel = new System.Windows.Forms.Label();
            this.keyboardInputEditButton = new System.Windows.Forms.Button();
            this.clearPersonnelEditButton = new System.Windows.Forms.Button();
            this.updatePersonnelButton = new System.Windows.Forms.Button();
            this.personnelTabControl.SuspendLayout();
            this.personnelTabPage.SuspendLayout();
            this.personnelDetailsPanel.SuspendLayout();
            this.addPersonnelTabPage.SuspendLayout();
            this.editPersonnelTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // personnelTabControl
            // 
            this.personnelTabControl.Controls.Add(this.personnelTabPage);
            this.personnelTabControl.Controls.Add(this.addPersonnelTabPage);
            this.personnelTabControl.Controls.Add(this.editPersonnelTabPage);
            this.personnelTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelTabControl.Location = new System.Drawing.Point(0, 0);
            this.personnelTabControl.Name = "personnelTabControl";
            this.personnelTabControl.SelectedIndex = 0;
            this.personnelTabControl.Size = new System.Drawing.Size(240, 294);
            this.personnelTabControl.TabIndex = 0;
            this.personnelTabControl.SelectedIndexChanged += new System.EventHandler(this.personnelTabControl_SelectedIndexChanged);
            // 
            // personnelTabPage
            // 
            this.personnelTabPage.Controls.Add(this.refreshPersonnelButton);
            this.personnelTabPage.Controls.Add(this.deletePersonnelButton);
            this.personnelTabPage.Controls.Add(this.personnelDetailsViewButton);
            this.personnelTabPage.Controls.Add(this.editPersonnelButton);
            this.personnelTabPage.Controls.Add(this.personnelDetailsPanel);
            this.personnelTabPage.Controls.Add(this.personnelListBox);
            this.personnelTabPage.Location = new System.Drawing.Point(0, 0);
            this.personnelTabPage.Name = "personnelTabPage";
            this.personnelTabPage.Size = new System.Drawing.Size(240, 271);
            this.personnelTabPage.Text = "Personnel";
            // 
            // refreshPersonnelButton
            // 
            this.refreshPersonnelButton.Location = new System.Drawing.Point(165, 146);
            this.refreshPersonnelButton.Name = "refreshPersonnelButton";
            this.refreshPersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.refreshPersonnelButton.TabIndex = 4;
            this.refreshPersonnelButton.Text = "Refresh";
            this.refreshPersonnelButton.Click += new System.EventHandler(this.refreshPersonnelButton_Click);
            // 
            // deletePersonnelButton
            // 
            this.deletePersonnelButton.Location = new System.Drawing.Point(165, 198);
            this.deletePersonnelButton.Name = "deletePersonnelButton";
            this.deletePersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.deletePersonnelButton.TabIndex = 3;
            this.deletePersonnelButton.Text = "Delete";
            this.deletePersonnelButton.Click += new System.EventHandler(this.deletePersonnelButton_Click);
            // 
            // personnelDetailsViewButton
            // 
            this.personnelDetailsViewButton.Location = new System.Drawing.Point(165, 120);
            this.personnelDetailsViewButton.Name = "personnelDetailsViewButton";
            this.personnelDetailsViewButton.Size = new System.Drawing.Size(72, 20);
            this.personnelDetailsViewButton.TabIndex = 2;
            this.personnelDetailsViewButton.Text = "Details";
            this.personnelDetailsViewButton.Click += new System.EventHandler(this.personnelDetailsViewButton_Click);
            // 
            // editPersonnelButton
            // 
            this.editPersonnelButton.Location = new System.Drawing.Point(165, 172);
            this.editPersonnelButton.Name = "editPersonnelButton";
            this.editPersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.editPersonnelButton.TabIndex = 1;
            this.editPersonnelButton.Text = "Edit";
            this.editPersonnelButton.Click += new System.EventHandler(this.editPersonnelButton_Click);
            // 
            // personnelDetailsPanel
            // 
            this.personnelDetailsPanel.Controls.Add(this.lastNameViewLabel);
            this.personnelDetailsPanel.Controls.Add(this.rankViewLabel);
            this.personnelDetailsPanel.Controls.Add(this.ediViewLabel);
            this.personnelDetailsPanel.Controls.Add(this.middleInitialViewLabel);
            this.personnelDetailsPanel.Controls.Add(this.firstNameViewLabel);
            this.personnelDetailsPanel.Controls.Add(this.branchViewLabel);
            this.personnelDetailsPanel.Controls.Add(this.branchLabel);
            this.personnelDetailsPanel.Controls.Add(this.rankLabel);
            this.personnelDetailsPanel.Controls.Add(this.ediLabel);
            this.personnelDetailsPanel.Controls.Add(this.middleInitialLabel);
            this.personnelDetailsPanel.Controls.Add(this.firstNameLabel);
            this.personnelDetailsPanel.Controls.Add(this.lastNameLabel);
            this.personnelDetailsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.personnelDetailsPanel.Location = new System.Drawing.Point(0, 114);
            this.personnelDetailsPanel.Name = "personnelDetailsPanel";
            this.personnelDetailsPanel.Size = new System.Drawing.Size(159, 157);
            // 
            // lastNameViewLabel
            // 
            this.lastNameViewLabel.Location = new System.Drawing.Point(53, 4);
            this.lastNameViewLabel.Name = "lastNameViewLabel";
            this.lastNameViewLabel.Size = new System.Drawing.Size(103, 20);
            // 
            // rankViewLabel
            // 
            this.rankViewLabel.Location = new System.Drawing.Point(53, 84);
            this.rankViewLabel.Name = "rankViewLabel";
            this.rankViewLabel.Size = new System.Drawing.Size(103, 20);
            // 
            // ediViewLabel
            // 
            this.ediViewLabel.Location = new System.Drawing.Point(53, 64);
            this.ediViewLabel.Name = "ediViewLabel";
            this.ediViewLabel.Size = new System.Drawing.Size(103, 20);
            // 
            // middleInitialViewLabel
            // 
            this.middleInitialViewLabel.Location = new System.Drawing.Point(53, 44);
            this.middleInitialViewLabel.Name = "middleInitialViewLabel";
            this.middleInitialViewLabel.Size = new System.Drawing.Size(103, 20);
            // 
            // firstNameViewLabel
            // 
            this.firstNameViewLabel.Location = new System.Drawing.Point(53, 24);
            this.firstNameViewLabel.Name = "firstNameViewLabel";
            this.firstNameViewLabel.Size = new System.Drawing.Size(103, 20);
            // 
            // branchViewLabel
            // 
            this.branchViewLabel.Location = new System.Drawing.Point(53, 104);
            this.branchViewLabel.Name = "branchViewLabel";
            this.branchViewLabel.Size = new System.Drawing.Size(103, 20);
            // 
            // branchLabel
            // 
            this.branchLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.branchLabel.Location = new System.Drawing.Point(3, 104);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(53, 20);
            this.branchLabel.Text = "Branch:";
            // 
            // rankLabel
            // 
            this.rankLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rankLabel.Location = new System.Drawing.Point(3, 84);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(43, 20);
            this.rankLabel.Text = "Rank:";
            // 
            // ediLabel
            // 
            this.ediLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ediLabel.Location = new System.Drawing.Point(3, 64);
            this.ediLabel.Name = "ediLabel";
            this.ediLabel.Size = new System.Drawing.Size(43, 20);
            this.ediLabel.Text = "EDI:";
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.middleInitialLabel.Location = new System.Drawing.Point(3, 44);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(43, 20);
            this.middleInitialLabel.Text = "Mid:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.firstNameLabel.Location = new System.Drawing.Point(3, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(43, 20);
            this.firstNameLabel.Text = "First:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lastNameLabel.Location = new System.Drawing.Point(3, 4);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(43, 20);
            this.lastNameLabel.Text = "Last:";
            // 
            // personnelListBox
            // 
            this.personnelListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.personnelListBox.Location = new System.Drawing.Point(0, 0);
            this.personnelListBox.Name = "personnelListBox";
            this.personnelListBox.Size = new System.Drawing.Size(240, 114);
            this.personnelListBox.TabIndex = 0;
            // 
            // addPersonnelTabPage
            // 
            this.addPersonnelTabPage.Controls.Add(this.showKeyboardButton);
            this.addPersonnelTabPage.Controls.Add(this.branchAddComboBox);
            this.addPersonnelTabPage.Controls.Add(this.rawDataLabel);
            this.addPersonnelTabPage.Controls.Add(this.rankAddTextBox);
            this.addPersonnelTabPage.Controls.Add(this.branchAddLabel);
            this.addPersonnelTabPage.Controls.Add(this.rankAddLabel);
            this.addPersonnelTabPage.Controls.Add(this.ediAddTextBox);
            this.addPersonnelTabPage.Controls.Add(this.ediAddLabel);
            this.addPersonnelTabPage.Controls.Add(this.middleInitialAddTextBox);
            this.addPersonnelTabPage.Controls.Add(this.firstNameAddTextBox);
            this.addPersonnelTabPage.Controls.Add(this.lastNameAddTextBox);
            this.addPersonnelTabPage.Controls.Add(this.middleInitialAddLabel);
            this.addPersonnelTabPage.Controls.Add(this.firstNameAddLabel);
            this.addPersonnelTabPage.Controls.Add(this.lastNameAddLabel);
            this.addPersonnelTabPage.Controls.Add(this.enableScanButton);
            this.addPersonnelTabPage.Controls.Add(this.clearPersonnelButton);
            this.addPersonnelTabPage.Controls.Add(this.addPersonnelButton);
            this.addPersonnelTabPage.Location = new System.Drawing.Point(0, 0);
            this.addPersonnelTabPage.Name = "addPersonnelTabPage";
            this.addPersonnelTabPage.Size = new System.Drawing.Size(240, 271);
            this.addPersonnelTabPage.Text = "Add";
            // 
            // showKeyboardButton
            // 
            this.showKeyboardButton.Location = new System.Drawing.Point(83, 223);
            this.showKeyboardButton.Name = "showKeyboardButton";
            this.showKeyboardButton.Size = new System.Drawing.Size(72, 20);
            this.showKeyboardButton.TabIndex = 42;
            this.showKeyboardButton.Text = "Keyboard";
            this.showKeyboardButton.Click += new System.EventHandler(this.showKeyboardButton_Click);
            // 
            // branchAddComboBox
            // 
            this.branchAddComboBox.Location = new System.Drawing.Point(69, 142);
            this.branchAddComboBox.Name = "branchAddComboBox";
            this.branchAddComboBox.Size = new System.Drawing.Size(164, 22);
            this.branchAddComboBox.TabIndex = 34;
            // 
            // rawDataLabel
            // 
            this.rawDataLabel.Location = new System.Drawing.Point(3, 167);
            this.rawDataLabel.Name = "rawDataLabel";
            this.rawDataLabel.Size = new System.Drawing.Size(229, 48);
            // 
            // rankAddTextBox
            // 
            this.rankAddTextBox.Location = new System.Drawing.Point(53, 115);
            this.rankAddTextBox.Name = "rankAddTextBox";
            this.rankAddTextBox.Size = new System.Drawing.Size(180, 21);
            this.rankAddTextBox.TabIndex = 25;
            // 
            // branchAddLabel
            // 
            this.branchAddLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.branchAddLabel.Location = new System.Drawing.Point(9, 142);
            this.branchAddLabel.Name = "branchAddLabel";
            this.branchAddLabel.Size = new System.Drawing.Size(53, 20);
            this.branchAddLabel.Text = "Branch:";
            // 
            // rankAddLabel
            // 
            this.rankAddLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rankAddLabel.Location = new System.Drawing.Point(9, 115);
            this.rankAddLabel.Name = "rankAddLabel";
            this.rankAddLabel.Size = new System.Drawing.Size(43, 20);
            this.rankAddLabel.Text = "Rank:";
            // 
            // ediAddTextBox
            // 
            this.ediAddTextBox.Location = new System.Drawing.Point(53, 88);
            this.ediAddTextBox.Name = "ediAddTextBox";
            this.ediAddTextBox.Size = new System.Drawing.Size(180, 21);
            this.ediAddTextBox.TabIndex = 24;
            // 
            // ediAddLabel
            // 
            this.ediAddLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ediAddLabel.Location = new System.Drawing.Point(9, 88);
            this.ediAddLabel.Name = "ediAddLabel";
            this.ediAddLabel.Size = new System.Drawing.Size(43, 20);
            this.ediAddLabel.Text = "EDI:";
            // 
            // middleInitialAddTextBox
            // 
            this.middleInitialAddTextBox.Location = new System.Drawing.Point(53, 61);
            this.middleInitialAddTextBox.Name = "middleInitialAddTextBox";
            this.middleInitialAddTextBox.Size = new System.Drawing.Size(180, 21);
            this.middleInitialAddTextBox.TabIndex = 23;
            // 
            // firstNameAddTextBox
            // 
            this.firstNameAddTextBox.Location = new System.Drawing.Point(53, 34);
            this.firstNameAddTextBox.Name = "firstNameAddTextBox";
            this.firstNameAddTextBox.Size = new System.Drawing.Size(180, 21);
            this.firstNameAddTextBox.TabIndex = 22;
            // 
            // lastNameAddTextBox
            // 
            this.lastNameAddTextBox.Location = new System.Drawing.Point(53, 7);
            this.lastNameAddTextBox.Name = "lastNameAddTextBox";
            this.lastNameAddTextBox.Size = new System.Drawing.Size(180, 21);
            this.lastNameAddTextBox.TabIndex = 21;
            // 
            // middleInitialAddLabel
            // 
            this.middleInitialAddLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.middleInitialAddLabel.Location = new System.Drawing.Point(9, 62);
            this.middleInitialAddLabel.Name = "middleInitialAddLabel";
            this.middleInitialAddLabel.Size = new System.Drawing.Size(43, 20);
            this.middleInitialAddLabel.Text = "Mid:";
            // 
            // firstNameAddLabel
            // 
            this.firstNameAddLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.firstNameAddLabel.Location = new System.Drawing.Point(9, 35);
            this.firstNameAddLabel.Name = "firstNameAddLabel";
            this.firstNameAddLabel.Size = new System.Drawing.Size(43, 20);
            this.firstNameAddLabel.Text = "First:";
            // 
            // lastNameAddLabel
            // 
            this.lastNameAddLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lastNameAddLabel.Location = new System.Drawing.Point(9, 8);
            this.lastNameAddLabel.Name = "lastNameAddLabel";
            this.lastNameAddLabel.Size = new System.Drawing.Size(43, 20);
            this.lastNameAddLabel.Text = "Last:";
            // 
            // enableScanButton
            // 
            this.enableScanButton.Location = new System.Drawing.Point(5, 249);
            this.enableScanButton.Name = "enableScanButton";
            this.enableScanButton.Size = new System.Drawing.Size(72, 20);
            this.enableScanButton.TabIndex = 3;
            this.enableScanButton.Text = "Enable";
            this.enableScanButton.Click += new System.EventHandler(this.enableScanButton_Click);
            // 
            // clearPersonnelButton
            // 
            this.clearPersonnelButton.Location = new System.Drawing.Point(83, 249);
            this.clearPersonnelButton.Name = "clearPersonnelButton";
            this.clearPersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.clearPersonnelButton.TabIndex = 2;
            this.clearPersonnelButton.Text = "Clear";
            this.clearPersonnelButton.Click += new System.EventHandler(this.clearPersonnelButton_Click);
            // 
            // addPersonnelButton
            // 
            this.addPersonnelButton.Location = new System.Drawing.Point(161, 249);
            this.addPersonnelButton.Name = "addPersonnelButton";
            this.addPersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.addPersonnelButton.TabIndex = 1;
            this.addPersonnelButton.Text = "Add";
            this.addPersonnelButton.Click += new System.EventHandler(this.addPersonnelButton_Click);
            // 
            // personnelBarcode
            // 
            this.personnelBarcode.OnRead += new Barcode.Barcode.ScannerReadEventHandler(this.personnelBarcode_OnRead);
            // 
            // editPersonnelTabPage
            // 
            this.editPersonnelTabPage.Controls.Add(this.keyboardInputEditButton);
            this.editPersonnelTabPage.Controls.Add(this.clearPersonnelEditButton);
            this.editPersonnelTabPage.Controls.Add(this.updatePersonnelButton);
            this.editPersonnelTabPage.Controls.Add(this.branchEditComboBox);
            this.editPersonnelTabPage.Controls.Add(this.rankEditTextBox);
            this.editPersonnelTabPage.Controls.Add(this.branchEditLabel);
            this.editPersonnelTabPage.Controls.Add(this.rankEditLabel);
            this.editPersonnelTabPage.Controls.Add(this.ediEditTextBox);
            this.editPersonnelTabPage.Controls.Add(this.ediEditLabel);
            this.editPersonnelTabPage.Controls.Add(this.middleInitialEditTextBox);
            this.editPersonnelTabPage.Controls.Add(this.firstNameEditTextBox);
            this.editPersonnelTabPage.Controls.Add(this.lastNameEditTextBox);
            this.editPersonnelTabPage.Controls.Add(this.middleInitialEditLabel);
            this.editPersonnelTabPage.Controls.Add(this.firstNameEditLabel);
            this.editPersonnelTabPage.Controls.Add(this.lastNameEditLabel);
            this.editPersonnelTabPage.Location = new System.Drawing.Point(0, 0);
            this.editPersonnelTabPage.Name = "editPersonnelTabPage";
            this.editPersonnelTabPage.Size = new System.Drawing.Size(240, 271);
            this.editPersonnelTabPage.Text = "Edit";
            // 
            // branchEditComboBox
            // 
            this.branchEditComboBox.Location = new System.Drawing.Point(69, 142);
            this.branchEditComboBox.Name = "branchEditComboBox";
            this.branchEditComboBox.Size = new System.Drawing.Size(164, 22);
            this.branchEditComboBox.TabIndex = 47;
            // 
            // rankEditTextBox
            // 
            this.rankEditTextBox.Location = new System.Drawing.Point(53, 115);
            this.rankEditTextBox.Name = "rankEditTextBox";
            this.rankEditTextBox.Size = new System.Drawing.Size(180, 21);
            this.rankEditTextBox.TabIndex = 46;
            // 
            // branchEditLabel
            // 
            this.branchEditLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.branchEditLabel.Location = new System.Drawing.Point(9, 142);
            this.branchEditLabel.Name = "branchEditLabel";
            this.branchEditLabel.Size = new System.Drawing.Size(53, 20);
            this.branchEditLabel.Text = "Branch:";
            // 
            // rankEditLabel
            // 
            this.rankEditLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rankEditLabel.Location = new System.Drawing.Point(9, 115);
            this.rankEditLabel.Name = "rankEditLabel";
            this.rankEditLabel.Size = new System.Drawing.Size(43, 20);
            this.rankEditLabel.Text = "Rank:";
            // 
            // ediEditTextBox
            // 
            this.ediEditTextBox.Location = new System.Drawing.Point(53, 88);
            this.ediEditTextBox.Name = "ediEditTextBox";
            this.ediEditTextBox.Size = new System.Drawing.Size(180, 21);
            this.ediEditTextBox.TabIndex = 45;
            // 
            // ediEditLabel
            // 
            this.ediEditLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ediEditLabel.Location = new System.Drawing.Point(9, 88);
            this.ediEditLabel.Name = "ediEditLabel";
            this.ediEditLabel.Size = new System.Drawing.Size(43, 20);
            this.ediEditLabel.Text = "EDI:";
            // 
            // middleInitialEditTextBox
            // 
            this.middleInitialEditTextBox.Location = new System.Drawing.Point(53, 61);
            this.middleInitialEditTextBox.Name = "middleInitialEditTextBox";
            this.middleInitialEditTextBox.Size = new System.Drawing.Size(180, 21);
            this.middleInitialEditTextBox.TabIndex = 44;
            // 
            // firstNameEditTextBox
            // 
            this.firstNameEditTextBox.Location = new System.Drawing.Point(53, 34);
            this.firstNameEditTextBox.Name = "firstNameEditTextBox";
            this.firstNameEditTextBox.Size = new System.Drawing.Size(180, 21);
            this.firstNameEditTextBox.TabIndex = 43;
            // 
            // lastNameEditTextBox
            // 
            this.lastNameEditTextBox.Location = new System.Drawing.Point(53, 7);
            this.lastNameEditTextBox.Name = "lastNameEditTextBox";
            this.lastNameEditTextBox.Size = new System.Drawing.Size(180, 21);
            this.lastNameEditTextBox.TabIndex = 42;
            // 
            // middleInitialEditLabel
            // 
            this.middleInitialEditLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.middleInitialEditLabel.Location = new System.Drawing.Point(9, 62);
            this.middleInitialEditLabel.Name = "middleInitialEditLabel";
            this.middleInitialEditLabel.Size = new System.Drawing.Size(43, 20);
            this.middleInitialEditLabel.Text = "Mid:";
            // 
            // firstNameEditLabel
            // 
            this.firstNameEditLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.firstNameEditLabel.Location = new System.Drawing.Point(9, 35);
            this.firstNameEditLabel.Name = "firstNameEditLabel";
            this.firstNameEditLabel.Size = new System.Drawing.Size(43, 20);
            this.firstNameEditLabel.Text = "First:";
            // 
            // lastNameEditLabel
            // 
            this.lastNameEditLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lastNameEditLabel.Location = new System.Drawing.Point(9, 8);
            this.lastNameEditLabel.Name = "lastNameEditLabel";
            this.lastNameEditLabel.Size = new System.Drawing.Size(43, 20);
            this.lastNameEditLabel.Text = "Last:";
            // 
            // keyboardInputEditButton
            // 
            this.keyboardInputEditButton.Location = new System.Drawing.Point(5, 248);
            this.keyboardInputEditButton.Name = "keyboardInputEditButton";
            this.keyboardInputEditButton.Size = new System.Drawing.Size(72, 20);
            this.keyboardInputEditButton.TabIndex = 58;
            this.keyboardInputEditButton.Text = "Keyboard";
            // 
            // clearPersonnelEditButton
            // 
            this.clearPersonnelEditButton.Location = new System.Drawing.Point(83, 248);
            this.clearPersonnelEditButton.Name = "clearPersonnelEditButton";
            this.clearPersonnelEditButton.Size = new System.Drawing.Size(72, 20);
            this.clearPersonnelEditButton.TabIndex = 56;
            this.clearPersonnelEditButton.Text = "Clear";
            // 
            // updatePersonnelButton
            // 
            this.updatePersonnelButton.Location = new System.Drawing.Point(161, 248);
            this.updatePersonnelButton.Name = "updatePersonnelButton";
            this.updatePersonnelButton.Size = new System.Drawing.Size(72, 20);
            this.updatePersonnelButton.TabIndex = 55;
            this.updatePersonnelButton.Text = "Update";
            // 
            // personnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.personnelTabControl);
            this.MinimizeBox = false;
            this.Name = "personnelForm";
            this.Text = "Personnel";
            this.Closed += new System.EventHandler(this.personnelForm_Closed);
            this.Load += new System.EventHandler(this.personnelForm_Load);
            this.personnelTabControl.ResumeLayout(false);
            this.personnelTabPage.ResumeLayout(false);
            this.personnelDetailsPanel.ResumeLayout(false);
            this.addPersonnelTabPage.ResumeLayout(false);
            this.editPersonnelTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl personnelTabControl;
        private System.Windows.Forms.TabPage personnelTabPage;
        private System.Windows.Forms.TabPage addPersonnelTabPage;
        private System.Windows.Forms.Panel personnelDetailsPanel;
        private System.Windows.Forms.Button enableScanButton;
        private System.Windows.Forms.Button clearPersonnelButton;
        private System.Windows.Forms.Button addPersonnelButton;
        private System.Windows.Forms.TextBox rankAddTextBox;
        private System.Windows.Forms.Label branchAddLabel;
        private System.Windows.Forms.Label rankAddLabel;
        private System.Windows.Forms.TextBox ediAddTextBox;
        private System.Windows.Forms.Label ediAddLabel;
        private System.Windows.Forms.TextBox middleInitialAddTextBox;
        private System.Windows.Forms.TextBox firstNameAddTextBox;
        private System.Windows.Forms.TextBox lastNameAddTextBox;
        private System.Windows.Forms.Label middleInitialAddLabel;
        private System.Windows.Forms.Label firstNameAddLabel;
        private System.Windows.Forms.Label lastNameAddLabel;
        private System.Windows.Forms.Label rawDataLabel;
        private Barcode.Barcode personnelBarcode;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.Label ediLabel;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label lastNameViewLabel;
        private System.Windows.Forms.Label rankViewLabel;
        private System.Windows.Forms.Label ediViewLabel;
        private System.Windows.Forms.Label middleInitialViewLabel;
        private System.Windows.Forms.Label firstNameViewLabel;
        private System.Windows.Forms.Label branchViewLabel;
        private System.Windows.Forms.Button deletePersonnelButton;
        private System.Windows.Forms.Button personnelDetailsViewButton;
        private System.Windows.Forms.Button editPersonnelButton;
        private System.Windows.Forms.Button refreshPersonnelButton;
        private System.Windows.Forms.ListBox personnelListBox;
        private System.Windows.Forms.ComboBox branchAddComboBox;
        private System.Windows.Forms.Button showKeyboardButton;
        private Microsoft.WindowsCE.Forms.InputPanel kumpotPersonnelInputPanel;
        private System.Windows.Forms.TabPage editPersonnelTabPage;
        private System.Windows.Forms.ComboBox branchEditComboBox;
        private System.Windows.Forms.TextBox rankEditTextBox;
        private System.Windows.Forms.Label branchEditLabel;
        private System.Windows.Forms.Label rankEditLabel;
        private System.Windows.Forms.TextBox ediEditTextBox;
        private System.Windows.Forms.Label ediEditLabel;
        private System.Windows.Forms.TextBox middleInitialEditTextBox;
        private System.Windows.Forms.TextBox firstNameEditTextBox;
        private System.Windows.Forms.TextBox lastNameEditTextBox;
        private System.Windows.Forms.Label middleInitialEditLabel;
        private System.Windows.Forms.Label firstNameEditLabel;
        private System.Windows.Forms.Label lastNameEditLabel;
        private System.Windows.Forms.Button keyboardInputEditButton;
        private System.Windows.Forms.Button clearPersonnelEditButton;
        private System.Windows.Forms.Button updatePersonnelButton;
    }
}