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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.personnelListBox = new System.Windows.Forms.ListBox();
            this.equipmentListBox = new System.Windows.Forms.ListBox();
            this.personnelTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkOutMainMenu
            // 
            this.checkOutMainMenu.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Sign Out";
            // 
            // personnelListBox
            // 
            this.personnelListBox.Location = new System.Drawing.Point(3, 3);
            this.personnelListBox.Name = "personnelListBox";
            this.personnelListBox.Size = new System.Drawing.Size(115, 100);
            this.personnelListBox.TabIndex = 3;
            // 
            // equipmentListBox
            // 
            this.equipmentListBox.Location = new System.Drawing.Point(124, 3);
            this.equipmentListBox.Name = "equipmentListBox";
            this.equipmentListBox.Size = new System.Drawing.Size(112, 100);
            this.equipmentListBox.TabIndex = 4;
            // 
            // personnelTextBox
            // 
            this.personnelTextBox.Location = new System.Drawing.Point(3, 110);
            this.personnelTextBox.Name = "personnelTextBox";
            this.personnelTextBox.Size = new System.Drawing.Size(115, 21);
            this.personnelTextBox.TabIndex = 5;
            this.personnelTextBox.Text = "personnelTextBox";
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Location = new System.Drawing.Point(124, 110);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(111, 21);
            this.equipmentTextBox.TabIndex = 6;
            this.equipmentTextBox.Text = "equipmentTextBox";
            // 
            // checkOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.equipmentTextBox);
            this.Controls.Add(this.personnelTextBox);
            this.Controls.Add(this.equipmentListBox);
            this.Controls.Add(this.personnelListBox);
            this.Menu = this.checkOutMainMenu;
            this.Name = "checkOutForm";
            this.Text = "Equipment CheckOut";
            this.Load += new System.EventHandler(this.checkOutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.ListBox personnelListBox;
        private System.Windows.Forms.ListBox equipmentListBox;
        private System.Windows.Forms.TextBox personnelTextBox;
        private System.Windows.Forms.TextBox equipmentTextBox;


    }
}