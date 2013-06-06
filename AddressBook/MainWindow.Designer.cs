namespace AddressBook
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.contactListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contactListBox
            // 
            this.contactListBox.FormattingEnabled = true;
            this.contactListBox.Location = new System.Drawing.Point(12, 13);
            this.contactListBox.Name = "contactListBox";
            this.contactListBox.Size = new System.Drawing.Size(383, 251);
            this.contactListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addButton.Location = new System.Drawing.Point(402, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add New Contact";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.contactListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox contactListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;


    }
}