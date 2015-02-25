namespace EquipmentTracker
{
    partial class checkOutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu checkOutMainMenu;

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
            this.checkOutMainMenu = new System.Windows.Forms.MainMenu();
            this.signOutMenuItem = new System.Windows.Forms.MenuItem();
            this.personnelListBox = new System.Windows.Forms.ListBox();
            this.equipmentListBox = new System.Windows.Forms.ListBox();
            this.ediTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.signInMenuItem = new System.Windows.Forms.MenuItem();
            this.checkedOutListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkOutMainMenu
            // 
            this.checkOutMainMenu.MenuItems.Add(this.signOutMenuItem);
            this.checkOutMainMenu.MenuItems.Add(this.signInMenuItem);
            // 
            // signOutMenuItem
            // 
            this.signOutMenuItem.Text = "Sign Out";
            this.signOutMenuItem.Click += new System.EventHandler(this.signOutMenuItem_Click);
            // 
            // personnelListBox
            // 
            this.personnelListBox.Location = new System.Drawing.Point(3, 3);
            this.personnelListBox.Name = "personnelListBox";
            this.personnelListBox.Size = new System.Drawing.Size(115, 100);
            this.personnelListBox.TabIndex = 3;
            this.personnelListBox.SelectedIndexChanged += new System.EventHandler(this.personnelListBox_SelectedIndexChanged);
            // 
            // equipmentListBox
            // 
            this.equipmentListBox.Location = new System.Drawing.Point(124, 3);
            this.equipmentListBox.Name = "equipmentListBox";
            this.equipmentListBox.Size = new System.Drawing.Size(112, 100);
            this.equipmentListBox.TabIndex = 4;
            this.equipmentListBox.SelectedIndexChanged += new System.EventHandler(this.equipmentListBox_SelectedIndexChanged);
            // 
            // ediTextBox
            // 
            this.ediTextBox.Location = new System.Drawing.Point(3, 110);
            this.ediTextBox.Name = "ediTextBox";
            this.ediTextBox.Size = new System.Drawing.Size(115, 21);
            this.ediTextBox.TabIndex = 5;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(124, 110);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(111, 21);
            this.serialNumberTextBox.TabIndex = 6;
            // 
            // signInMenuItem
            // 
            this.signInMenuItem.Text = "Sign In";
            this.signInMenuItem.Click += new System.EventHandler(this.signInMenuItem_Click);
            // 
            // checkedOutListBox
            // 
            this.checkedOutListBox.Location = new System.Drawing.Point(3, 137);
            this.checkedOutListBox.Name = "checkedOutListBox";
            this.checkedOutListBox.Size = new System.Drawing.Size(232, 128);
            this.checkedOutListBox.TabIndex = 7;
            // 
            // checkOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.checkedOutListBox);
            this.Controls.Add(this.serialNumberTextBox);
            this.Controls.Add(this.ediTextBox);
            this.Controls.Add(this.equipmentListBox);
            this.Controls.Add(this.personnelListBox);
            this.Menu = this.checkOutMainMenu;
            this.MinimizeBox = false;
            this.Name = "checkOutForm";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.checkOutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem signOutMenuItem;
        private System.Windows.Forms.ListBox personnelListBox;
        private System.Windows.Forms.ListBox equipmentListBox;
        private System.Windows.Forms.TextBox ediTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.MenuItem signInMenuItem;
        private System.Windows.Forms.ListBox checkedOutListBox;


    }
}