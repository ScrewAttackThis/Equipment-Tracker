namespace EquipmentTracker
{
    partial class equipTrackerMobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipTrackerMobile));
            this.viewEquipmentButton = new System.Windows.Forms.Button();
            this.viewPersonnelButton = new System.Windows.Forms.Button();
            this.viewCheckoutButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.kumpotLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // viewEquipmentButton
            // 
            this.viewEquipmentButton.Location = new System.Drawing.Point(69, 160);
            this.viewEquipmentButton.Name = "viewEquipmentButton";
            this.viewEquipmentButton.Size = new System.Drawing.Size(102, 20);
            this.viewEquipmentButton.TabIndex = 0;
            this.viewEquipmentButton.Text = "Equipment";
            this.viewEquipmentButton.Click += new System.EventHandler(this.viewEquipmentButton_Click);
            // 
            // viewPersonnelButton
            // 
            this.viewPersonnelButton.Location = new System.Drawing.Point(69, 197);
            this.viewPersonnelButton.Name = "viewPersonnelButton";
            this.viewPersonnelButton.Size = new System.Drawing.Size(102, 20);
            this.viewPersonnelButton.TabIndex = 2;
            this.viewPersonnelButton.Text = "Personnel";
            this.viewPersonnelButton.Click += new System.EventHandler(this.viewPersonnelButton_Click);
            // 
            // viewCheckoutButton
            // 
            this.viewCheckoutButton.Location = new System.Drawing.Point(69, 234);
            this.viewCheckoutButton.Name = "viewCheckoutButton";
            this.viewCheckoutButton.Size = new System.Drawing.Size(102, 20);
            this.viewCheckoutButton.TabIndex = 3;
            this.viewCheckoutButton.Text = "Checkout";
            this.viewCheckoutButton.Click += new System.EventHandler(this.viewCheckoutButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(69, 271);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(102, 20);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            // 
            // kumpotLogoPictureBox
            // 
            this.kumpotLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.kumpotLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.kumpotLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("kumpotLogoPictureBox.Image")));
            this.kumpotLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.kumpotLogoPictureBox.Name = "kumpotLogoPictureBox";
            this.kumpotLogoPictureBox.Size = new System.Drawing.Size(240, 154);
            this.kumpotLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // equipTrackerMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.viewEquipmentButton);
            this.Controls.Add(this.kumpotLogoPictureBox);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.viewCheckoutButton);
            this.Controls.Add(this.viewPersonnelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "equipTrackerMobile";
            this.Text = "KUMPOT Mobile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewEquipmentButton;
        private System.Windows.Forms.Button viewPersonnelButton;
        private System.Windows.Forms.Button viewCheckoutButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.PictureBox kumpotLogoPictureBox;
    }
}

